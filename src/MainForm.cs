﻿using System;
using System.IO;
using System.Windows.Forms;
using SymmetricEncryptor.Services;
using SymmetricEncryptor.Encryptors;
using SymmetricEncryptor.Exceptions;

namespace SymmetricEncryptor
{
    sealed partial class MainForm : Form
    {
        private IEncryptor _encryptor;
        private readonly FileInteractionDialogService _fileInteractionService;

        public MainForm()
        {
            InitializeComponent();

            AESRadioButton.Checked = true;
            EncryptRadioButton.Checked = true;
            EncryptRadioButton.CheckedChanged += this.EncryptOrDecryptRadioButton_CheckedChanged;
            DecryptRadioButton.CheckedChanged += this.EncryptOrDecryptRadioButton_CheckedChanged;

            this.EncryptOrDecryptRadioButton_CheckedChanged(null, null);

            this._fileInteractionService = new FileInteractionDialogService();
            this._encryptor = EncryptorFactory.CreateEncryptor(this);
        }

        private void EncryptOrDecryptTextFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AESRadioButton.Checked && this._encryptor is not AesEncryptor)
                    this._encryptor = EncryptorFactory.CreateEncryptor(this);
                else if (RC2RadioButton.Checked && this._encryptor is not RC2Encryptor)
                    this._encryptor = EncryptorFactory.CreateEncryptor(this);

                string openPathFromDialog = this._fileInteractionService.OpenFileViaDialog();
                if (openPathFromDialog is null)
                    return;

                string savePathFromDialog = this._fileInteractionService.SaveFileViaDialog();
                if (savePathFromDialog is null)
                    return;

                if (EncryptRadioButton.Checked)
                {
                    var encryptedBytes = this._encryptor.EncryptText(File.ReadAllText(openPathFromDialog));
                    File.WriteAllBytes(savePathFromDialog, encryptedBytes);

                    string dataFilePath = string.Concat(savePathFromDialog, ".EncryptionData");
                    CryptoDataIOService.WriteKeyAndIVToFile(this._encryptor, dataFilePath);

                    MessageBox.Show($"The encrypted text was saved to a file at {savePathFromDialog};" +
                        $"\nthe decryption data was saved to a file at {dataFilePath}",
                        "Encryption Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    string decryptText = this._encryptor.DecryptText(File.ReadAllBytes(openPathFromDialog));

                    File.WriteAllText(savePathFromDialog, decryptText);
                    MessageBox.Show($"Decrypted text was saved to file at {savePathFromDialog}",
                        "Decryption completed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplay.DisplayException(ex);
            }
        }

        private void SaveKeyAndIVDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((AESRadioButton.Checked && this._encryptor is RC2Encryptor) || (RC2RadioButton.Checked && this._encryptor is AesEncryptor))
                    throw new FormatException("The Key and IV cannot be saved as they are intended for a different encryption algorithm!");

                string pathFromDialog = this._fileInteractionService.SaveFileViaDialog();
                if (pathFromDialog is not null)
                {
                    CryptoDataIOService.WriteKeyAndIVToFile(this._encryptor, pathFromDialog);
                    MessageBox.Show($"Your key and IV have been successfully saved in {pathFromDialog}", 
                        "Data Saved", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplay.DisplayException(ex);
            }
        }

        private void DownloadKeyAndIVDataFromUserPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFromDialog = this._fileInteractionService.OpenFileViaDialog();
                if (pathFromDialog is not null)
                {
                    var (Key, IV) = CryptoDataIOService.ReadKeyAndIVFromFile(pathFromDialog);

                    this._encryptor = EncryptorFactory.CreateEncryptor(this);
                    this._encryptor.Key = Key;
                    this._encryptor.IV = IV;

                    MessageBox.Show("Your Key and IV have been successfully uploaded", 
                        "Data Loaded", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionDisplay.DisplayException(ex);
            }
        }

        private void CreateNewEncryptDataOnUserPathButton_Click(object sender, EventArgs e)
        {
            string pathFromDialog = this._fileInteractionService.SaveFileViaDialog();
            if (pathFromDialog is not null)
            {
                this._encryptor = EncryptorFactory.CreateEncryptor(this);

                CryptoDataIOService.WriteKeyAndIVToFile(this._encryptor, pathFromDialog);
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
