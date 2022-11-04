using System.IO;
using System.Text;
using SymmetricEncryptor.Encryptors;

namespace SymmetricEncryptor.IOServices
{
    internal static class CryptDataIOService
    {
        public static void WriteKeyAndIVToFile(IEncryptor encryptor, string filePath)
        {
            using (var writer = new BinaryWriter(File.Create(filePath), Encoding.UTF8))
            {
                writer.Write(encryptor.Key.Length);
                writer.Write(encryptor.Key);

                writer.Write(encryptor.IV.Length);
                writer.Write(encryptor.IV);
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
