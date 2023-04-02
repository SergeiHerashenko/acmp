// Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.

using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int Sum = 0;

            if(Number == 0)
            {
                Console.WriteLine(1);
            }

            if(Number > 0)
            {
                for(int i = 1; i <= Number; i++)
                {
                    Sum += i;
                }

                Console.WriteLine(Sum);
            }

            if(Number < 0)
            {
                for(int j = Number; j <= 1; j++)
                {
                    Sum += j;
                }

                Console.WriteLine(Sum);
            }

        }
    }
}
