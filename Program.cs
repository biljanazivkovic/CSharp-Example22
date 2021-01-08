using System;
using System.IO;

namespace ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";
            File.WriteAllText("text.txt", writeText);

            string readText = File.ReadAllText("text.txt");
            Console.WriteLine(readText);
        }
    }
}
