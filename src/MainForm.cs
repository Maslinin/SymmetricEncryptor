using System;
using System.IO;
using System.Windows.Forms;
using SymmetryEncrypter.Encrypters;
using SymmetryEncrypter.IOServices;
using SymmetryEncrypter.Exceptions;

namespace SymmetryEncrypter
{
    sealed partial class MainForm : Form
    {
        private IEncrypter _encrypter;
        private readonly FileInteractionDialogService _fileInteractionService;

        public MainForm()
        {
            InitializeComponent();

            EncryptRadioButton.Checked = true;
            AESRadioButton.Checked = true;
            EncryptRadioButton.CheckedChanged += this.EncryptOrDecryptRadioButton_CheckedChanged;
            DecryptRadioButton.CheckedChanged += this.EncryptOrDecryptRadioButton_CheckedChanged;

            this.EncryptOrDecryptRadioButton_CheckedChanged(null, null);

            this._fileInteractionService = new FileInteractionDialogService();
            this._encrypter = EncrypterFactory.CreateEncrypter(this);
        }

        private void EncryptOrDecryptTextFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AESRadioButton.Checked && this._encrypter is not AESEncrypter)
                    this._encrypter = EncrypterFactory.CreateEncrypter(this);
                else if (RC2RadioButton.Checked && this._encrypter is not RC2Encrypter)
                    this._encrypter = EncrypterFactory.CreateEncrypter(this);

                string openPathFromDialog = this._fileInteractionService.OpenFileViaDialog();
                if (openPathFromDialog is null)
                    return;

                string savePathFromDialog = this._fileInteractionService.SaveFileViaDialog();
                if (savePathFromDialog is null)
                    return;

                if (EncryptRadioButton.Checked)
                {
                    var encryptedBytes = this._encrypter.EncryptText(File.ReadAllText(openPathFromDialog));
                    File.WriteAllBytes(savePathFromDialog, encryptedBytes);

                    string dataFilePath = string.Concat(savePathFromDialog, ".EncryptionData");
                    CryptDataIOService.WriteKeyAndIVToFile(this._encrypter, dataFilePath);

                    MessageBox.Show($"The encrypted text was saved to a file at {savePathFromDialog};" +
                        $"\nthe decryption data was saved to a file at {dataFilePath}",
                        "Encryption Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    string decryptText = this._encrypter.DecryptText(File.ReadAllBytes(openPathFromDialog));

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
                if ((AESRadioButton.Checked && this._encrypter is RC2Encrypter) || (RC2RadioButton.Checked && this._encrypter is AESEncrypter))
                    throw new FormatException("The Key and IV cannot be saved as they are intended for a different encryption algorithm!");

                string pathFromDialog = this._fileInteractionService.SaveFileViaDialog();
                if (pathFromDialog is not null)
                {
                    CryptDataIOService.WriteKeyAndIVToFile(this._encrypter, pathFromDialog);
                    MessageBox.Show($"Your key and IV have been successfully saved in {pathFromDialog}", 
                        "Data Saved", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
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
                string pathFromDialog = this._fileInteractionService.OpenFileViaDialog();
                if (pathFromDialog is not null)
                {
                    var enctyptionData = CryptDataIOService.ReadKeyAndIVFromFile(pathFromDialog);

                    this._encrypter = EncrypterFactory.CreateEncrypter(this);
                    this._encrypter.Key = enctyptionData.Item1;
                    this._encrypter.IV = enctyptionData.Item2;

                    MessageBox.Show("Your Key and IV have been successfully uploaded", 
                        "Data Loaded", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplayer.DisplayException(ex);
            }
        }

        private void CreateNewEncryptDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            string pathFromDialog = this._fileInteractionService.SaveFileViaDialog();
            if (pathFromDialog is not null)
            {
                this._encrypter = EncrypterFactory.CreateEncrypter(this);

                CryptDataIOService.WriteKeyAndIVToFile(this._encrypter, pathFromDialog);
                MessageBox.Show($"Your key and IV have been successfully saved at {pathFromDialog}", 
                    "Data Saved", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void EncryptOrDecryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EncryptOrDecryptTextButton.Text = $"{(EncryptRadioButton.Checked ? "Encrypt" : "Decrypt")} File";
        }
    }
}
