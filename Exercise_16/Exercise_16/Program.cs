//Лесенкой называется набор кубиков, в котором каждый более верхний слой содержит кубиков меньше, чем предыдущий. 
//Требуется написать программу, вычисляющую число лесенок, которое можно построить из N кубиков.

using System;

namespace Exercise_16
{
    internal class Program
    {
        static int get_count(int prev_level, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            int count = 0;
            for (int level = 1; level < prev_level; ++level)
            {
                if ((n - level) < 0)
                    break;
                count += get_count(level, n - level);
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(get_count(n + 1, n));
        }
    }
}
