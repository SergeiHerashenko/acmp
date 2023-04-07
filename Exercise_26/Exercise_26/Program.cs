//На плоскости даны две окружности. Требуется проверить, имеют ли они хотя бы одну общую точку.

using System;

namespace Exercise_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Value_Circle_1 = Console.ReadLine().Split(' ');
            string[] Value_Circle_2 = Console.ReadLine().Split(' ');

            int X1 = Int32.Parse(Value_Circle_1[0]);
            int Y1 = Int32.Parse(Value_Circle_1[1]);
            int R1 = Int32.Parse(Value_Circle_1[2]);

            int X2 = Int32.Parse(Value_Circle_2[0]);
            int Y2 = Int32.Parse(Value_Circle_2[1]);
            int R2 = Int32.Parse(Value_Circle_2[2]);

            double Radius_all = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            if ((R1 + R2 >= Radius_all) & (R1 + Radius_all >= R2) & (R2 + Radius_all >= R1))
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
