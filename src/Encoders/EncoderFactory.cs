using System.Windows.Forms;

namespace SymmetryEncoder.Encoders
{
    internal static class EncoderFactory
    {
        public static IEncoder CreateEncoder(MainForm mainForm)
        {
            if (mainForm.AESRadioButton.Checked)
                return new AesEncoder();
            else
                return new RC2Encoder();
        }
    }
}
