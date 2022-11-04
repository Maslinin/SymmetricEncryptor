using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace SymmetricEncryptor.Encryptors
{
    internal class RC2Encryptor : IEncryptor
    {
        private readonly RC2 _rc2;

        public byte[] Key { get; set; }
        public byte[] IV { get; set; }

        public RC2Encryptor()
        {
            this._rc2 = RC2.Create();

            this.Key = this._rc2.Key;
            this.IV = this._rc2.IV;
        }

        public byte[] EncryptText(string text)
        {
            byte[] encryptedBytes;

            var encryptor = this._rc2.CreateEncryptor(this.Key, this.IV);

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

            var decryptor = this._rc2.CreateDecryptor(this.Key, this.IV);

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
            this._rc2.Dispose();
        }
    }
}
