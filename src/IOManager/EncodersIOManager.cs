using System.IO;
using SymmetryEncoder.Encoders;

namespace SymmetryEncoder.IOManager
{
    static class EncodersIOManager
    {
        /// <summary>
        /// Writes data for decryption to the specified path
        /// </summary>
        /// <param name="symmetry"></param>
        /// <param name="pathFolder"></param>
        /// <returns>Path to a new file containing data to decrypt</returns>
        public static string WriteKeyAndIVInFile(ISymmetry symmetry, string filePath)
        {
            using (var writer = new BinaryWriter(File.Create(filePath), System.Text.Encoding.UTF8))
            {
                writer.Write(symmetry.Key.Length);
                writer.Write(symmetry.Key);

                writer.Write(symmetry.IV.Length);
                writer.Write(symmetry.IV);
            }

            return filePath;
        }

        /// <summary>
        /// Reads IV and Kеy from the specified file
        /// </summary>
        /// <param name="symmetry"></param>
        /// <param name="filePath"></param>
        /// <returns>ISymmetry instance with new IV and Key</returns>
        public static ISymmetry ReadKeyAndIVFromFile(ISymmetry symmetry, string filePath)
        {
            using (var reader = new BinaryReader(File.OpenRead(filePath), System.Text.Encoding.UTF8))
            {
                int length = reader.ReadInt32();
                symmetry.Key = reader.ReadBytes(length);

                length = reader.ReadInt32();
                symmetry.IV = reader.ReadBytes(length);
            }

            return symmetry;
        }
    }
}
