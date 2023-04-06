//На шахматной доске 8х8 расположены три фигуры: ферзь, ладья и конь. Требуется определить количество пустых полей доски, которые 
//находятся под боем. Для простоты будем полагать, что фигуры могут «бить» через другие фигуры. 

using System;

namespace Exercise_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Shape_Сoordinates = Console.ReadLine().Split(' ');
            string Stroka = string.Join("", Shape_Сoordinates);

            char[] Array = new char[Stroka.Length];

            for (int i = 0; i < Stroka.Length; i++)
            {
                Array[i] = Stroka[i];
            }

            int[,] Queen = new int[8, 8];

            int Queen_Coordinates_x = Array[0] - 65;
            int Queen_Coordinates_y = Array[1] - 49;

            int Rook_Coordinates_x = Array[2] - 65;
            int Rook_Coordinates_y = Array[3] - 49;

            int Horse_Coordinates_x = Array[4] - 65;
            int Horse_Coordinates_y = Array[5] - 49;

            int count = 0;

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (Math.Abs(Queen_Coordinates_x - j) == Math.Abs(Queen_Coordinates_y - i))
                    {
                        Queen[i, j] = 1;
                    }
                    else
                    {
                        if ((Queen_Coordinates_x == j) | (Queen_Coordinates_y == i))
                        {
                            Queen[i, j] = 1;
                        }
                        else
                        {
                            if ((Rook_Coordinates_x == j) | (Rook_Coordinates_y == i))
                            {
                                Queen[i, j] = 1;
                            }
                            else
                            {
                                if (Math.Abs(Horse_Coordinates_x - j) * Math.Abs(Horse_Coordinates_y - i) == 2)
                                {
                                    Queen[i, j] = 1;
                                }
                            }
                        }
                    }
                }
            }
            Queen[Queen_Coordinates_y, Queen_Coordinates_x] = 0;
            Queen[Rook_Coordinates_y, Rook_Coordinates_x] = 0;
            Queen[Horse_Coordinates_y, Horse_Coordinates_x] = 0;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (Queen[i, j] == 1)
                    {
                        ++count;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
