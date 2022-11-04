namespace SymmetryEncryptor
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

        internal System.Windows.Forms.RadioButton AESRadioButton;
        internal System.Windows.Forms.RadioButton RC2RadioButton;

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EncryptRadioButton = new System.Windows.Forms.RadioButton();
            this.DecryptRadioButton = new System.Windows.Forms.RadioButton();
            this.EncryptOrDecryptGroupBox = new System.Windows.Forms.GroupBox();
            this.AlgorithmChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.AESRadioButton = new System.Windows.Forms.RadioButton();
            this.RC2RadioButton = new System.Windows.Forms.RadioButton();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DownloadKeyAndIVDataFromUserPathButton = new System.Windows.Forms.Button();
            this.SaveKeyAndIVDataOnUserPathButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EncryptOrDecryptTextButton = new System.Windows.Forms.Button();
            this.CreateNewEncryptDataOnUserPathButton = new System.Windows.Forms.Button();
            this.EncryptOrDecryptGroupBox.SuspendLayout();
            this.AlgorithmChoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptRadioButton
            // 
            this.EncryptRadioButton.AutoSize = true;
            this.EncryptRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptRadioButton.Location = new System.Drawing.Point(7, 25);
            this.EncryptRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EncryptRadioButton.Name = "EncryptRadioButton";
            this.EncryptRadioButton.Size = new System.Drawing.Size(91, 24);
            this.EncryptRadioButton.TabIndex = 8;
            this.EncryptRadioButton.TabStop = true;
            this.EncryptRadioButton.Text = "Encrypt";
            this.EncryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // DecryptRadioButton
            // 
            this.DecryptRadioButton.AutoSize = true;
            this.DecryptRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecryptRadioButton.Location = new System.Drawing.Point(7, 55);
            this.DecryptRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DecryptRadioButton.Name = "DecryptRadioButton";
            this.DecryptRadioButton.Size = new System.Drawing.Size(93, 24);
            this.DecryptRadioButton.TabIndex = 9;
            this.DecryptRadioButton.TabStop = true;
            this.DecryptRadioButton.Text = "Decrypt";
            this.DecryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // EncryptOrDecryptGroupBox
            // 
            this.EncryptOrDecryptGroupBox.Controls.Add(this.EncryptRadioButton);
            this.EncryptOrDecryptGroupBox.Controls.Add(this.DecryptRadioButton);
            this.EncryptOrDecryptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptOrDecryptGroupBox.Location = new System.Drawing.Point(409, 99);
            this.EncryptOrDecryptGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EncryptOrDecryptGroupBox.Name = "EncryptOrDecryptGroupBox";
            this.EncryptOrDecryptGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EncryptOrDecryptGroupBox.Size = new System.Drawing.Size(120, 85);
            this.EncryptOrDecryptGroupBox.TabIndex = 14;
            this.EncryptOrDecryptGroupBox.TabStop = false;
            this.EncryptOrDecryptGroupBox.Text = "Mode";
            // 
            // AlgorithmChoiceGroupBox
            // 
            this.AlgorithmChoiceGroupBox.Controls.Add(this.AESRadioButton);
            this.AlgorithmChoiceGroupBox.Controls.Add(this.RC2RadioButton);
            this.AlgorithmChoiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmChoiceGroupBox.Location = new System.Drawing.Point(409, 8);
            this.AlgorithmChoiceGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AlgorithmChoiceGroupBox.Name = "AlgorithmChoiceGroupBox";
            this.AlgorithmChoiceGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AlgorithmChoiceGroupBox.Size = new System.Drawing.Size(120, 85);
            this.AlgorithmChoiceGroupBox.TabIndex = 15;
            this.AlgorithmChoiceGroupBox.TabStop = false;
            this.AlgorithmChoiceGroupBox.Text = "Algorithm";
            // 
            // AESRadioButton
            // 
            this.AESRadioButton.AutoSize = true;
            this.AESRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AESRadioButton.Location = new System.Drawing.Point(7, 27);
            this.AESRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AESRadioButton.Name = "AESRadioButton";
            this.AESRadioButton.Size = new System.Drawing.Size(63, 24);
            this.AESRadioButton.TabIndex = 10;
            this.AESRadioButton.TabStop = true;
            this.AESRadioButton.Text = "AES";
            this.AESRadioButton.UseVisualStyleBackColor = true;
            // 
            // RC2RadioButton
            // 
            this.RC2RadioButton.AutoSize = true;
            this.RC2RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RC2RadioButton.Location = new System.Drawing.Point(7, 57);
            this.RC2RadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RC2RadioButton.Name = "RC2RadioButton";
            this.RC2RadioButton.Size = new System.Drawing.Size(63, 24);
            this.RC2RadioButton.TabIndex = 16;
            this.RC2RadioButton.TabStop = true;
            this.RC2RadioButton.Text = "RC2";
            this.RC2RadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.ReadOnlyChecked = true;
            // 
            // DownloadKeyAndIVDataFromUserPathButton
            // 
            this.DownloadKeyAndIVDataFromUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadKeyAndIVDataFromUserPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DownloadKeyAndIVDataFromUserPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DownloadKeyAndIVDataFromUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadKeyAndIVDataFromUserPathButton.Location = new System.Drawing.Point(13, 104);
            this.DownloadKeyAndIVDataFromUserPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadKeyAndIVDataFromUserPathButton.Name = "DownloadKeyAndIVDataFromUserPathButton";
            this.DownloadKeyAndIVDataFromUserPathButton.Size = new System.Drawing.Size(387, 32);
            this.DownloadKeyAndIVDataFromUserPathButton.TabIndex = 17;
            this.DownloadKeyAndIVDataFromUserPathButton.Text = "Upload an existing Key and IV";
            this.DownloadKeyAndIVDataFromUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadKeyAndIVDataFromUserPathButton.UseVisualStyleBackColor = true;
            this.DownloadKeyAndIVDataFromUserPathButton.Click += new System.EventHandler(this.DownloadKeyAndIVDataFromUserPathButton_Click);
            // 
            // SaveKeyAndIVDataOnUserPathButton
            // 
            this.SaveKeyAndIVDataOnUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveKeyAndIVDataOnUserPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveKeyAndIVDataOnUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVDataOnUserPathButton.Location = new System.Drawing.Point(13, 57);
            this.SaveKeyAndIVDataOnUserPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveKeyAndIVDataOnUserPathButton.Name = "SaveKeyAndIVDataOnUserPathButton";
            this.SaveKeyAndIVDataOnUserPathButton.Size = new System.Drawing.Size(388, 32);
            this.SaveKeyAndIVDataOnUserPathButton.TabIndex = 18;
            this.SaveKeyAndIVDataOnUserPathButton.Text = "Save the current key and IV";
            this.SaveKeyAndIVDataOnUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVDataOnUserPathButton.UseVisualStyleBackColor = true;
            this.SaveKeyAndIVDataOnUserPathButton.Click += new System.EventHandler(this.SaveKeyAndIVDataOnUserPathButton_Click);
            // 
            // EncryptOrDecryptTextButton
            // 
            this.EncryptOrDecryptTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptOrDecryptTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptOrDecryptTextButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EncryptOrDecryptTextButton.Location = new System.Drawing.Point(13, 12);
            this.EncryptOrDecryptTextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EncryptOrDecryptTextButton.Name = "EncryptOrDecryptTextButton";
            this.EncryptOrDecryptTextButton.Size = new System.Drawing.Size(388, 32);
            this.EncryptOrDecryptTextButton.TabIndex = 19;
            this.EncryptOrDecryptTextButton.Text = "Encrypt/Decrypt File";
            this.EncryptOrDecryptTextButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EncryptOrDecryptTextButton.UseVisualStyleBackColor = true;
            this.EncryptOrDecryptTextButton.Click += new System.EventHandler(this.EncryptOrDecryptTextFromFileButton_Click);
            // 
            // CreateNewEncryptDataOnUserPathButton
            // 
            this.CreateNewEncryptDataOnUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewEncryptDataOnUserPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateNewEncryptDataOnUserPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateNewEncryptDataOnUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewEncryptDataOnUserPathButton.Location = new System.Drawing.Point(13, 151);
            this.CreateNewEncryptDataOnUserPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateNewEncryptDataOnUserPathButton.Name = "CreateNewEncryptDataOnUserPathButton";
            this.CreateNewEncryptDataOnUserPathButton.Size = new System.Drawing.Size(387, 32);
            this.CreateNewEncryptDataOnUserPathButton.TabIndex = 20;
            this.CreateNewEncryptDataOnUserPathButton.Text = "Create a new Key and IV";
            this.CreateNewEncryptDataOnUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewEncryptDataOnUserPathButton.UseVisualStyleBackColor = true;
            this.CreateNewEncryptDataOnUserPathButton.Click += new System.EventHandler(this.CreateNewEncryptDataOnUserPathButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 193);
            this.Controls.Add(this.CreateNewEncryptDataOnUserPathButton);
            this.Controls.Add(this.EncryptOrDecryptTextButton);
            this.Controls.Add(this.SaveKeyAndIVDataOnUserPathButton);
            this.Controls.Add(this.DownloadKeyAndIVDataFromUserPathButton);
            this.Controls.Add(this.AlgorithmChoiceGroupBox);
            this.Controls.Add(this.EncryptOrDecryptGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symmetry Encryptor";
            this.EncryptOrDecryptGroupBox.ResumeLayout(false);
            this.EncryptOrDecryptGroupBox.PerformLayout();
            this.AlgorithmChoiceGroupBox.ResumeLayout(false);
            this.AlgorithmChoiceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton EncryptRadioButton;
        private System.Windows.Forms.RadioButton DecryptRadioButton;
        private System.Windows.Forms.GroupBox EncryptOrDecryptGroupBox;
        private System.Windows.Forms.GroupBox AlgorithmChoiceGroupBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button DownloadKeyAndIVDataFromUserPathButton;
        private System.Windows.Forms.Button SaveKeyAndIVDataOnUserPathButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button EncryptOrDecryptTextButton;
        private System.Windows.Forms.Button CreateNewEncryptDataOnUserPathButton;
    }
}

