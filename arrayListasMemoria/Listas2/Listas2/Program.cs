using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'A');

            string s2 = list.FindLast(x => x[0] == 'A');

            int pos1 = list.FindIndex(x => x[0] == 'A');

            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(var obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");

            list.RemoveAt(2);

            list.RemoveRange(2, 2);

            list.RemoveAll(x => x[0] == 'M');


        }
    }
}