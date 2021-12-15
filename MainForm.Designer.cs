namespace SymmetryEncoder
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputPathTextLabel = new System.Windows.Forms.Label();
            this.EncryptDecryptTextLabel = new System.Windows.Forms.Label();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.PathInputTextBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.RadioButton();
            this.Decrypt = new System.Windows.Forms.RadioButton();
            this.EncryptOrDecryptGroupBox = new System.Windows.Forms.GroupBox();
            this.AlgorithmChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.AES = new System.Windows.Forms.RadioButton();
            this.Rijndael = new System.Windows.Forms.RadioButton();
            this.ChoiceOfPathToFileForEncryptButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DownloadKeyAndIVDataFromUserFolderButton = new System.Windows.Forms.Button();
            this.SaveKeyAndIVDataOnUserFolderButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EncryptOrDecryptTextFromFileButton = new System.Windows.Forms.Button();
            this.CreateNewEncryptDataOnUserFolderButton = new System.Windows.Forms.Button();
            this.EncryptOrDecryptGroupBox.SuspendLayout();
            this.AlgorithmChoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPathTextLabel
            // 
            this.InputPathTextLabel.AutoSize = true;
            this.InputPathTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPathTextLabel.Location = new System.Drawing.Point(12, 9);
            this.InputPathTextLabel.Name = "InputPathTextLabel";
            this.InputPathTextLabel.Size = new System.Drawing.Size(485, 20);
            this.InputPathTextLabel.TabIndex = 1;
            this.InputPathTextLabel.Text = "Enter the file path containing the text to encrypt/decrypt:";
            // 
            // EncryptDecryptTextLabel
            // 
            this.EncryptDecryptTextLabel.AutoSize = true;
            this.EncryptDecryptTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptDecryptTextLabel.Location = new System.Drawing.Point(12, 64);
            this.EncryptDecryptTextLabel.Name = "EncryptDecryptTextLabel";
            this.EncryptDecryptTextLabel.Size = new System.Drawing.Size(233, 20);
            this.EncryptDecryptTextLabel.TabIndex = 2;
            this.EncryptDecryptTextLabel.Text = "Encrypted/Decrypted Text:";
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.CausesValidation = false;
            this.EncryptedTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EncryptedTextBox.Location = new System.Drawing.Point(12, 86);
            this.EncryptedTextBox.Multiline = true;
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.ReadOnly = true;
            this.EncryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncryptedTextBox.Size = new System.Drawing.Size(648, 116);
            this.EncryptedTextBox.TabIndex = 3;
            // 
            // PathInputTextBox
            // 
            this.PathInputTextBox.Location = new System.Drawing.Point(12, 39);
            this.PathInputTextBox.Multiline = true;
            this.PathInputTextBox.Name = "PathInputTextBox";
            this.PathInputTextBox.Size = new System.Drawing.Size(601, 25);
            this.PathInputTextBox.TabIndex = 23;
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt.Location = new System.Drawing.Point(6, 22);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(91, 24);
            this.Encrypt.TabIndex = 8;
            this.Encrypt.TabStop = true;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            // 
            // Decrypt
            // 
            this.Decrypt.AutoSize = true;
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.Location = new System.Drawing.Point(6, 48);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(93, 24);
            this.Decrypt.TabIndex = 9;
            this.Decrypt.TabStop = true;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            // 
            // EncryptOrDecryptGroupBox
            // 
            this.EncryptOrDecryptGroupBox.Controls.Add(this.Encrypt);
            this.EncryptOrDecryptGroupBox.Controls.Add(this.Decrypt);
            this.EncryptOrDecryptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptOrDecryptGroupBox.Location = new System.Drawing.Point(666, 125);
            this.EncryptOrDecryptGroupBox.Name = "EncryptOrDecryptGroupBox";
            this.EncryptOrDecryptGroupBox.Size = new System.Drawing.Size(118, 77);
            this.EncryptOrDecryptGroupBox.TabIndex = 14;
            this.EncryptOrDecryptGroupBox.TabStop = false;
            this.EncryptOrDecryptGroupBox.Text = "Mode";
            // 
            // AlgorithmChoiceGroupBox
            // 
            this.AlgorithmChoiceGroupBox.Controls.Add(this.AES);
            this.AlgorithmChoiceGroupBox.Controls.Add(this.Rijndael);
            this.AlgorithmChoiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlgorithmChoiceGroupBox.Location = new System.Drawing.Point(666, 37);
            this.AlgorithmChoiceGroupBox.Name = "AlgorithmChoiceGroupBox";
            this.AlgorithmChoiceGroupBox.Size = new System.Drawing.Size(118, 82);
            this.AlgorithmChoiceGroupBox.TabIndex = 15;
            this.AlgorithmChoiceGroupBox.TabStop = false;
            this.AlgorithmChoiceGroupBox.Text = "Algorithm";
            this.AlgorithmChoiceGroupBox.Enter += new System.EventHandler(this.AlgorithmChoiceGroupBox_Click);
            // 
            // AES
            // 
            this.AES.AutoSize = true;
            this.AES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AES.Location = new System.Drawing.Point(6, 23);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(63, 24);
            this.AES.TabIndex = 10;
            this.AES.TabStop = true;
            this.AES.Text = "AES";
            this.AES.UseVisualStyleBackColor = true;
            // 
            // Rijndael
            // 
            this.Rijndael.AutoSize = true;
            this.Rijndael.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rijndael.Location = new System.Drawing.Point(6, 49);
            this.Rijndael.Name = "Rijndael";
            this.Rijndael.Size = new System.Drawing.Size(95, 24);
            this.Rijndael.TabIndex = 16;
            this.Rijndael.TabStop = true;
            this.Rijndael.Text = "Rijndael";
            this.Rijndael.UseVisualStyleBackColor = true;
            // 
            // ChoiceOfPathToFileForEncryptButton
            // 
            this.ChoiceOfPathToFileForEncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoiceOfPathToFileForEncryptButton.FlatAppearance.BorderSize = 2;
            this.ChoiceOfPathToFileForEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfPathToFileForEncryptButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChoiceOfPathToFileForEncryptButton.Location = new System.Drawing.Point(619, 39);
            this.ChoiceOfPathToFileForEncryptButton.Name = "ChoiceOfPathToFileForEncryptButton";
            this.ChoiceOfPathToFileForEncryptButton.Size = new System.Drawing.Size(41, 25);
            this.ChoiceOfPathToFileForEncryptButton.TabIndex = 23;
            this.ChoiceOfPathToFileForEncryptButton.Text = "...";
            this.ChoiceOfPathToFileForEncryptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChoiceOfPathToFileForEncryptButton.UseVisualStyleBackColor = true;
            this.ChoiceOfPathToFileForEncryptButton.Click += new System.EventHandler(this.ChoiceOfPathToFileForEncryptButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.ReadOnlyChecked = true;
            // 
            // DownloadKeyAndIVDataFromUserFolderButton
            // 
            this.DownloadKeyAndIVDataFromUserFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadKeyAndIVDataFromUserFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadKeyAndIVDataFromUserFolderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DownloadKeyAndIVDataFromUserFolderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadKeyAndIVDataFromUserFolderButton.Location = new System.Drawing.Point(12, 276);
            this.DownloadKeyAndIVDataFromUserFolderButton.Name = "DownloadKeyAndIVDataFromUserFolderButton";
            this.DownloadKeyAndIVDataFromUserFolderButton.Size = new System.Drawing.Size(772, 28);
            this.DownloadKeyAndIVDataFromUserFolderButton.TabIndex = 17;
            this.DownloadKeyAndIVDataFromUserFolderButton.Text = "Download existing Key and IV";
            this.DownloadKeyAndIVDataFromUserFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadKeyAndIVDataFromUserFolderButton.UseVisualStyleBackColor = true;
            this.DownloadKeyAndIVDataFromUserFolderButton.Click += new System.EventHandler(this.DownloadKeyAndIVDataFromUserFolderButton_Click);
            // 
            // SaveKeyAndIVDataOnUserFolderButton
            // 
            this.SaveKeyAndIVDataOnUserFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveKeyAndIVDataOnUserFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveKeyAndIVDataOnUserFolderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVDataOnUserFolderButton.Location = new System.Drawing.Point(12, 242);
            this.SaveKeyAndIVDataOnUserFolderButton.Name = "SaveKeyAndIVDataOnUserFolderButton";
            this.SaveKeyAndIVDataOnUserFolderButton.Size = new System.Drawing.Size(772, 28);
            this.SaveKeyAndIVDataOnUserFolderButton.TabIndex = 18;
            this.SaveKeyAndIVDataOnUserFolderButton.Text = "Save Current Key and IV";
            this.SaveKeyAndIVDataOnUserFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVDataOnUserFolderButton.UseVisualStyleBackColor = true;
            this.SaveKeyAndIVDataOnUserFolderButton.Click += new System.EventHandler(this.SaveKeyAndIVDataOnUserFolderButton_Click);
            // 
            // EncryptOrDecryptTextFromFileButton
            // 
            this.EncryptOrDecryptTextFromFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptOrDecryptTextFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptOrDecryptTextFromFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EncryptOrDecryptTextFromFileButton.Location = new System.Drawing.Point(12, 208);
            this.EncryptOrDecryptTextFromFileButton.Name = "EncryptOrDecryptTextFromFileButton";
            this.EncryptOrDecryptTextFromFileButton.Size = new System.Drawing.Size(772, 28);
            this.EncryptOrDecryptTextFromFileButton.TabIndex = 19;
            this.EncryptOrDecryptTextFromFileButton.Text = "Encrypt/Decrypt";
            this.EncryptOrDecryptTextFromFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EncryptOrDecryptTextFromFileButton.UseVisualStyleBackColor = true;
            this.EncryptOrDecryptTextFromFileButton.Click += new System.EventHandler(this.EncryptOrDecryptTextFromFileButton_Click);
            // 
            // CreateNewEncryptDataOnUserFolderButton
            // 
            this.CreateNewEncryptDataOnUserFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewEncryptDataOnUserFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewEncryptDataOnUserFolderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateNewEncryptDataOnUserFolderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewEncryptDataOnUserFolderButton.Location = new System.Drawing.Point(12, 310);
            this.CreateNewEncryptDataOnUserFolderButton.Name = "CreateNewEncryptDataOnUserFolderButton";
            this.CreateNewEncryptDataOnUserFolderButton.Size = new System.Drawing.Size(772, 28);
            this.CreateNewEncryptDataOnUserFolderButton.TabIndex = 20;
            this.CreateNewEncryptDataOnUserFolderButton.Text = "Create new Key and IV";
            this.CreateNewEncryptDataOnUserFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewEncryptDataOnUserFolderButton.UseVisualStyleBackColor = true;
            this.CreateNewEncryptDataOnUserFolderButton.Click += new System.EventHandler(this.CreateNewEncryptDataOnUserFolderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 345);
            this.Controls.Add(this.CreateNewEncryptDataOnUserFolderButton);
            this.Controls.Add(this.EncryptOrDecryptTextFromFileButton);
            this.Controls.Add(this.SaveKeyAndIVDataOnUserFolderButton);
            this.Controls.Add(this.DownloadKeyAndIVDataFromUserFolderButton);
            this.Controls.Add(this.ChoiceOfPathToFileForEncryptButton);
            this.Controls.Add(this.AlgorithmChoiceGroupBox);
            this.Controls.Add(this.EncryptOrDecryptGroupBox);
            this.Controls.Add(this.PathInputTextBox);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.EncryptDecryptTextLabel);
            this.Controls.Add(this.InputPathTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symmetry encoder";
            this.EncryptOrDecryptGroupBox.ResumeLayout(false);
            this.EncryptOrDecryptGroupBox.PerformLayout();
            this.AlgorithmChoiceGroupBox.ResumeLayout(false);
            this.AlgorithmChoiceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InputPathTextLabel;
        private System.Windows.Forms.Label EncryptDecryptTextLabel;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.TextBox PathInputTextBox;
        private System.Windows.Forms.RadioButton Encrypt;
        private System.Windows.Forms.RadioButton Decrypt;
        private System.Windows.Forms.GroupBox EncryptOrDecryptGroupBox;
        private System.Windows.Forms.GroupBox AlgorithmChoiceGroupBox;
        private System.Windows.Forms.RadioButton AES;
        private System.Windows.Forms.RadioButton Rijndael;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ChoiceOfPathToFileForEncryptButton;
        private System.Windows.Forms.Button DownloadKeyAndIVDataFromUserFolderButton;
        private System.Windows.Forms.Button SaveKeyAndIVDataOnUserFolderButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button EncryptOrDecryptTextFromFileButton;
        private System.Windows.Forms.Button CreateNewEncryptDataOnUserFolderButton;
    }
}

