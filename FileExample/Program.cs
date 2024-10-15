using System;
using System.Collections.Generic;
using System.IO;

namespace FileExample
{
     class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"c:\practice\India.txt").Close();
            //@ disables escape sequence character "\"

            string filePath = @"c:\practice\India.txt", filePath2 = @"c:\practice\India2.txt", filePath3=@"c:\practice\another.txt";
            File.Create(filePath).Close();
            Console.WriteLine("India.txt created");

            bool exists=File.Exists(filePath);
            if (exists)
            {
                File.Copy(filePath, filePath2);
                Console.WriteLine("Copied India.txt to India2.txt");

                File.Move(filePath2, filePath3);
                Console.WriteLine("copied successfully");

                File.Delete(filePath3);
                Console.WriteLine("another.txt deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}
