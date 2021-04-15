namespace SymmetricCryptography
{
    sealed partial class MainForm : System.Windows.Forms.Form
    {
        //Глобальное поле - ссылка на объект класса SymmetryAbstract:
        private static SymmetryAbstract MySymmetry;
        public MainForm() => InitializeComponent();
        
        //Команды, выполняющиеся при загрузке формы:
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //Что бы нельзя было растягивать форму:
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //Установка параметров для GroupBox:
            AES.Checked = true;
            Encrypt.Checked = true;

            //Какая директория будет отображаться в OpenFileDialog по умолчанию:
            OpenFileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);

            //Определение формата файлов, который можно будет сохранить в SaveFileDialog:
            SaveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            //Какая директория будет отображаться в SaveFileDialog по умолчанию:
            SaveFileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку Шифрования/Дешифрования:
        private void EncryptedOrDecryptedButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Если файла из пути в TextBox не существует:
                if (!System.IO.File.Exists(PathInputTextBox.Text)) throw new System.IO.FileNotFoundException("Файла на указанном Вами пути не существует!");
                //Переменная для записи пути, по которому будет записываться зашифровыванный массив байтов:
                string PathToByteArray = null;

                //Определение алгоритма шифрования:
                //Если выбран AES:
                if (AES.Checked == true)
                {
                    //Если объекта не существует, создаем его:
                    if (MySymmetry as AESClass == null) MySymmetry = new AESClass(PathInputTextBox.Text);
                    //Если объект существует, обновляем поле с текстом для шифрования:
                    else MySymmetry.WritePathToFileWithDecryptedText = PathInputTextBox.Text;
                    PathToByteArray = "\\EncryptedViaAES.txt";
                }
                else //Если выбран Rijndael
                {
                    //Если объекта не существует, создаем его:
                    if (MySymmetry as RijndaelClass == null) MySymmetry = new RijndaelClass(PathInputTextBox.Text);
                    //Если объект существует, но его поле с текстом для шифрования пусто или путь требует обновления:
                    else MySymmetry.WritePathToFileWithDecryptedText = PathInputTextBox.Text;
                    PathToByteArray = "\\EncryptedViaRijndael.txt";
                }
                //Если RadioButton == Encrypt - идет шифрование текста:
                if (Encrypt.Checked == true)
                {
                    //Шифрование текста
                    MySymmetry.EncryptStringIntoBytes();
                    using (var Reader = System.IO.File.OpenText(System.IO.Directory.GetCurrentDirectory() + PathToByteArray)) EncryptedTextBox.Text = Reader.ReadToEnd();
                }
                //Если RadioButton == Decrypt - идет расшифровка текста:
                else EncryptedTextBox.Text = MySymmetry.DecryptStringFromBytes(System.IO.File.ReadAllBytes(PathInputTextBox.Text));
            }
            catch (System.UnauthorizedAccessException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка безопасности. Возможно, у Вас недостаточно прав для записи на данном диске",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Security.Cryptography.CryptographicException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка шифрования. Возможно, Ваши Key и IV не поддерживаются",
                Ex.GetType().Name,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку при Шифровании/дешифровании с ВЫБОРОМ ПУТИ:
        private void EncryptAtChoicePathButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Если файла из пути в TextBox не существует:
                if (!System.IO.File.Exists(PathInputTextBox.Text)) throw new System.IO.FileNotFoundException("Файла на указанном Вами пути не существует!");
                //Определение алгоритма шифрования:
                //Если выбран AES:
                if (AES.Checked == true)
                {
                    //Если объекта не существует, создаем его:
                    if (MySymmetry as AESClass == null) MySymmetry = new AESClass(PathInputTextBox.Text);
                    //Если объект существует, обновляем поле с текстом для шифрования:
                    else MySymmetry.WritePathToFileWithDecryptedText = PathInputTextBox.Text;
                }
                else //Если выбран Rijndael
                {
                    //Если объекта не существует, создаем его:
                    if (MySymmetry as RijndaelClass == null) MySymmetry = new RijndaelClass(PathInputTextBox.Text);
                    //Если объект существует, но его поле с текстом для шифрования пусто или путь требует обновления:
                    else MySymmetry.WritePathToFileWithDecryptedText = PathInputTextBox.Text;
                }
                if (Encrypt.Checked == true) //Если RadioButton == Encrypt - идет шифрование текста:
                {
                    //Заголовок и открытие файлового окна OFD:
                    SaveFileDialog.Title = "Выбор файла для сохранения шифрованного текста";
                    if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //Шифрование текста:
                        MySymmetry.EncryptStringIntoBytes(SaveFileDialog.FileName);
                        using (var Reader = System.IO.File.OpenText(SaveFileDialog.FileName)) EncryptedTextBox.Text = Reader.ReadToEnd();
                    }
                    //Освобождение ресурсов:
                    SaveFileDialog.Dispose();
                }
                else //Если RadioButton == Decrypt - идет расшифровка текста:
                {
                    //Заголовок и открытие файлового окна SFD:
                    SaveFileDialog.Title = "Выбор файла для сохранения дешифрованного текста";
                    if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Дешифрование текста:
                        EncryptedTextBox.Text = MySymmetry.DecryptStringFromBytes(System.IO.File.ReadAllBytes(PathInputTextBox.Text), SaveFileDialog.FileName);
                    //Освобождение ресурсов:
                    SaveFileDialog.Dispose();
                }
            }
            catch (System.UnauthorizedAccessException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка безопасности. Возможно, у Вас недостаточно прав для записи на данном диске",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Security.Cryptography.CryptographicException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка шифрования. Возможно, Ваши Key и IV не поддерживаются",
                Ex.GetType().Name,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку ВВОДА ПУТИ с файлом для шифрования/дешифрования:
        private void ChoiceOfPathButton_Click(object sender, System.EventArgs e)
        {
            //Определение формата файлов, который можно будет выбрать в OpenFileDialog:
            OpenFileDialog.Filter = "Все файлы (*.*)|*.*|Текстовый файл (*.txt)|*.txt|Документ HTML (*.html)|*.html|Электронная книга (*.fb2; *.epub)|*.fb2; *.epub";
            //Заголовок файлового окна OFD:
            OpenFileDialog.Title = "Выбор текстового файла";
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) PathInputTextBox.Text = OpenFileDialog.FileName;
            //Освобождение ресурсов:
            OpenFileDialog.Dispose();
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку "Сохранить Key & IV":
        private void SaveKeyAndIVData_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Если объекта не существует:
                if (MySymmetry == null) throw new System.NullReferenceException("Текущие Key и IV не установлены в программе!");
                //Если ссылка на объект производного от SymmetryAbstract класса не соответствует выбранному алгоритму шифрования:
                if ((MySymmetry is AESClass && Rijndael.Checked == true) || (MySymmetry is RijndaelClass && AES.Checked == true))
                    throw new System.FormatException("Нельзя сохранить Key и IV, так как они принадлежат к другому алгоритму шифрования!");

                //Очищение TextBox'ов:
                PathInputTextBox.Clear();
                EncryptedTextBox.Clear();

                //Сохраняем ключ:
                MySymmetry.WriteKeyAndIVInFile();
            }
            catch (System.UnauthorizedAccessException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка безопасности. Возможно, у Вас недостаточно прав для записи на данном диске",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку для сохранения Key и IV в файл пользователя:
        private void SaveKeyAndIVInUserFolder_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Если объекта не существует:
                if (MySymmetry == null) throw new System.NullReferenceException("Текущие Key и IV не установлены в программе!");
                //Если ссылка на объект производного от SymmetryAbstract класса не соответствует выбранному алгоритму шифрования:
                if ((MySymmetry is AESClass && Rijndael.Checked == true) || (MySymmetry is RijndaelClass && AES.Checked == true))
                    throw new System.FormatException("Нельзя сохранить Key и IV, так как они принадлежат к другому алгоритму шифрования!");
                //Заголовок файлового окна SFD:
                SaveFileDialog.Title = "Сохранение Key и IV";
                //Запись в выбранный файл:
                if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) MySymmetry.WriteKeyAndIVInFile(SaveFileDialog.FileName);
                //Освобождение ресурсов:
                SaveFileDialog.Dispose();
            }
            catch (System.UnauthorizedAccessException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка безопасности. Возможно, у Вас недостаточно прав для записи на данном диске",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку "Загрузить Key & IV":
        private void LoadKeyAndIVData_Click(object sender, System.EventArgs e)
        {
            //Очищение TextBox:
            EncryptedTextBox.Clear();

            try
            {
                //Создание нового объекта и загрузка:
                if (AES.Checked == true) MySymmetry = new AESClass(); //Если выбран AES
                else MySymmetry = new RijndaelClass(); //Если выбран Rijndael
                //Сохранение в объекте Key и IV:
                MySymmetry.ReadKeyAndIVFromFile();
            }
            catch (System.UnauthorizedAccessException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка безопасности. Возможно, у Вас недостаточно прав для чтения на данном диске",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show("Выбранный Вами файл не содержат Key и IV, которые могут быть использованы для криптографических преобразований",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку загрузки Key и IV из файла, выбранного пользователем:
        private void LoadKeyAndIVViaOFDButton_Click(object sender, System.EventArgs e)
        {
            //Создание нового объекта и загрузка:
            if (AES.Checked == true) MySymmetry = new AESClass(); //Если выбран AES
            else MySymmetry = new RijndaelClass(); //Если выбран Rijndael
            try
            {
                //Определение формата файлов, который можно будет выбрать в OpenFileDialog:
                OpenFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
                //Меняем заголовок OFD:
                OpenFileDialog.Title = "Выбор файла с Key и IV";
                if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) MySymmetry.ReadKeyAndIVFromFile(OpenFileDialog.FileName);
                //Освобождение ресурсов:
                OpenFileDialog.Dispose();
            }
            catch (System.UnauthorizedAccessException Ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка безопасности. Возможно, у Вас недостаточно прав для чтения на данном диске",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
            catch (System.Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show("Выбранный Вами файл не содержат Key и IV, которые могут быть использованы для криптографических преобразований",
                    Ex.GetType().Name,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                //Запись лога вылета в файл:
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\log.txt",
                    $"Тип ошибки: {Ex.GetType()}\n\rОписание ошибки: {Ex.Message}\n\rМетод: {Ex.TargetSite}\n\rМесто ошибки: {Ex.StackTrace}");
            }
        }

        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку "Создать новые Key и IV":
        private void UpdateData_Click(object sender, System.EventArgs e)
        {
            //Очищение TextBox:
            EncryptedTextBox.Clear();

            //Создание нового объекта и загрузка в него ключа ключа:
            if (AES.Checked == true) MySymmetry = new AESClass(); //Если выбран AES
            else MySymmetry = new RijndaelClass(); //Если выбран Rijndael
            //Сохранение новых Key и IV в текстовый файл:
            MySymmetry.WriteKeyAndIVInFile();
        }


        //Метод, обрабатывающий событие, когда пользователь нажимает на кнопку "Создать новые Key и IV" и записать их в файл пользователя:
        private void UpdateDataOnUserPathButton_Click(object sender, System.EventArgs e)
        {
            //Заголовок файлового окна OFD:
            SaveFileDialog.Title = "Сохранение новых Key и IV";
            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Очищение TextBox:
                EncryptedTextBox.Clear();

                //Создание нового объекта и загрузка в него ключа ключа:
                if (AES.Checked == true) MySymmetry = new AESClass(); //Если выбран AES
                else MySymmetry = new RijndaelClass(); //Если выбран Rijndael
                //Сохранение новых Key и IV в текстовый файл:
                MySymmetry.WriteKeyAndIVInFile(SaveFileDialog.FileName);
            }
            //Освобождение ресурсов:
            SaveFileDialog.Dispose();
        }

        //Просто что бы очищался TextBox с шифрованным/дешифрованным текстом
        private void EncryptOrDecryptGroupBox_Enter(object sender, System.EventArgs e) => EncryptedTextBox.Clear();
        private void AlgorithmChoiceGroupBox_Enter(object sender, System.EventArgs e) => EncryptedTextBox.Clear();
    }
}




/*
 * Developed by Danil Rudin in 2021 year
 * College of Business Technology
 * Group of IB31-18
 * I express my gratitude for the knowledge received to 
 * Friedman V.A., 
 * Makarov A.L., 
 * Korotkin M.V., 
 * Ershova A.L.
 */