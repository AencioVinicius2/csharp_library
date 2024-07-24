using System;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string path = @"c:C:\Users\aenpv\OneDrive\Área de Trabalho\file1.txt";
            StreamReader sr = null;

            try {
                sr = new StreamReader(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            } 
            finally {
                if (sr != null) sr.Close();
            }
        }
    }
}