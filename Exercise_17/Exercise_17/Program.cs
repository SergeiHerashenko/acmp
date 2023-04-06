//Для игры в «Поле чудес» используется круглый барабан, разделенный на сектора, и стрелка. В каждом секторе записано некоторое число. 
//В различных секторах может быть записано одно и то же число. Однажды ведущий игры решил изменить правила. Он сам стал вращать 
//барабан и называть игроку (который барабана не видел) все числа подряд в том порядке, в котором на них указывала стрелка в процессе 
//вращения барабана. Получилось так, что барабан сделал целое число оборотов, то есть последний сектор совпал с первым. После этого, 
//ведущий задал участнику вопрос: какое наименьшее число секторов может быть на барабане? Требуется написать программу, отвечающую на этот вопрос ведущего.

using System;
using System.Collections.Generic;

namespace Exercise_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] Value = new int[N - 1];
            string[] Sector_value = Console.ReadLine().Split(' ');

            for (int i = 0; i < N - 1; i++)
            {
                Value[i] = Int32.Parse(Sector_value[i]);
            }

            List<int> Value_copy = new List<int>();

            string Stroka = string.Join("", Value);
            N = N - 1;
            for (int i = 0; i < N; i++)
            {
                Value_copy.Add(Value[i]);
                if (N % (i + 1) == 0)
                {

                    string Stroka_copy = string.Join("", Value_copy);

                    int index = (Stroka.Length - Stroka.Replace(Stroka_copy, "").Length) / Stroka_copy.Length;

                    if (Stroka.Length == Stroka_copy.Length * index)
                    {
                        int K = (Stroka.Length - Stroka.Replace(Stroka_copy, "").Length) / Stroka_copy.Length;
                        if (Stroka.Length == Stroka_copy.Length * K)
                        {
                            int Min;
                            Min = (int)(N / K);
                            Console.WriteLine(Min);
                            break;
                        }
                    }
                }
            }
        }
    }
}
