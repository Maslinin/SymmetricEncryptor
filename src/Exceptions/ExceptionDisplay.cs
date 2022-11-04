using System;
using System.Windows.Forms;

namespace SymmetricEncryptor.Exceptions
{
    internal static class ExceptionDisplay
    {
        public static void DisplayException(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
