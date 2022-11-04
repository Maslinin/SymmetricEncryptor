using System.Windows.Forms;

namespace SymmetryEncrypter.Encrypters
{
    internal static class EncrypterFactory
    {
        public static IEncrypter CreateEncrypter(MainForm mainForm)
        {
            if (mainForm.AESRadioButton.Checked)
                return new AESEncrypter();
            else
                return new RC2Encrypter();
        }
    }
}
