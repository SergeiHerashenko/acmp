// Требуется сложить два целых числа А и В.

using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Value_Number = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(Value_Number[0]) + int.Parse(Value_Number[1]));
        }
    }
}
