using System;

namespace Course
{
    class Calculadora
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
