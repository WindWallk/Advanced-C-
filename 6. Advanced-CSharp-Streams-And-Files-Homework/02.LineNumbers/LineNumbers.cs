using System;
using System.IO;
using System.Text;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(@"..\..\LineNumbers.cs", Encoding.GetEncoding("windows-1251"));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            try
            {
                writer = new StreamWriter(@"..\..\LineNumbers.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to create output file.");
            }

            string line;
            int lineNumber = 1;
            using (reader)
            {
                using (writer)
                {
                    do
                    {
                        line = reader.ReadLine();
                        writer.WriteLine("{0} {1}", lineNumber, line);
                        lineNumber++;
                    } while (line != null);
                }
            }
        }
    }
}
