//Петя успевает по математике лучше всех в классе, поэтому учитель задал ему сложное домашнее задание, 
//в котором нужно в заданном наборе целых чисел найти сумму всех положительных элементов, затем найти где в заданной 
//последовательности находятся максимальный и минимальный элемент и вычислить произведение чисел, расположенных 
//в этой последовательности между ними. Так же известно, что минимальный и максимальный элемент встречаются в заданном 
//множестве чисел только один раз и не являются соседними. Поскольку задач такого рода учитель дал Пете около ста, то 
//Петя как сильный программист смог написать программу, которая по заданному набору чисел самостоятельно находит решение. А Вам слабо?

using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int max;
            int min;
            int sum = 0;
            int dobutok = 1;
            int imax = 0;
            int imin = 0;
            N = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] Array_1 = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                Array_1[i] = Int32.Parse(s[i]);
            }
            max = Array_1[0];
            min = Array_1[0];
            for (int i = 0; i < N; i++)
            {
                if (Array_1[i] > max)
                {
                    max = Array_1[i];
                    imax = i;
                }
                if (Array_1[i] < min)
                {
                    min = Array_1[i];
                    imin = i;
                }
                if (Array_1[i] > 0)
                {
                    sum += Array_1[i];
                }
            }
            if (imin < imax)
            {

                for (int i = imin + 1; i < imax; i++)
                    dobutok = dobutok * Array_1[i];
            }
            else
            {
                for (int i = imax + 1; i < imin; i++)
                {
                    dobutok = dobutok * Array_1[i];
                }
            }
            Console.WriteLine("{0} {1}", sum, dobutok);
        }
    }
}
