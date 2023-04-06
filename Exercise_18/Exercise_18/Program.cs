//Требуется вычислить факториал целого числа N. Факториал обозначают как N! и вычисляют по формуле:
//N! = 1 * 2 * 3 * … * (N-1) * N, причем 0! = 1.
//Так же допустимо рекуррентное соотношение: N! = (N-1)! * N

using System;
using System.Numerics;

namespace Exercise_18
{
    internal class Program
    {
        static public BigInteger Factorial(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            else
            {
                return N * Factorial(N - 1);
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(N));
        }
    }
}
