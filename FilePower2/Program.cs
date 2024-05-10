using System;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("Not enough arguments provided.");
                return;
            }

            string fileName = args[0];

            Console.WriteLine("Add text to file...");

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                string line;
                while (true)
                {
                    line = Console.ReadLine();

                    if (string.IsNullOrEmpty(line))
                        break;

                    writer.WriteLine(line);
                }
            }
        }
    }
}
