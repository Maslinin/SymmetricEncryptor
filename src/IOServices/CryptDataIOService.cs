using System.IO;
using System.Text;
using SymmetryEncrypter.Encrypters;

namespace SymmetryEncrypter.IOServices
{
    internal static class CryptDataIOService
    {
        public static void WriteKeyAndIVToFile(IEncrypter encrypter, string filePath)
        {
            using (var writer = new BinaryWriter(File.Create(filePath), Encoding.UTF8))
            {
                writer.Write(encrypter.Key.Length);
                writer.Write(encrypter.Key);

                writer.Write(encrypter.IV.Length);
                writer.Write(encrypter.IV);
            }
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
