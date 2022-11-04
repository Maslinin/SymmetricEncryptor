using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace SymmetryEncrypter.Encrypters
{
    internal sealed class AESEncrypter : IEncrypter
    {
        private readonly Aes _aes;

        public byte[] Key { get; set; }
        public byte[] IV { get; set; }

        public AESEncrypter()
        {
            this._aes = Aes.Create();

            this.Key = this._aes.Key;
            this.IV = this._aes.IV;
        }

        public byte[] EncryptText(string text)
        {
            byte[] encryptedBytes;

            var encryptor = this._aes.CreateEncryptor(this.Key, this.IV);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new StreamWriter(cryptoStream, Encoding.UTF8))
                    {
                        streamWriter.Write(text);
                    }

                    encryptedBytes = memoryStream.ToArray();
                }
            }

            return encryptedBytes;
        }

        public string DecryptText(byte[] encryptedData)
        {
            string decryptText;

            var decryptor = this._aes.CreateDecryptor(this.Key, this.IV);

            using (var memoryStream = new MemoryStream(encryptedData))
            {
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (var streamReader = new StreamReader(cryptoStream, Encoding.UTF8))
                    {
                        decryptText = streamReader.ReadToEnd();
                    }
                }
            }

            return decryptText;
        }

        public void Dispose()
        {
            this._aes.Dispose();
        }
    }
}