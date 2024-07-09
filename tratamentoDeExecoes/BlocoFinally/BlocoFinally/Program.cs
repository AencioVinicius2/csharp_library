using System;

namespace Course {
    class Program {
        static void main(string[] args) {
            FileStream fs = null;

            try {
                fs = new FileStream("@C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.Message);
            }
            finally {
                if (fs != null) {
                    fs.Close();
                }
            }
        }
    }
}