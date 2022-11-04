using System.Windows.Forms;

namespace SymmetryEncryptor.Encryptors
{
    internal static class EncryptorFactory
    {
        public static IEncryptor CreateEncryptor(MainForm mainForm)
        {
            if (mainForm.AESRadioButton.Checked)
                return new AESEncryptor();
            else
                return new RC2Encryptor();
        }
    }
}
