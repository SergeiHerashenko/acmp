//Петя очень любит наблюдать за электронными часами. Он целыми днями смотрел на часы и считал, сколько раз встречается каждая цифра. 
//Через несколько месяцев он научился по любому промежутку времени говорить, сколько раз на часах за это время встретится каждая цифра, и очень гордился этим.
//Вася решил проверить Петю, но он не знает, как это сделать. Вася попросил Вас помочь ему. Напишите программу, решающую эту задачу.

using System;

namespace Exercise_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Time_1 = Console.ReadLine().Split(':');
            string[] Time_2 = Console.ReadLine().Split(':');

            int hour_1 = Int32.Parse(Time_1[0]);
            int minute_1 = Int32.Parse(Time_1[1]);
            int second_1 = Int32.Parse(Time_1[2]);

            int hour_2 = Int32.Parse(Time_2[0]);
            int minute_2 = Int32.Parse(Time_2[1]);
            int second_2 = Int32.Parse(Time_2[2]);

            int sum_1 = hour_1 * 3600 + minute_1 * 60 + second_1;
            int sum_2 = hour_2 * 3600 + minute_2 * 60 + second_2;

            int a0 = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int a6 = 0;
            int a7 = 0;
            int a8 = 0;
            int a9 = 0;

            int sum;

            while (sum_1 <= sum_2)
            {
                sum = sum_1;

                hour_1 = sum / 3600;
                minute_1 = (sum - (hour_1 * 3600)) / 60;
                second_1 = sum - ((hour_1 * 3600) + (minute_1 * 60));
                if (hour_1 % 10 == 0)
                {
                    a0++;
                }
                if (hour_1 % 10 == 1)
                {
                    a1++;
                }
                if (hour_1 % 10 == 2)
                {
                    a2++;
                }
                if (hour_1 % 10 == 3)
                {
                    a3++;
                }
                if (hour_1 % 10 == 4)
                {
                    a4++;
                }
                if (hour_1 % 10 == 5)
                {
                    a5++;
                }
                if (hour_1 % 10 == 6)
                {
                    a6++;
                }
                if (hour_1 % 10 == 7)
                {
                    a7++;
                }
                if (hour_1 % 10 == 8)
                {
                    a8++;
                }
                if (hour_1 % 10 == 9)
                {
                    a9++;
                }
                if (hour_1 < 10)
                {
                    a0++;
                }
                else
                {
                    if (hour_1 / 10 == 0)
                    {
                        a0++;
                    }
                    if (hour_1 / 10 == 1)
                    {
                        a1++;
                    }
                    if (hour_1 / 10 == 2)
                    {
                        a2++;
                    }
                    if (hour_1 / 10 == 3)
                    {
                        a3++;
                    }
                    if (hour_1 / 10 == 4)
                    {
                        a4++;
                    }
                    if (hour_1 / 10 == 5)
                    {
                        a5++;
                    }
                    if (hour_1 / 10 == 6)
                    {
                        a6++;
                    }
                    if (hour_1 / 10 == 7)
                    {
                        a7++;
                    }
                    if (hour_1 / 10 == 8)
                    {
                        a8++;
                    }
                    if (hour_1 / 10 == 9)
                    {
                        a9++;
                    }
                }
                if (minute_1 % 10 == 0)
                {
                    a0++;
                }
                if (minute_1 % 10 == 1)
                {
                    a1++;
                }
                if (minute_1 % 10 == 2)
                {
                    a2++;
                }
                if (minute_1 % 10 == 3)
                {
                    a3++;
                }
                if (minute_1 % 10 == 4)
                {
                    a4++;
                }
                if (minute_1 % 10 == 5)
                {
                    a5++;
                }
                if (minute_1 % 10 == 6)
                {
                    a6++;
                }
                if (minute_1 % 10 == 7)
                {
                    a7++;
                }
                if (minute_1 % 10 == 8)
                {
                    a8++;
                }
                if (minute_1 % 10 == 9)
                {
                    a9++;
                }
                if (minute_1 < 10)
                {
                    a0++;
                }
                else
                {
                    if (minute_1 / 10 == 0)
                    {
                        a0++;
                    }
                    if (minute_1 / 10 == 1)
                    {
                        a1++;
                    }
                    if (minute_1 / 10 == 2)
                    {
                        a2++;
                    }
                    if (minute_1 / 10 == 3)
                    {
                        a3++;
                    }
                    if (minute_1 / 10 == 4)
                    {
                        a4++;
                    }
                    if (minute_1 / 10 == 5)
                    {
                        a5++;
                    }
                    if (minute_1 / 10 == 6)
                    {
                        a6++;
                    }
                    if (minute_1 / 10 == 7)
                    {
                        a7++;
                    }
                    if (minute_1 / 10 == 8)
                    {
                        a8++;
                    }
                    if (minute_1 / 10 == 9)
                    {
                        a9++;
                    }
                }
                if (second_1 % 10 == 0)
                {
                    a0++;
                }
                if (second_1 % 10 == 1)
                {
                    a1++;
                }
                if (second_1 % 10 == 2)
                {
                    a2++;
                }
                if (second_1 % 10 == 3)
                {
                    a3++;
                }
                if (second_1 % 10 == 4)
                {
                    a4++;
                }
                if (second_1 % 10 == 5)
                {
                    a5++;
                }
                if (second_1 % 10 == 6)
                {
                    a6++;
                }
                if (second_1 % 10 == 7)
                {
                    a7++;
                }
                if (second_1 % 10 == 8)
                {
                    a8++;
                }
                if (second_1 % 10 == 9)
                {
                    a9++;
                }
                if (second_1 < 10)
                {
                    a0++;
                }
                else
                {
                    if (second_1 / 10 == 0)
                    {
                        a0++;
                    }
                    if (second_1 / 10 == 1)
                    {
                        a1++;
                    }
                    if (second_1 / 10 == 2)
                    {
                        a2++;
                    }
                    if (second_1 / 10 == 3)
                    {
                        a3++;
                    }
                    if (second_1 / 10 == 4)
                    {
                        a4++;
                    }
                    if (second_1 / 10 == 5)
                    {
                        a5++;
                    }
                    if (second_1 / 10 == 6)
                    {
                        a6++;
                    }
                    if (second_1 / 10 == 7)
                    {
                        a7++;
                    }
                    if (second_1 / 10 == 8)
                    {
                        a8++;
                    }
                    if (second_1 / 10 == 9)
                    {
                        a9++;
                    }
                }
                sum_1++;
            }
            Console.WriteLine(a0);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
            Console.WriteLine(a7);
            Console.WriteLine(a8);
            Console.WriteLine(a9);
        }
    }
}
