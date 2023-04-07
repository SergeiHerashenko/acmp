//Многие из вас, вероятно, знакомы с понятием симметрии относительно прямой. Пусть на плоскости расположена прямая L и точка A. 
//Точка B называется симметричной точке A относительно прямой L, если отрезок АВ перпендикулярен прямой L и делится пополам 
//точкой пересечения с ней. В частности, если точка А лежит на прямой L, то точка B совпадает с точкой А.
//Задана прямая L, параллельная одной из осей координат, и точка А. Найдите точку В, симметричную А относительно L.

using System;

namespace Exercise_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Value_Straight = Console.ReadLine().Split(' ');
            string[] Value_Point = Console.ReadLine().Split(' ');
            int x_b;
            int y_b;

            int x_Point = Int32.Parse(Value_Point[0]);
            int y_Point = Int32.Parse(Value_Point[1]);

            int x1_Straight = Int32.Parse(Value_Straight[0]);
            int y1_Straight = Int32.Parse(Value_Straight[1]);
            int x2_Straight = Int32.Parse(Value_Straight[2]);
            int y2_Straight = Int32.Parse(Value_Straight[3]);

            if (x1_Straight == x2_Straight)
            {
                int x = 0 - x1_Straight;
                int x_Point_new = x_Point + x;
                x_b = -x_Point_new + Math.Abs(x);
                y_b = y_Point;
                Console.WriteLine("{0} {1}", x_b, y_b);
            }

            if (y1_Straight == y2_Straight)
            {
                int y = 0 - y1_Straight;
                int y_Point_new = y_Point + y;
                y_b = -y_Point_new + Math.Abs(y);
                x_b = x_Point;
                Console.WriteLine("{0} {1}", x_b, y_b);
            }
        }
    }
}
