namespace SymmetricCryptography
{
    abstract class SymmetryAbstract
    {
        //Поле для записи в него вектора инициализации:
        protected byte[] IV;
        //Поле для записи в него ключа шифрования:
        protected byte[] Key;
        //Поле для записи в нее текста для дешифрования:
        protected string TextForEncrypted;

        //Методы, которые должен реализовывать производный класс:
        public abstract void EncryptStringIntoBytes(); //Шифрование
        public abstract void EncryptStringIntoBytes(string Path); //Шифрование и сохранение файлов на путь, выбранный пользователем
        public abstract string DecryptStringFromBytes(byte[] CipherBytes); //Дешифрование
        public abstract string DecryptStringFromBytes(byte[] CipherBytes, string Path); //Дешифрование и сохранение файлов на путь, выбранный пользователем
        public abstract void WriteKeyAndIVInFile(); //Запись ключа и Вектора инициализации в бинарном представлении
        public abstract void WriteKeyAndIVInFile(string Path); //Метод для записи ключа и Вектора инициализации в бинарном представлении в папку пользователя:
        public abstract void ReadKeyAndIVFromFile(); //Считывание ключа и Вектора инициализации в бинарном представлении

        //Метод для считывания ключа и Вектора инициализации в бинарном представлении из файла ползователя:
        public void ReadKeyAndIVFromFile(string Path)
        {
            //Запись Ключа и вектора инициализации в файл в бинарном представлении:
            using (var Reader = new System.IO.BinaryReader(System.IO.File.OpenRead(Path), System.Text.Encoding.UTF8))
            {
                //Считывание длины Key массива: 
                int KeyLength = Reader.ReadInt32();
                //Считывание Key массива:
                Key = Reader.ReadBytes(KeyLength);

                //Считывание длины IV массива:
                int IVLength = Reader.ReadInt32();
                //Считывание IV массива:
                IV = Reader.ReadBytes(IVLength);

                //Освобождение ресурсов:
                Reader.Dispose();
            }
            //Вывод сообщения об успешной записи:
            System.Windows.Forms.MessageBox.Show("Ваш ключ и вектор инициализации были успешно загружены",
                "Данные загружены",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
        //Свойство для записи текста в поле TextForEncrypted:
        public string WritePathToFileWithDecryptedText { set => TextForEncrypted = System.IO.File.ReadAllText(value); } //Загрузка текста из файла
    }
}