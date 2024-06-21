using System;

namespace Course
{
    class Calculator
    {
       public static int Sum(params int[] numbers) 
       {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
       }
    }
}
