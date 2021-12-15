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
            this.GetPathToFileForEncryptButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DownloadKeyAndIVDataFromUserPathButton = new System.Windows.Forms.Button();
            this.SaveKeyAndIVDataOnUserPathButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EncryptOrDecryptTextFromFileButton = new System.Windows.Forms.Button();
            this.CreateNewEncryptDataOnUserPathButton = new System.Windows.Forms.Button();
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
            this.PathInputTextBox.ReadOnly = true;
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
            // GetPathToFileForEncryptButton
            // 
            this.GetPathToFileForEncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetPathToFileForEncryptButton.FlatAppearance.BorderSize = 2;
            this.GetPathToFileForEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetPathToFileForEncryptButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetPathToFileForEncryptButton.Location = new System.Drawing.Point(619, 39);
            this.GetPathToFileForEncryptButton.Name = "GetPathToFileForEncryptButton";
            this.GetPathToFileForEncryptButton.Size = new System.Drawing.Size(41, 25);
            this.GetPathToFileForEncryptButton.TabIndex = 23;
            this.GetPathToFileForEncryptButton.Text = "...";
            this.GetPathToFileForEncryptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetPathToFileForEncryptButton.UseVisualStyleBackColor = true;
            this.GetPathToFileForEncryptButton.Click += new System.EventHandler(this.GetPathToFileForEncryptButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.ReadOnlyChecked = true;
            // 
            // DownloadKeyAndIVDataFromUserPathButton
            // 
            this.DownloadKeyAndIVDataFromUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadKeyAndIVDataFromUserPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadKeyAndIVDataFromUserPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DownloadKeyAndIVDataFromUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadKeyAndIVDataFromUserPathButton.Location = new System.Drawing.Point(12, 276);
            this.DownloadKeyAndIVDataFromUserPathButton.Name = "DownloadKeyAndIVDataFromUserPathButton";
            this.DownloadKeyAndIVDataFromUserPathButton.Size = new System.Drawing.Size(772, 28);
            this.DownloadKeyAndIVDataFromUserPathButton.TabIndex = 17;
            this.DownloadKeyAndIVDataFromUserPathButton.Text = "Download existing Key and IV";
            this.DownloadKeyAndIVDataFromUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadKeyAndIVDataFromUserPathButton.UseVisualStyleBackColor = true;
            this.DownloadKeyAndIVDataFromUserPathButton.Click += new System.EventHandler(this.DownloadKeyAndIVDataFromUserPathButton_Click);
            // 
            // SaveKeyAndIVDataOnUserPathButton
            // 
            this.SaveKeyAndIVDataOnUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveKeyAndIVDataOnUserPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveKeyAndIVDataOnUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVDataOnUserPathButton.Location = new System.Drawing.Point(12, 242);
            this.SaveKeyAndIVDataOnUserPathButton.Name = "SaveKeyAndIVDataOnUserPathButton";
            this.SaveKeyAndIVDataOnUserPathButton.Size = new System.Drawing.Size(772, 28);
            this.SaveKeyAndIVDataOnUserPathButton.TabIndex = 18;
            this.SaveKeyAndIVDataOnUserPathButton.Text = "Save Current Key and IV";
            this.SaveKeyAndIVDataOnUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVDataOnUserPathButton.UseVisualStyleBackColor = true;
            this.SaveKeyAndIVDataOnUserPathButton.Click += new System.EventHandler(this.SaveKeyAndIVDataOnUserPathButton_Click);
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
            // CreateNewEncryptDataOnUserPathButton
            // 
            this.CreateNewEncryptDataOnUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewEncryptDataOnUserPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewEncryptDataOnUserPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateNewEncryptDataOnUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewEncryptDataOnUserPathButton.Location = new System.Drawing.Point(12, 310);
            this.CreateNewEncryptDataOnUserPathButton.Name = "CreateNewEncryptDataOnUserPathButton";
            this.CreateNewEncryptDataOnUserPathButton.Size = new System.Drawing.Size(772, 28);
            this.CreateNewEncryptDataOnUserPathButton.TabIndex = 20;
            this.CreateNewEncryptDataOnUserPathButton.Text = "Create new Key and IV";
            this.CreateNewEncryptDataOnUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewEncryptDataOnUserPathButton.UseVisualStyleBackColor = true;
            this.CreateNewEncryptDataOnUserPathButton.Click += new System.EventHandler(this.CreateNewEncryptDataOnUserPathButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 345);
            this.Controls.Add(this.CreateNewEncryptDataOnUserPathButton);
            this.Controls.Add(this.EncryptOrDecryptTextFromFileButton);
            this.Controls.Add(this.SaveKeyAndIVDataOnUserPathButton);
            this.Controls.Add(this.DownloadKeyAndIVDataFromUserPathButton);
            this.Controls.Add(this.GetPathToFileForEncryptButton);
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
        private System.Windows.Forms.Button GetPathToFileForEncryptButton;
        private System.Windows.Forms.Button DownloadKeyAndIVDataFromUserPathButton;
        private System.Windows.Forms.Button SaveKeyAndIVDataOnUserPathButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button EncryptOrDecryptTextFromFileButton;
        private System.Windows.Forms.Button CreateNewEncryptDataOnUserPathButton;
    }
}

