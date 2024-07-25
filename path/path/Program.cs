using System;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator) ;
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); ;
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempoPath: " + Path.GetTempPath());
        }
    }
}