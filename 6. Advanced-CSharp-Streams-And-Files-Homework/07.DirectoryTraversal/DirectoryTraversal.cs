using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08.DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"../../");

            List<FileInfo> files = filePaths.Select(path => new FileInfo(path)).ToList();

            var sorted =
                files.OrderBy(file => file.Length)
                    .GroupBy(file => file.Extension)
                    .OrderByDescending(group => group.Count())
                    .ThenBy(group => group.Key);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var writer = new StreamWriter(desktop + "/report.txt"))
            {
                foreach (var group in sorted)
                {
                    writer.WriteLine(group.Key);

                    foreach (var info in group)
                    {
                        writer.WriteLine("--{0} - {1:F3}kb", info.Name, info.Length / 1024.0);
                    }
                }
            }
        }
    }
}
