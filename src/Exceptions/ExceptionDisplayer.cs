﻿using System;
using System.Windows.Forms;

namespace SymmetryEncoder.Exceptions
{
    internal static class ExceptionDisplayer
    {
        public static void DisplayException(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}