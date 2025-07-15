using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Maria", "Bob", "Marley"};

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            string s1 = list.Find(x => x[0] == 'A');

            string s2 = list.FindLast(x => x[0] == 'A');

            int pos1 = list.FindIndex(x => x[0] == 'A');

            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            List<string> list2 = list.FindAll(x => x.Length == 5);


        }
    }
}