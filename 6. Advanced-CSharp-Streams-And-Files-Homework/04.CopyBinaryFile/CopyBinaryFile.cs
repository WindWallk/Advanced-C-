using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        private const string SourceFile = "../../image.jpg";
        private const string DestinationImage = "../../image-copy.jpg";
        static void Main(string[] args)
        {
            using (var source = new FileStream(SourceFile, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationImage, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
