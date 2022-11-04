using System;

namespace SymmetryEncryptor.Encryptors
{
    /// <summary>
    /// Specifies the list of abstract members of the class that implements encryption
    /// </summary>
    interface IEncryptor : IDisposable
    {
        /// <summary>
        /// Encryption Key
        /// </summary>
        byte[] Key { get; set; }
        /// <summary>
        /// Initialization vector for symmetric encryption
        /// </summary>
        byte[] IV { get; set; }

        /// <summary>
        /// Encrypts text with a symmetric encryption algorithm
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Array consisting of encrypted bytes</returns>
        byte[] EncryptText(string text);
        /// <summary>
        /// Decrypts text encrypted by a symmetric encryption algorithm
        /// </summary>
        /// <param name="encryptedData"></param>
        /// <returns>Decrypted string</returns>
        string DecryptText(byte[] encryptedData);
    }
}
