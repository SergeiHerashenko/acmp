﻿//Вы можете вспомнить хоть одного своего знакомого до двадцатилетнего возраста, который в детстве не играл в компьютерные игры? 
//Если да, то может быть вы и сами не знакомы с этим развлечением? Впрочем, трудностей при решении этой задачи это создать не должно.
//Во многих старых играх с двумерной графикой можно столкнуться с подобной ситуацией. Какой-нибудь герой прыгает по платформам 
//(или островкам), которые висят в воздухе. Он должен перебраться от одного края экрана до другого. При этом при прыжке с одной 
//платформы на соседнюю, у героя уходит |y2-y1| единиц энергии, где y1 и y2 – высоты, на которых расположены эти платформы.
//Кроме того, у героя есть суперприем, который позволяет перескочить через платформу, но на это затрачивается 3*|y3-y1| единиц энергии. 
//Конечно же, энергию следует расходовать максимально экономно.
//Предположим, что вам известны координаты всех платформ в порядке от левого края до правого. Сможете ли вы найти, какое 
//минимальное количество энергии потребуется герою, чтобы добраться с первой платформы до последней?

using System;
using System.Collections.Generic;

namespace Exercise_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] value = Console.ReadLine().Split(' ');

            int[] Value_copy = new int[N];

            for (int i = 0; i < N; i++)
            {
                Value_copy[i] = Int32.Parse(value[i]);
            }

            List<int> Value_energi = new List<int>();

            if (N == 1)
            {
                Console.WriteLine(0);
            }
            if (N > 1)
            {
                Value_energi.Add(0);
                Value_energi.Add(Math.Abs(Value_copy[1] - Value_copy[0]));

                for (int i = 2; i < N; i++)
                {

                    Value_energi.Add((Math.Min(Math.Abs(Value_copy[i] - Value_copy[i - 1]) + Value_energi[i - 1], 3 * Math.Abs(Value_copy[i] - Value_copy[i - 2]) + Value_energi[i - 2])));
                }
                Console.WriteLine(Value_energi[N - 1]);
            }
        }
    }
}