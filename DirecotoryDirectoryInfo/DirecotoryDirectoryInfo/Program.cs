using System;
using System.IO;
using System.Collections.Generic;
namespace Coruse {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\myfolder";

            try {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\temp\newfolder\newfolder");
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

