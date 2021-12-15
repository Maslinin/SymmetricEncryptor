using System.IO;
using System.Security.Cryptography;

namespace SymmetryEncoder.Encoders
{
    sealed class RijndaelEncoder : ISymmetry
    {
        public byte[] Key { get; set; }
        public byte[] IV { get; set; }

        /// <summary>
        /// Initializes class instance with new IV and Key
        /// </summary>
        public RijndaelEncoder()
        {
            var MyRijndael = Rijndael.Create();
            Key = MyRijndael.Key;
            IV = MyRijndael.IV;

            MyRijndael.Clear();
        }

        public byte[] EncryptStringIntoBytes(string textForEncrypted)
        {
            byte[] encrypted = null;

            using (var myRijndael = Rijndael.Create())
            {
                myRijndael.Key = Key;
                myRijndael.IV = IV;

                var encryptor = myRijndael.CreateEncryptor(myRijndael.Key, myRijndael.IV);
                
                using (var memoryStreamEncrypt = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStreamEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cryptoStream, System.Text.Encoding.UTF8))
                        {
                            writer.Write(textForEncrypted);
                        }
                        encrypted = memoryStreamEncrypt.ToArray();
                    }
                }
                myRijndael.Clear();
            }

            return encrypted;
        }

        public string DecryptStringFromBytes(byte[] encryptedData)
        {
            string decryptString = null;
            using (var myRijndael = Rijndael.Create())
            {
                myRijndael.Key = Key;
                myRijndael.IV = IV;

                var decryptor = myRijndael.CreateDecryptor(myRijndael.Key, myRijndael.IV);

                using (var memoryStreamDecrypt = new MemoryStream(encryptedData))
                {
                    using (var cryptoStream = new CryptoStream(memoryStreamDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var reader = new StreamReader(cryptoStream, System.Text.Encoding.UTF8))
                        {
                            decryptString = reader.ReadToEnd();
                        }
                    }
                }
                myRijndael.Clear();
            }

            return decryptString;
        }
    }
}