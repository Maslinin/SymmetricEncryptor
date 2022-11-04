using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SymmetryEncoder.Encoders;

namespace SymmetryEncoder.IOManagers
{
    sealed class FileManager
    {
        private readonly OpenFileDialog _openFileDialog;
        private readonly SaveFileDialog _saveFileDialog;

        public FileManager()
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

        public static string WriteKeyAndIVToFile(IEncoder symmetry, string filePath)
        {
            using (var writer = new BinaryWriter(File.Create(filePath), Encoding.UTF8))
            {
                writer.Write(symmetry.Key.Length);
                writer.Write(symmetry.Key);

                writer.Write(symmetry.IV.Length);
                writer.Write(symmetry.IV);
            }

            return filePath;
        }

        public static (byte[], byte[]) ReadKeyAndIVFromFile(string filePath)
        {
            byte[] key, iv;

            using (var reader = new BinaryReader(File.OpenRead(filePath), Encoding.UTF8))
            {
                int length = reader.ReadInt32();
                key = reader.ReadBytes(length);

                length = reader.ReadInt32();
                iv = reader.ReadBytes(length);
            }

            return (key, iv);
        }
    }
}
