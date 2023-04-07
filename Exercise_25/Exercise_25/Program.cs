//Одна из основных операций с числами – их сравнение. Мы подозреваем, что вы в совершенстве
//владеете этой операцией и можете сравнивать любые числа, в том числе и целые.
//В данной задаче необходимо сравнить два целых числа.

using System;

namespace Exercise_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            A = int.Parse(Console.ReadLine());
            int B;
            B = int.Parse(Console.ReadLine());
            if (A < B)
            {
                Console.WriteLine("<");
            }
            if (A > B)
            {
                Console.WriteLine(">");
            }
            if (A == B)
            {
                Console.WriteLine("=");
            }
        }
    }
}
