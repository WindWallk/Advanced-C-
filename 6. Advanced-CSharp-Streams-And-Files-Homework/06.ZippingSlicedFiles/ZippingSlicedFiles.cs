﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace _06.ZippingSlicedFiles
{
    class ZippingSlicedFiles
    {
        private static List<string> files = new List<string>();
        private static MatchCollection matches;

        static void Main(string[] args)
        {
            string fileToSlice = "../../6. Advanced-CSharp-Streams-And-Files-Homework.docx";
            string destinationDir = "../../";
            int numberOfParts = 5;

            Slice(fileToSlice, destinationDir, numberOfParts);

            Assemble(files, destinationDir);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                long partSize = (long)Math.Ceiling((double)source.Length / parts);

                string partPath;
                long sizeRemaining = source.Length;

                string pattern = @"(\w+)(?=\.)\.(?<=\.)(\w+)";
                Regex pairs = new Regex(pattern);
                matches = pairs.Matches(sourceFile);

                for (int i = 0; i < parts; i++)
                {
                    partPath = destinationDirectory + String.Format(@"Part-{0}.gz", i);
                    files.Add(partPath);

                    using (var part = new FileStream(partPath, FileMode.Create))
                    {
                        using (var compressionStream = new GZipStream(part, CompressionMode.Compress, false))
                        {
                            long pieceSize = 0;
                            byte[] buffer = new byte[4096];
                            while (pieceSize < partSize)
                            {
                                int readBytes = source.Read(buffer, 0, buffer.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                compressionStream.Write(buffer, 0, readBytes);
                                pieceSize += readBytes;
                            }
                        }
                    }

                    sizeRemaining = (int)source.Length - (i * partSize);
                    if (sizeRemaining < partSize)
                    {
                        partSize = sizeRemaining;
                    }
                }

            }

        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            string assembledFilePath = destinationDirectory + "assembled." + matches[0].Groups[2];

            using (var destination = new FileStream(assembledFilePath, FileMode.Create))
            {
                foreach (var filePart in files)
                {
                    using (var part = new FileStream(filePart, FileMode.Open))
                    {
                        using (var compressionStream = new GZipStream(part, CompressionMode.Decompress, false))
                        {
                            byte[] buffer = new byte[4096];
                            while (true)
                            {
                                int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
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
    }
}
