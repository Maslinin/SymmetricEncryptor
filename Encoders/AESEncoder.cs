using System.IO;
using System.Security.Cryptography;

namespace SymmetryEncoder.Encoders
{
    sealed class AESEncoder : ISymmetry
    {
        public byte[] IV { get; set; }
        public byte[] Key { get; set; }

        /// <summary>
        /// Initializes class instance with new IV and Key
        /// </summary>
        public AESEncoder()
        {
            var MyAES = Aes.Create();
            IV = MyAES.IV;
            Key = MyAES.Key;

            MyAES.Clear();
        }

        public byte[] EncryptStringIntoBytes(string textForEncrypted)
        {
            byte[] encrypted = null;

            using (var myAES = Aes.Create())
            {
                myAES.Key = Key;
                myAES.IV = IV;

                var encryptor = myAES.CreateEncryptor(myAES.Key, myAES.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt, System.Text.Encoding.UTF8))
                        {
                            swEncrypt.Write(textForEncrypted);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
                myAES.Clear();
            }

            return encrypted;
        }

        public string DecryptStringFromBytes(byte[] encryptedData)
        {
            string decryptString = null;

            using (var myAES = Aes.Create())
            {
                myAES.Key = Key;
                myAES.IV = IV;

                var decryptor = myAES.CreateDecryptor(myAES.Key, myAES.IV);
                
                using (var msDecrypt = new MemoryStream(encryptedData))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt, System.Text.Encoding.UTF8))
                        {
                            decryptString = srDecrypt.ReadToEnd();
                        }
                    }
                }
                myAES.Clear();
            }

            return decryptString;
        }
    }
}

//https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.aes?view=netframework-4.8s