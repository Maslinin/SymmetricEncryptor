using System;
using System.IO;
using System.Windows.Forms;
using SymmetryEncoder.Encoders;
using SymmetryEncoder.IOManager;

namespace SymmetryEncoder
{
    sealed partial class MainForm : Form
    {
        private ISymmetry Symmetry { get; set; }

        public MainForm()
        {
            InitializeComponent();

            AES.Checked = true;
            Encrypt.Checked = true;

            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            SaveFileDialog.Filter = "Text File|*.txt";

            Encrypt.CheckedChanged += EncryptOrDecryptRadioButton_CheckedChanged;
            Decrypt.CheckedChanged += EncryptOrDecryptRadioButton_CheckedChanged;

            InputPathTextLabel.Text = $"Enter the file path containing the text to {(Encrypt.Checked ? "encrypt" : "decrypt")}:";
            EncryptDecryptTextLabel.Text = $"{(Encrypt.Checked ? "Encrypted" : "Decrypted")} text:";
            EncryptOrDecryptTextFromFileButton.Text = Encrypt.Checked ? "Encrypt" : "Decrypt";
        }

        private void GetPathToFileForEncryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = "Select Text File";
            OpenFileDialog.Filter = Encrypt.Checked ? "Text File|*.txt|HTML Document|*.html|eBook|*.fb2;*.epub" : "Text File|*.txt";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathInputTextBox.Text = OpenFileDialog.FileName;
            }
            OpenFileDialog.Dispose();
        }

        private void EncryptOrDecryptTextFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(PathInputTextBox.Text)) 
                    throw new FileNotFoundException("The file on the path you specified does not exist!");

                if (AES.Checked && Symmetry as AESEncoder == null)
                    Symmetry = new AESEncoder();
                else if(Rijndael.Checked && Symmetry as RijndaelEncoder == null)
                    Symmetry = new RijndaelEncoder();

                string fileName = Symmetry is AESEncoder ? "AESEncryptionData.txt" : "RijndaelEncryptionData.txt";
                string filePath = null;
                if (Encrypt.Checked) //encrypt text
                {
                    SaveFileDialog.Title = "Select a file to save encrypted text";
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Encryption:
                        var encryptedBytes = Symmetry.EncryptStringIntoBytes(File.ReadAllText(PathInputTextBox.Text));

                        File.WriteAllBytes(SaveFileDialog.FileName, encryptedBytes);
                        string dataFilePath = string.Concat(SaveFileDialog.FileName, '.', fileName);
                        EncodersIOManager.WriteKeyAndIVInFile(Symmetry, dataFilePath);
                        MessageBox.Show($"Encrypted text was saved to file at {SaveFileDialog.FileName};" +
                            $"\ndata for decrypt was saved to file at {dataFilePath}",
                            "Encryption Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        EncryptedTextBox.Text = System.Text.Encoding.Default.GetString(encryptedBytes);
                    }
                    SaveFileDialog.Dispose();
                }
                else //decrypt text
                {
                    SaveFileDialog.Title = "Select a file to save decrypted text";
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Decryption:
                        EncryptedTextBox.Text = Symmetry.DecryptStringFromBytes(File.ReadAllBytes(PathInputTextBox.Text));

                        File.WriteAllText(SaveFileDialog.FileName, EncryptedTextBox.Text);
                        MessageBox.Show($"Decrypted text was saved to file at {filePath}",
                            "Decryption completed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    SaveFileDialog.Dispose();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,
                    Ex.GetType().Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "log.txt"),
                    Ex.ToString());
            }
        }

        private void SaveKeyAndIVDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Symmetry == null)
                    throw new NullReferenceException("Current Key and IV are not installed in the program!");
                if ((AES.Checked && Symmetry is RijndaelEncoder) || (Rijndael.Checked && Symmetry is AESEncoder))
                    throw new FormatException("Key and IV cannot be saved because they belong to another encryption algorithm!");
                
                SaveFileDialog.Title = "Save Key and IV";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = EncodersIOManager.WriteKeyAndIVInFile(Symmetry, SaveFileDialog.FileName);
                    MessageBox.Show($"Your Key and IV were saved successfully at {filePath}",
                        "Data Saved",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                SaveFileDialog.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,
                    Ex.GetType().Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "log.txt"),
                    Ex.ToString());
            }
        }

        private void DownloadKeyAndIVDataFromUserPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog.Filter = "Text file|*.txt";
                OpenFileDialog.Title = "Select a file with Key and IV";

                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (AES.Checked)
                        Symmetry = new AESEncoder();
                    else
                        Symmetry = new RijndaelEncoder();

                    EncodersIOManager.ReadKeyAndIVFromFile(Symmetry, OpenFileDialog.FileName);
                    MessageBox.Show("Your Key and IV were successfully downloaded",
                        "Data Loaded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                OpenFileDialog.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,
                    Ex.GetType().Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "log.txt"),
                    Ex.ToString());
            }
        }

        private void CreateNewEncryptDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Title = "Save New Key and IV";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                EncryptedTextBox.Clear();

                if (AES.Checked == true)
                    Symmetry = new AESEncoder();
                else 
                    Symmetry = new RijndaelEncoder();

                string filePath = EncodersIOManager.WriteKeyAndIVInFile(Symmetry, SaveFileDialog.FileName);
                MessageBox.Show($"Your Key and IV were saved successfully at {filePath}",
                    "Data Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            SaveFileDialog.Dispose();
        }

        private void EncryptOrDecryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EncryptedTextBox.Clear();
            InputPathTextLabel.Text = $"Enter the file path containing the text to {(Encrypt.Checked ? "encrypt" : "decrypt")}:";
            EncryptDecryptTextLabel.Text = $"{(Encrypt.Checked ? "Encrypted" : "Decrypted")} text:";
            EncryptOrDecryptTextFromFileButton.Text = Encrypt.Checked ? "Encrypt" : "Decrypt";
        }
        private void AlgorithmChoiceGroupBox_Click(object sender, EventArgs e) => EncryptedTextBox.Clear();
    }
}