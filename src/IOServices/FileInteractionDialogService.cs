using System;
using System.Windows.Forms;

namespace SymmetricEncryptor.IOServices
{
    internal sealed class FileInteractionDialogService
    {
        private readonly OpenFileDialog _openFileDialog;
        private readonly SaveFileDialog _saveFileDialog;

        public FileInteractionDialogService()
        {
            this._openFileDialog = new OpenFileDialog();
            this._saveFileDialog = new SaveFileDialog();

            string initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this._openFileDialog.InitialDirectory = initialDirectory;
            this._saveFileDialog.InitialDirectory = initialDirectory;

            string filesFormats = "Text file|*.txt";
            this._openFileDialog.Filter = filesFormats;
            this._saveFileDialog.Filter = filesFormats;

            this._openFileDialog.Title = "Select a text file";
            this._saveFileDialog.Title = "Select the file to save the data to";
        }

        public string OpenFileViaDialog()
        {
            if (this._openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return this._openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public string SaveFileViaDialog()
        {
            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return this._saveFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

    }
}
