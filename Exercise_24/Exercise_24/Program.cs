//Король Флатландии решил вырубить некоторые деревья, растущие перед его дворцом. Деревья перед дворцом короля посажены 
//в ряд, всего там растет n деревьев, расстояния между соседними деревьями одинаковы.
//После вырубки перед дворцом должно остаться m деревьев, и расстояния между соседними деревьями должны быть одинаковыми. 
//Помогите королю выяснить, сколько существует способов вырубки деревьев.
//Требуется написать программу, которая по заданным числам n и m определит, сколько существует способов вырубки некоторых 
//из n деревьев так, чтобы после вырубки осталось m деревьев и соседние деревья находились на равном расстоянии друг от друга.

using System;

namespace Exercise_24
{
    internal class Program
    {
        static int Variant(int all_trees, int trees_remaining)
        {
            if (0 == trees_remaining)
            {
                return 1;
            }
            if (1 == trees_remaining)
            {
                return all_trees;
            }
            if (all_trees < trees_remaining)
            {
                return 0;
            }

            int variant = 0;

            for (int distanse = 0; true; distanse++)
            {
                int usedPositions = trees_remaining + distanse * (trees_remaining - 1);
                if (usedPositions > all_trees)
                {
                    break;
                }
                variant += all_trees - usedPositions + 1;
            }
            return variant;
        }
        static void Main(string[] args)
        {

            string[] Value = Console.ReadLine().Split(' ');

            Console.WriteLine(Variant(Int32.Parse(Value[0]), Int32.Parse(Value[1])));
        }
    }
}
