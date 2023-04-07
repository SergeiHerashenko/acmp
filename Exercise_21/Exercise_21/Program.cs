//В отделе работают 3 сотрудника, которые получают заработную плату в рублях. Требуется определить: на сколько зарплата самого 
//высокооплачиваемого из них отличается от самого низкооплачиваемого.

using System;

namespace Exercise_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Value = Console.ReadLine().Split(' ');
            int max;
            int min = 0;

            int[] Value_copy = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                Value_copy[i] = Int32.Parse(Value[i]);
            }

            max = Math.Max(Value_copy[0], Value_copy[1]);
            int MAX = Math.Max(max, Value_copy[2]);

            min = Math.Min(Value_copy[0], Value_copy[1]);
            int MIN = Math.Min(min, Value_copy[2]);

            Console.WriteLine(MAX - MIN);
        }
    }
}
