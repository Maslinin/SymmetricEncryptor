namespace SymmetricEncryptor.Encryptors
{
    internal static class EncryptorFactory
    {
        public static IEncryptor CreateEncryptor(MainForm mainForm)
        {
            if (mainForm.AESRadioButton.Checked)
                return new AesEncryptor();
            else
                return new RC2Encryptor();
        }
    }
}
