//Последовательность a1, a2, a3, … , an-1, an называется пилообразной, если она удовлетворяет одному из следующих условий:
//1) a1 < a2 > a3 < … > an-1 < an
//2) a1 < a2 > a3 < … < an-1 > an
//3) a1 > a2 < a3 > … < an-1 > an
//4) a1 > a2 < a3 > … > an-1 < an
//Дана числовая последовательность. Требуется определить длину самой длинной ее пилообразной непрерывной подпоследовательности.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Exercise_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] Value = Console.ReadLine().Split(' ');

            int[] Value_copy = new int[N];
            for (int i = 0; i < N; i++)
            {
                Value_copy[i] = Int32.Parse(Value[i]);
            }
            int Check;
            int count = 1;
            List<int> Value_1 = new List<int>();
            if (N == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                if (N == 2)
                {
                    if (Value_copy[0] == Value_copy[1])
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(2);
                    }
                }
                if (N >= 3)
                {
                    for (int i = 1; i < N - 1; i++)
                    {
                        Check = (Value_copy[i + 1] - Value_copy[i]) * (Value_copy[i] - Value_copy[i - 1]);
                        if (Check < 0)
                        {
                            count++;
                            Value_1.Add(count + 1);
                        }
                        if ((Check == 0) | (Check > 0))
                        {
                            Value_1.Add(count);
                            count = 1;
                        }
                    }
                    Console.WriteLine(Value_1.Max());
                }
            }
        }
    }
}
