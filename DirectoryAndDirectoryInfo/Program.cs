using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}