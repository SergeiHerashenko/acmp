//Требуется написать программу, определяющую наименьшее общее кратное (НОК) чисел a и b.

using System;

namespace Exercise_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int x1 = int.Parse(s[1]);
            int a = x;
            int b = x1;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            double NOD = a + b;
            double NOK = (x * x1) / (NOD);
            Console.WriteLine(NOK);
        }
    }
}
