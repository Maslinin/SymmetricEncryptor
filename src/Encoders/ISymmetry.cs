namespace SymmetryEncoder.Encoders
{
    /// <summary>
    /// Specifies the list of abstract members of the class that implements encryption
    /// </summary>
    interface ISymmetry
    {
        /// <summary>
        /// Symmetric Encryption Key
        /// </summary>
        byte[] Key { get; set; }
        /// <summary>
        /// Initialization vector for symmetric encryption
        /// </summary>
        byte[] IV { get; set; }

        /// <summary>
        /// Encrypts text with a symmetric encryption algorithm
        /// </summary>
        /// <param name="textForEncrypted"></param>
        /// <param name="filePath"></param>
        /// <returns>Array consisting of encrypted bytes</returns>
        byte[] EncryptStringIntoBytes(string textForEncrypted);
        /// <summary>
        /// Decrypts text encrypted by a symmetric encryption algorithm
        /// </summary>
        /// <param name="encryptedData"></param>
        /// <param name="filePath"></param>
        /// <returns>Decrypted string</returns>
        string DecryptStringFromBytes(byte[] encryptedData);
    }
}