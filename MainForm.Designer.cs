namespace SymmetricCryptography
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.PathInputTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedOrDecryptedButton = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.RadioButton();
            this.Decrypt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveKeyAndIVData = new System.Windows.Forms.Button();
            this.LoadKeyAndIVData = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.EncryptOrDecryptGroupBox = new System.Windows.Forms.GroupBox();
            this.AlgorithmChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.AES = new System.Windows.Forms.RadioButton();
            this.Rijndael = new System.Windows.Forms.RadioButton();
            this.ChoiceOfPathButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadKeyAndIVViaOFDButton = new System.Windows.Forms.Button();
            this.SaveKeyAndIVInUserFolder = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EncryptAtChoicePathButton = new System.Windows.Forms.Button();
            this.UpdateDataOnUserPathButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptOrDecryptGroupBox.SuspendLayout();
            this.AlgorithmChoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите путь к файлу, содержащий текст для шифровки/дешифровки:\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Шифрованный/Дешифрованный текст:";
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
            this.EncryptedTextBox.Size = new System.Drawing.Size(692, 116);
            this.EncryptedTextBox.TabIndex = 3;
            // 
            // PathInputTextBox
            // 
            this.PathInputTextBox.Location = new System.Drawing.Point(12, 39);
            this.PathInputTextBox.Multiline = true;
            this.PathInputTextBox.Name = "PathInputTextBox";
            this.PathInputTextBox.Size = new System.Drawing.Size(648, 25);
            this.PathInputTextBox.TabIndex = 23;
            // 
            // EncryptedOrDecryptedButton
            // 
            this.EncryptedOrDecryptedButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EncryptedOrDecryptedButton.Font = new System.Drawing.Font("Goudy Old Style", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptedOrDecryptedButton.Location = new System.Drawing.Point(12, 208);
            this.EncryptedOrDecryptedButton.Name = "EncryptedOrDecryptedButton";
            this.EncryptedOrDecryptedButton.Size = new System.Drawing.Size(813, 28);
            this.EncryptedOrDecryptedButton.TabIndex = 7;
            this.EncryptedOrDecryptedButton.Text = "Шифровать/Дешифровать";
            this.EncryptedOrDecryptedButton.UseVisualStyleBackColor = true;
            this.EncryptedOrDecryptedButton.Click += new System.EventHandler(this.EncryptedOrDecryptedButton_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt.Location = new System.Drawing.Point(6, 22);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(137, 23);
            this.Encrypt.TabIndex = 8;
            this.Encrypt.TabStop = true;
            this.Encrypt.Text = "Шифрование";
            this.Encrypt.UseVisualStyleBackColor = true;
            // 
            // Decrypt
            // 
            this.Decrypt.AutoSize = true;
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.Location = new System.Drawing.Point(6, 48);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(156, 23);
            this.Decrypt.TabIndex = 9;
            this.Decrypt.TabStop = true;
            this.Decrypt.Text = "Дешифрование";
            this.Decrypt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(693, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Developed by Danil Rudin from CBT\r\n";
            // 
            // SaveKeyAndIVData
            // 
            this.SaveKeyAndIVData.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveKeyAndIVData.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveKeyAndIVData.Location = new System.Drawing.Point(12, 242);
            this.SaveKeyAndIVData.Name = "SaveKeyAndIVData";
            this.SaveKeyAndIVData.Size = new System.Drawing.Size(813, 28);
            this.SaveKeyAndIVData.TabIndex = 11;
            this.SaveKeyAndIVData.Text = "Сохранить текущие Key и IV";
            this.SaveKeyAndIVData.UseVisualStyleBackColor = true;
            this.SaveKeyAndIVData.Click += new System.EventHandler(this.SaveKeyAndIVData_Click);
            // 
            // LoadKeyAndIVData
            // 
            this.LoadKeyAndIVData.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadKeyAndIVData.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadKeyAndIVData.Location = new System.Drawing.Point(12, 276);
            this.LoadKeyAndIVData.Name = "LoadKeyAndIVData";
            this.LoadKeyAndIVData.Size = new System.Drawing.Size(813, 28);
            this.LoadKeyAndIVData.TabIndex = 12;
            this.LoadKeyAndIVData.Text = "Загрузить существующие Key и IV";
            this.LoadKeyAndIVData.UseVisualStyleBackColor = true;
            this.LoadKeyAndIVData.Click += new System.EventHandler(this.LoadKeyAndIVData_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpdateData.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateData.Location = new System.Drawing.Point(12, 310);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(813, 28);
            this.UpdateData.TabIndex = 13;
            this.UpdateData.Text = "Создать новые Key и IV";
            this.UpdateData.UseVisualStyleBackColor = true;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // EncryptOrDecryptGroupBox
            // 
            this.EncryptOrDecryptGroupBox.Controls.Add(this.Encrypt);
            this.EncryptOrDecryptGroupBox.Controls.Add(this.Decrypt);
            this.EncryptOrDecryptGroupBox.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptOrDecryptGroupBox.Location = new System.Drawing.Point(707, 125);
            this.EncryptOrDecryptGroupBox.Name = "EncryptOrDecryptGroupBox";
            this.EncryptOrDecryptGroupBox.Size = new System.Drawing.Size(165, 77);
            this.EncryptOrDecryptGroupBox.TabIndex = 14;
            this.EncryptOrDecryptGroupBox.TabStop = false;
            this.EncryptOrDecryptGroupBox.Text = "Режим работы";
            this.EncryptOrDecryptGroupBox.Enter += new System.EventHandler(this.EncryptOrDecryptGroupBox_Enter);
            // 
            // AlgorithmChoiceGroupBox
            // 
            this.AlgorithmChoiceGroupBox.Controls.Add(this.AES);
            this.AlgorithmChoiceGroupBox.Controls.Add(this.Rijndael);
            this.AlgorithmChoiceGroupBox.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlgorithmChoiceGroupBox.Location = new System.Drawing.Point(707, 37);
            this.AlgorithmChoiceGroupBox.Name = "AlgorithmChoiceGroupBox";
            this.AlgorithmChoiceGroupBox.Size = new System.Drawing.Size(165, 82);
            this.AlgorithmChoiceGroupBox.TabIndex = 15;
            this.AlgorithmChoiceGroupBox.TabStop = false;
            this.AlgorithmChoiceGroupBox.Text = "Алгоритм";
            this.AlgorithmChoiceGroupBox.Enter += new System.EventHandler(this.AlgorithmChoiceGroupBox_Enter);
            // 
            // AES
            // 
            this.AES.AutoSize = true;
            this.AES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AES.Location = new System.Drawing.Point(6, 23);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(60, 23);
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
            this.Rijndael.Size = new System.Drawing.Size(89, 23);
            this.Rijndael.TabIndex = 16;
            this.Rijndael.TabStop = true;
            this.Rijndael.Text = "Rijndael";
            this.Rijndael.UseVisualStyleBackColor = true;
            // 
            // ChoiceOfPathButton
            // 
            this.ChoiceOfPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoiceOfPathButton.FlatAppearance.BorderSize = 2;
            this.ChoiceOfPathButton.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChoiceOfPathButton.Location = new System.Drawing.Point(663, 38);
            this.ChoiceOfPathButton.Name = "ChoiceOfPathButton";
            this.ChoiceOfPathButton.Size = new System.Drawing.Size(41, 27);
            this.ChoiceOfPathButton.TabIndex = 16;
            this.ChoiceOfPathButton.Text = "...";
            this.ChoiceOfPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChoiceOfPathButton.UseVisualStyleBackColor = true;
            this.ChoiceOfPathButton.Click += new System.EventHandler(this.ChoiceOfPathButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.ReadOnlyChecked = true;
            // 
            // LoadKeyAndIVViaOFDButton
            // 
            this.LoadKeyAndIVViaOFDButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadKeyAndIVViaOFDButton.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadKeyAndIVViaOFDButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadKeyAndIVViaOFDButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadKeyAndIVViaOFDButton.Location = new System.Drawing.Point(831, 276);
            this.LoadKeyAndIVViaOFDButton.Name = "LoadKeyAndIVViaOFDButton";
            this.LoadKeyAndIVViaOFDButton.Size = new System.Drawing.Size(41, 28);
            this.LoadKeyAndIVViaOFDButton.TabIndex = 17;
            this.LoadKeyAndIVViaOFDButton.Text = "...";
            this.LoadKeyAndIVViaOFDButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadKeyAndIVViaOFDButton.UseVisualStyleBackColor = true;
            this.LoadKeyAndIVViaOFDButton.Click += new System.EventHandler(this.LoadKeyAndIVViaOFDButton_Click);
            // 
            // SaveKeyAndIVInUserFolder
            // 
            this.SaveKeyAndIVInUserFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveKeyAndIVInUserFolder.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveKeyAndIVInUserFolder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVInUserFolder.Location = new System.Drawing.Point(831, 242);
            this.SaveKeyAndIVInUserFolder.Name = "SaveKeyAndIVInUserFolder";
            this.SaveKeyAndIVInUserFolder.Size = new System.Drawing.Size(41, 28);
            this.SaveKeyAndIVInUserFolder.TabIndex = 18;
            this.SaveKeyAndIVInUserFolder.Text = "...";
            this.SaveKeyAndIVInUserFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveKeyAndIVInUserFolder.UseVisualStyleBackColor = true;
            this.SaveKeyAndIVInUserFolder.Click += new System.EventHandler(this.SaveKeyAndIVInUserFolder_Click);
            // 
            // EncryptAtChoicePathButton
            // 
            this.EncryptAtChoicePathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptAtChoicePathButton.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptAtChoicePathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EncryptAtChoicePathButton.Location = new System.Drawing.Point(831, 208);
            this.EncryptAtChoicePathButton.Name = "EncryptAtChoicePathButton";
            this.EncryptAtChoicePathButton.Size = new System.Drawing.Size(41, 28);
            this.EncryptAtChoicePathButton.TabIndex = 19;
            this.EncryptAtChoicePathButton.Text = "...";
            this.EncryptAtChoicePathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EncryptAtChoicePathButton.UseVisualStyleBackColor = true;
            this.EncryptAtChoicePathButton.Click += new System.EventHandler(this.EncryptAtChoicePathButton_Click);
            // 
            // UpdateDataOnUserPathButton
            // 
            this.UpdateDataOnUserPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateDataOnUserPathButton.Font = new System.Drawing.Font("Goudy Old Style", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDataOnUserPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateDataOnUserPathButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateDataOnUserPathButton.Location = new System.Drawing.Point(831, 310);
            this.UpdateDataOnUserPathButton.Name = "UpdateDataOnUserPathButton";
            this.UpdateDataOnUserPathButton.Size = new System.Drawing.Size(41, 28);
            this.UpdateDataOnUserPathButton.TabIndex = 20;
            this.UpdateDataOnUserPathButton.Text = "...";
            this.UpdateDataOnUserPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateDataOnUserPathButton.UseVisualStyleBackColor = true;
            this.UpdateDataOnUserPathButton.Click += new System.EventHandler(this.UpdateDataOnUserPathButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "v 3.4.1 Final";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateDataOnUserPathButton);
            this.Controls.Add(this.EncryptAtChoicePathButton);
            this.Controls.Add(this.SaveKeyAndIVInUserFolder);
            this.Controls.Add(this.LoadKeyAndIVViaOFDButton);
            this.Controls.Add(this.ChoiceOfPathButton);
            this.Controls.Add(this.AlgorithmChoiceGroupBox);
            this.Controls.Add(this.EncryptOrDecryptGroupBox);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.LoadKeyAndIVData);
            this.Controls.Add(this.SaveKeyAndIVData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncryptedOrDecryptedButton);
            this.Controls.Add(this.PathInputTextBox);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SymmetricCryptography";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EncryptOrDecryptGroupBox.ResumeLayout(false);
            this.EncryptOrDecryptGroupBox.PerformLayout();
            this.AlgorithmChoiceGroupBox.ResumeLayout(false);
            this.AlgorithmChoiceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.TextBox PathInputTextBox;
        private System.Windows.Forms.Button EncryptedOrDecryptedButton;
        private System.Windows.Forms.RadioButton Encrypt;
        private System.Windows.Forms.RadioButton Decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveKeyAndIVData;
        private System.Windows.Forms.Button LoadKeyAndIVData;
        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.GroupBox EncryptOrDecryptGroupBox;
        private System.Windows.Forms.GroupBox AlgorithmChoiceGroupBox;
        private System.Windows.Forms.RadioButton AES;
        private System.Windows.Forms.RadioButton Rijndael;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ChoiceOfPathButton;
        private System.Windows.Forms.Button LoadKeyAndIVViaOFDButton;
        private System.Windows.Forms.Button SaveKeyAndIVInUserFolder;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button EncryptAtChoicePathButton;
        private System.Windows.Forms.Button UpdateDataOnUserPathButton;
        private System.Windows.Forms.Label label5;
    }
}

