//Всем известно, что дачники – народ странный, почти такой же, как и программисты. Строят они свои дачи непонятно где, да и выращивают 
//там непонятно что и непонятно зачем. А уж как они туда добираются, это другая история: кто на автобусе, кто на электричке, 
//кто на автомобиле, ну а кто-то вовсе пешком ходит от дома и до самого участка. Так что не стоит удивляться, если вдруг 
//Вы узнаете, что некое садоводческое товарищество располагается на острове, а дачники добираются до него самолетом. 
//Да еще и на этом острове может не быть посадочной полосы, так что высадиться на остров можно, только прыгая с парашютом 
//(мы уж не рассматриваем то, как они возвращаются с дач домой). Рассмотрим этот уникальный случай. Пилот всегда старается осуществить 
//высадку парашютистов таким образом, чтобы дачники приземлялись как можно ближе к своим прямоугольным участкам. 
//Пилоту интересно знать: сколько дачников приземлится на свои участки? Помогите ему решить эту задачу!

using System;

namespace Exercise_12
{
    internal class Program
    {
        public static double Straightlength(double x1, double y1, double x2, double y2)
        {
            double S;
            S = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return S;
        }
        public static double Area(double x1, double y1, double x2, double y2, double x0, double y0)
        {
            double Area;
            Area = 0.5 * Math.Abs((x1 - x0) * (y2 - y0) - (x2 - x0) * (y1 - y0));
            return Area;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matr = new int[N, 10];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                string[] nums = Console.ReadLine().Split();

                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = int.Parse(nums[j]);
                }
            }
            double S1;
            double S2;
            double S3;
            double S4;
            double S5;
            double Ssum;
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                S1 = Straightlength(matr[i, 2], matr[i, 3], matr[i, 4], matr[i, 5]) * Straightlength(matr[i, 4], matr[i, 5], matr[i, 6], matr[i, 7]);
                S2 = Area(matr[i, 2], matr[i, 3], matr[i, 4], matr[i, 5], matr[i, 0], matr[i, 1]);
                S3 = Area(matr[i, 4], matr[i, 5], matr[i, 6], matr[i, 7], matr[i, 0], matr[i, 1]);
                S4 = Area(matr[i, 6], matr[i, 7], matr[i, 8], matr[i, 9], matr[i, 0], matr[i, 1]);
                S5 = Area(matr[i, 8], matr[i, 9], matr[i, 2], matr[i, 3], matr[i, 0], matr[i, 1]);
                Ssum = S2 + S3 + S4 + S5;
                if (Math.Abs(S1 - Ssum) < 0.00001)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
