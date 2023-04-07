//На уроках информатики вас, наверное, учили переводить числа из одних систем счисления в другие и 
//выполнять другие подобные операции. Пришло время продемонстрировать эти знания. Найдите количество
//единиц в двоичной записи заданного числа.

using System;

namespace Exercise_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int sum = 0;

            while (N > 0)
            {
                sum = sum + N % 2;
                N = N / 2;
            }
            Console.WriteLine(sum);
        }
    }
}
