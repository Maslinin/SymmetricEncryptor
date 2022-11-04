using System;

namespace SymmetricEncryptor.Encryptors
{
    internal interface IEncryptor : IDisposable
    {
        byte[] Key { get; set; }
        byte[] IV { get; set; }

        byte[] EncryptText(string text);
        string DecryptText(byte[] encryptedData);
    }
}
