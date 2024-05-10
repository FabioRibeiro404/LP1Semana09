using System;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName; 
            string line;


            if (args.Length <= 0)
            {
                Console.WriteLine("Not enough");
                return;
            }

            fileName = args[0];

            Console.WriteLine("Add text to file...");

            using StreamWriter writer = new StreamWriter(fileName);



                while(true)
                {
                    line = Console.ReadLine();

                    if(line.Length <= 0)
                        break;

                    writer.WriteLine(line);
                }
        }
    }
}
