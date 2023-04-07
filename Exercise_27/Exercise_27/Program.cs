//Известный художник решил написать новый шедевр. После многих дней усердной работы он захотел исследовать свое творение. 
//Художник вспомнил, что картина писалась следующим образом: сначала был взят белый холст, имеющий форму прямоугольника 
//шириной w и высотой h. Затем художник нарисовал на этом холсте n прямоугольников со сторонами, параллельными сторонам 
//холста и вершинами, расположенными в целочисленных координатах. Помогите художнику определить площадь незакрашенной части холста.

using System;

namespace Exercise_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Value = Console.ReadLine().Split(' ');
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[Int32.Parse(Value[0]), Int32.Parse(Value[1])];

            int s = 0;

            for (int i = 0; i < N; i++)
            {
                string[] Value_1 = Console.ReadLine().Split(' ');

                int x1 = Int32.Parse(Value_1[0]);
                int y1 = Int32.Parse(Value_1[1]);
                int x2 = Int32.Parse(Value_1[2]);
                int y2 = Int32.Parse(Value_1[3]);

                for (int j = x1; j < x2; ++j)
                {
                    for (int k = y1; k < y2; ++k)
                    {
                        if (matrix[j, k] == 0)
                        {
                            s++;
                            matrix[j, k] = 1;
                        }
                    }
                }
            }
            Console.WriteLine(Int32.Parse(Value[0]) * Int32.Parse(Value[1]) - s);
        }
    }
}
