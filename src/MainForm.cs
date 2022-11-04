using System;
using System.IO;
using System.Windows.Forms;
using SymmetryEncoder.Encoders;
using SymmetryEncoder.IOManagers;
using SymmetryEncoder.Exceptions;

namespace SymmetryEncoder
{
    sealed partial class MainForm : Form
    {
        private IEncoder _encoder;
        private readonly FileManager _fileManager;

        public MainForm()
        {
            InitializeComponent();

            EncryptRadioButton.Checked = true;
            AESRadioButton.Checked = true;
            EncryptRadioButton.CheckedChanged += this.EncryptOrDecryptRadioButton_CheckedChanged;
            DecryptRadioButton.CheckedChanged += this.EncryptOrDecryptRadioButton_CheckedChanged;

            this.EncryptOrDecryptRadioButton_CheckedChanged(null, null);

            this._fileManager = new FileManager();
            this._encoder = EncoderFactory.CreateEncoder(this);
        }

        private void EncryptOrDecryptTextFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AESRadioButton.Checked && this._encoder is not AesEncoder)
                    this._encoder = EncoderFactory.CreateEncoder(this);
                else if (RC2RadioButton.Checked && this._encoder is not RC2Encoder)
                    this._encoder = EncoderFactory.CreateEncoder(this);

                string openPathFromDialog = this._fileManager.OpenFileViaDialog();
                if (openPathFromDialog is null)
                    return;

                string savePathFromDialog = this._fileManager.SaveFileViaDialog();
                if (savePathFromDialog is null)
                    return;

                if (EncryptRadioButton.Checked) //encrypt text
                {
                    var encryptedBytes = this._encoder.EncryptText(File.ReadAllText(openPathFromDialog));
                    File.WriteAllBytes(savePathFromDialog, encryptedBytes);

                    string dataFilePath = string.Concat(savePathFromDialog, ".EncryptionData");
                    FileManager.WriteKeyAndIVToFile(this._encoder, dataFilePath);

                    MessageBox.Show($"The encrypted text was saved to a file at {savePathFromDialog};" +
                        $"\nthe decryption data was saved to a file at {dataFilePath}",
                        "Encryption Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else //decrypt text
                {
                    string decryptText = this._encoder.DecryptText(File.ReadAllBytes(openPathFromDialog));

                    File.WriteAllText(savePathFromDialog, decryptText);
                    MessageBox.Show($"Decrypted text was saved to file at {savePathFromDialog}",
                        "Decryption completed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplayer.DisplayException(ex);
            }
        }

        private void SaveKeyAndIVDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((AESRadioButton.Checked && this._encoder is RC2Encoder) || (RC2RadioButton.Checked && this._encoder is AesEncoder))
                    throw new FormatException("The Key and IV cannot be saved as they are intended for a different encryption algorithm!");

                string pathFromDialog = this._fileManager.SaveFileViaDialog();
                if (pathFromDialog is not null)
                {
                    string filePath = FileManager.WriteKeyAndIVToFile(this._encoder, pathFromDialog);
                    MessageBox.Show($"Your key and IV have been successfully saved in {filePath}", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplayer.DisplayException(ex);
            }
        }

        private void DownloadKeyAndIVDataFromUserPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFromDialog = this._fileManager.OpenFileViaDialog();
                if (pathFromDialog is not null)
                {
                    var enctyptionData = FileManager.ReadKeyAndIVFromFile(pathFromDialog);

                    this._encoder = EncoderFactory.CreateEncoder(this);
                    this._encoder.Key = enctyptionData.Item1;
                    this._encoder.IV = enctyptionData.Item2;

                    MessageBox.Show("Your Key and IV have been successfully uploaded", "Data Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplayer.DisplayException(ex);
            }
        }

        private void CreateNewEncryptDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            string pathFromDialog = this._fileManager.SaveFileViaDialog();
            if (pathFromDialog is not null)
            {
                this._encoder = EncoderFactory.CreateEncoder(this);

                string filePath = FileManager.WriteKeyAndIVToFile(this._encoder, pathFromDialog);
                MessageBox.Show($"Your key and IV have been successfully saved at {filePath}", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EncryptOrDecryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EncryptOrDecryptTextButton.Text = $"{(EncryptRadioButton.Checked ? "Encrypt" : "Decrypt")} File";
        }
    }
}
