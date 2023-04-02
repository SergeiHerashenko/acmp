// Главный вождь племени Абба не умеет считать. В обмен на одну из его земель вождь другого племени предложил ему выбрать одну из трех куч с золотыми монетами. 
// Но вождю племени Абба хочется получить наибольшее количество золотых монет. Помогите вождю сделать правильный выбор!

using System;

namespace Exercise_7
{
    internal class Program
    {
        static string MAX(string a, string b)
        {
            int x = a.Length;
            int y = b.Length;
            if (x != y)
                return (x > y) ? a : b;
            else
            {
                for (int i = 0; i < x; i++)
                {
                    if (a[i] > b[i])
                        return a;
                    else
                        if (a[i] < b[i])
                        return b;
                }
            }
            return b;
        }

        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            string max;
            max = MAX(s[0], MAX(s[1], s[2]));
            Console.WriteLine(max);
        }
    }
}
