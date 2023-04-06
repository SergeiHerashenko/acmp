//В галактике «Milky Way» на планете «Snowflake» есть N городов, некоторые из которых соединены дорогами.
//Император галактики «Milky Way» решил провести инвентаризацию дорог на планете «Snowflake».
//Но, как оказалось, он не силен в математике, поэтому он просит вас сосчитать количество дорог.
//Требуется написать программу, помогающую императору сосчитать количество дорог на планете «Snowflake».

using System;

namespace Exercise_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int[,] matr = new int[N, N];
            int couter = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = int.Parse(nums[j]);
                    if (nums[j] == "1")
                    {
                        couter++;
                    }
                }
            }
            Console.WriteLine(couter / 2);
        }
    }
}
