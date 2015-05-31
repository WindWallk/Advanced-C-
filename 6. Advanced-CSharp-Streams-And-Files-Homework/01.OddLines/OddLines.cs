using System;
using System.IO;
using System.Text;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(@"..\..\OddLines.cs", Encoding.ASCII);
                int lineNumber = 0;
                string line;

                using (reader)
                {
                    do
                    {
                        line = reader.ReadLine();
                        lineNumber++;
                        line = reader.ReadLine();
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        lineNumber++;
                    } while (line != null);
                }

        }
            catch (FileNotFoundException)
            {

                Console.WriteLine("File not found!");
            }
        }
    }
}
