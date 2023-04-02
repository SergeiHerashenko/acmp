//Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. 
//В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки. 
//Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него троек и сколько четверок. 
//Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

using System;
using System.Collections.Generic;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number_of_days = int.Parse(Console.ReadLine());

            string[] days = Console.ReadLine().Split(' ');
            List<int> Couple_days = new List<int>();
            List<int> Unpaired_days = new List<int>();

            for (int i = 0; i < days.Length; i++)
            {
                if(int.Parse(days[i]) % 2 == 0)
                {
                    Couple_days.Add(int.Parse(days[i]));
                }
                else
                {
                    Unpaired_days.Add(int.Parse(days[i]));
                }
            }

            string Unpaired_days_String = string.Join(" " , Unpaired_days.ToArray());
            string Couple_days_String = string.Join(" ", Couple_days.ToArray());

            Console.WriteLine(Unpaired_days_String);
            Console.WriteLine(Couple_days_String);

            if(Couple_days.Count >= Unpaired_days.Count)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
