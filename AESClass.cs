namespace SymmetricCryptography
{
    sealed class AESClass : SymmetryAbstract
    {
        //Конструкторы для создания новых Key и IV:
        public AESClass() : base()
        {
            //Создание случайного ключа и вектора инициализации:
            var MyAES = System.Security.Cryptography.Aes.Create();
            IV = MyAES.IV;
            Key = MyAES.Key;

            //Освобождение ресурсов:
            MyAES.Clear();
        }
        public AESClass(string PathToText) : base()
        {
            //Создание случайного ключа и вектора инициализации:
            var MyAES = System.Security.Cryptography.Aes.Create();
            IV = MyAES.IV;
            Key = MyAES.Key;
            //Скачивание текста с файла:
            TextForEncrypted = System.IO.File.ReadAllText(PathToText);

            //Освобождение ресурсов:
            MyAES.Clear();
        }

        //Метод для симмитричного шифрования строки с помощью алгоритма AES:
        public override void EncryptStringIntoBytes()
        {
            byte[] Encrypted = null;
            using (var MyAES = System.Security.Cryptography.Aes.Create())
            {
                //Создание шифратора для выполнения преобразования потока:
                var Encryptor = MyAES.CreateEncryptor(Key, IV);
                //Создание потоков для Encryptor:
                using (var MemoryStreamEncrypt = new System.IO.MemoryStream())
                {
                    using (var CryptoStream = new System.Security.Cryptography.CryptoStream(MemoryStreamEncrypt, Encryptor, System.Security.Cryptography.CryptoStreamMode.Write))
                    {
                        using (var Writer = new System.IO.StreamWriter(CryptoStream, System.Text.Encoding.UTF8))
                        {
                            Writer.Write(TextForEncrypted);
                            //Освобождение ресурсов:
                            Writer.Dispose();
                        }
                        Encrypted = MemoryStreamEncrypt.ToArray();
                        //Освобождение ресурсов:
                        CryptoStream.Dispose();
                    }
                    //Освобождение ресурсов:
                    MemoryStreamEncrypt.Dispose();
                }
                //Освобождение ресурсов:
                Encryptor.Dispose();
                //Освобождение ресурсов:
                MyAES.Clear();
            }
            //Запись зашифрованного текста в текстовый файл:
            System.IO.File.WriteAllBytes(System.IO.Directory.GetCurrentDirectory() + "\\EncryptedViaAES.txt", Encrypted);
            //Вывод сообщения о записи зашифрованного текста:
            System.Windows.Forms.MessageBox.Show($"Зашифрованный текст был сохранен в файле по пути {System.IO.Directory.GetCurrentDirectory() + "\\EncryptedViaAES.txt"}",
                "Шифрование завершено",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);

            //Запись текущего ключа и вектора инициализации в файл:
            WriteKeyAndIVInFile();
        }
        //Метод для симмитричного шифрования строки с помощью алгоритма AES с сохранением данных на путь, указанный пользователем:
        public override void EncryptStringIntoBytes(string Path)
        {
            byte[] Encrypted = null;
            using (var MyAES = System.Security.Cryptography.Aes.Create())
            {
                //Создание шифратора для выполнения преобразования потока:
                var Encryptor = MyAES.CreateEncryptor(Key, IV);
                //Создание потоков для Encryptor:
                using (var MemoryStreamEncrypt = new System.IO.MemoryStream())
                {
                    using (var CryptoStream = new System.Security.Cryptography.CryptoStream(MemoryStreamEncrypt, Encryptor, System.Security.Cryptography.CryptoStreamMode.Write))
                    {
                        using (var Writer = new System.IO.StreamWriter(CryptoStream, System.Text.Encoding.UTF8))
                        {
                            Writer.Write(TextForEncrypted);
                            //Освобождение ресурсов:
                            Writer.Dispose();
                        }
                        Encrypted = MemoryStreamEncrypt.ToArray();
                        //Освобождение ресурсов:
                        CryptoStream.Dispose();
                    }
                    //Освобождение ресурсов:
                    MemoryStreamEncrypt.Dispose();
                }
                //Освобождение ресурсов:
                Encryptor.Dispose();
                //Освобождение ресурсов:
                MyAES.Clear();
            }
            //Запись зашифрованного текста в текстовый файл:
            System.IO.File.WriteAllBytes(Path, Encrypted);
            //Вывод сообщения о записи зашифрованного текста:
            System.Windows.Forms.MessageBox.Show($"Зашифрованный текст был сохранен в файле по пути {Path}",
                "Шифрование завершено",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            //Запись текущего ключа и вектора инициализации в файл:
            var FileInfo = new System.IO.FileInfo(Path);
            WriteKeyAndIVInFile(FileInfo.FullName.Remove(FileInfo.FullName.Length - FileInfo.Name.Length) + "BinaryInfoForAES.txt");
        }

        //Метод для расшифровки строки, зашифрованной симметричным шифрованием алгоритмом AES:
        public override string DecryptStringFromBytes(byte[] CipherBytes)
        {
            string DecryptString = null;
            using (var MyAES = System.Security.Cryptography.Aes.Create())
            {
                //Создание Decryptor для выполнения преобразования потока:
                var Decryptor = MyAES.CreateDecryptor(Key, IV);
                //Создание потоков для Decryptor:
                using (var MemoryStreamDecrypt = new System.IO.MemoryStream(CipherBytes))
                {
                    using (var CryptoStream = new System.Security.Cryptography.CryptoStream(MemoryStreamDecrypt, Decryptor, System.Security.Cryptography.CryptoStreamMode.Read))
                    {
                        using (var Reader = new System.IO.StreamReader(CryptoStream, System.Text.Encoding.UTF8))
                        {
                            DecryptString = Reader.ReadToEnd();
                            //Освобождение ресурсов:
                            Reader.Dispose();
                        }
                        //Освобождение ресурсов:
                        CryptoStream.Dispose();
                    }
                    //Освобождение ресурсов:
                    MemoryStreamDecrypt.Dispose();
                }
                //Освобождение ресурсов:
                Decryptor.Dispose();

                //Освобождение ресурсов:
                MyAES.Clear();
            }
            //Запись расшифрованного текста в текстовый файл:
            System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\DecryptedTextViaAES.txt", DecryptString);
            //Вывод сообщения о записи зашифрованного текста:
            System.Windows.Forms.MessageBox.Show($"Расшифрованный текст был сохранен в файле по пути {System.IO.Directory.GetCurrentDirectory() + "\\DecryptedTextViaAES.txt"}",
                "Дешифрование завершено",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            return DecryptString;
        }
        //Метод для симмитричного дешифрования строки с помощью алгоритма AES с сохранением данных на путь, указанный пользователем:
        public override string DecryptStringFromBytes(byte[] CipherBytes, string Path)
        {
            string DecryptString = null;
            using (var MyAES = System.Security.Cryptography.Aes.Create())
            {
                //Создание Decryptor для выполнения преобразования потока:
                var Decryptor = MyAES.CreateDecryptor(Key, IV);
                //Создание потоков для Decryptor:
                using (var MemoryStreamDecrypt = new System.IO.MemoryStream(CipherBytes))
                {
                    using (var CryptoStream = new System.Security.Cryptography.CryptoStream(MemoryStreamDecrypt, Decryptor, System.Security.Cryptography.CryptoStreamMode.Read))
                    {
                        using (var Reader = new System.IO.StreamReader(CryptoStream, System.Text.Encoding.UTF8))
                        {
                            DecryptString = Reader.ReadToEnd();
                            //Освобождение ресурсов:
                            Reader.Dispose();
                        }
                        //Освобождение ресурсов:
                        CryptoStream.Dispose();
                    }
                    //Освобождение ресурсов:
                    MemoryStreamDecrypt.Dispose();
                }
                //Освобождение ресурсов:
                Decryptor.Dispose();

                //Освобождение ресурсов:
                MyAES.Clear();
            }
            //Запись расшифрованного текста в текстовый файл:
            System.IO.File.WriteAllText(Path, DecryptString);
            //Вывод сообщения о записи зашифрованного текста:
            System.Windows.Forms.MessageBox.Show($"Расшифрованный текст был сохранен в файле по пути {Path}",
                "Дешифрование завершено",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            return DecryptString;
        }

        //Метод для записи ключа и Вектора инициализации в бинарном представлении:
        public override void WriteKeyAndIVInFile()
        {
            //Запись Ключа и вектора инициализации в файл в бинарном представлении:
            using (var Writer = new System.IO.BinaryWriter(System.IO.File.Create(System.IO.Directory.GetCurrentDirectory() + "\\BinaryInfoForAES.txt"), System.Text.Encoding.UTF8))
            {
                //Запись длины массива Key:
                Writer.Write(Key.Length);
                //Запись массива Key:
                Writer.Write(Key);

                //Запись длины массива IV:
                Writer.Write(IV.Length);
                //Запись массива IV:
                Writer.Write(IV);

                //Освобождение ресурсов:
                Writer.Dispose();
            }
            //Вывод сообщения об успешной записи:
            System.Windows.Forms.MessageBox.Show($"Ваши Key и IV были успешно сохранены по пути {System.IO.Directory.GetCurrentDirectory() + "\\BinaryInfoForAES.txt"}",
                "Данные сохранены",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
        //Метод для записи ключа и Вектора инициализации в бинарном представлении в файл пользователя:
        public override void WriteKeyAndIVInFile(string Path)
        {
            //Запись Ключа и вектора инициализации в файл в бинарном представлении:
            using (var Writer = new System.IO.BinaryWriter(System.IO.File.Create(Path), System.Text.Encoding.UTF8))
            {
                //Запись длины массива Key:
                Writer.Write(Key.Length);
                //Запись массива Key:
                Writer.Write(Key);

                //Запись длины массива IV:
                Writer.Write(IV.Length);
                //Запись массива IV:
                Writer.Write(IV);

                //Освобождение ресурсов:
                Writer.Dispose();
            }
            //Вывод сообщения об успешной записи:
            System.Windows.Forms.MessageBox.Show($"Ваши Key и IV были успешно сохранены по пути {Path}",
                "Данные сохранены",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }

        //Метод для считывания ключа и Вектора инициализации в бинарном представлении:
        public override void ReadKeyAndIVFromFile()
        {
            //Если System.IO.Directory.GetCurrentDirectory() + "\\BinaryInfoForAES.txt" не существует:
            if (!System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\BinaryInfoForAES.txt"))
                throw new System.IO.FileNotFoundException($"Файл для считывания параметров шифрования по пути {System.IO.Directory.GetCurrentDirectory() + "\\BinaryInfoForAES.txt"} не обнаружен.");
            //Запись Ключа и вектора инициализации в файл в бинарном представлении:
            using (var Reader = new System.IO.BinaryReader(System.IO.File.OpenRead(System.IO.Directory.GetCurrentDirectory() + "\\BinaryInfoForAES.txt"), System.Text.Encoding.UTF8))
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
            System.Windows.Forms.MessageBox.Show("Ваши Key и IV были успешно загружены",
                "Данные загружены",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}