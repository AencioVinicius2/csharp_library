using System;
using System.IO;

namespace Course { 
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"c:\file1.txt";
            string targetPath = @"c:\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            } 
            catch (Exception e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}