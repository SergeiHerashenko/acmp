//В нашем зоопарке появился заяц. Его поместили в клетку, и чтобы ему не было скучно, директор зоопарка распорядился поставить в его клетке лесенку. 
//Теперь наш зайчик может прыгать по лесенке вверх, перепрыгивая через ступеньки. Лестница имеет определенное количество ступенек N. 
//Заяц может одним прыжком преодолеть не более К ступенек. Для разнообразия зайчик пытается каждый раз найти новый путь к вершине лестницы. 
//Директору любопытно, сколько различных способов есть у зайца добраться до вершины лестницы при заданных значениях K и N. 
//Помогите директору написать программу, которая поможет вычислить это количество. Например, если K=3 и N=4, то существуют следующие 
//маршруты: 1+1+1+1, 1+1+2, 1+2+1, 2+1+1, 2+2, 1+3, 3+1. Т.е. при данных значениях у зайца всего 7 различных маршрутов добраться до вершины лестницы.

using System;

namespace Exercise_11
{
    internal class Program
    {
        public static void Main()
        {
            int k;
            int n;
            InputData(out k, out n);
            var result = Solve(k, n);
            PrintResult(result);
        }
        private static void InputData(out int k, out int n)
        {
            var input = Console.ReadLine().Split();
            k = int.Parse(input[0]);
            n = int.Parse(input[1]);
        }
        public static string Solve(int k, int n)
        {
            byte[][] Array_1 = new byte[n + 1][];
            Array_1[0] = new byte[] { 1 };
            for (int i = 1; i <= n; i++)
            {
                Array_1[i] = new byte[] { 0 };
                for (int j = i - k > 0 ? i - k : 0; j < i; j++)
                    Array_1[i] = Sum(Array_1[i], Array_1[j]);
            }
            string output = String.Empty;
            for (int i = Array_1[n].Length - 1; i >= 0; i--)
                output += Array_1[n][i];
            return output;
        }
        private static void PrintResult(string result)
        {
            Console.Write(result);
        }
        private static byte[] Sum(byte[] a, byte[] b)
        {
            int maxLength = Math.Max(a.Length, b.Length);
            byte[] ch1 = new byte[maxLength], ch2 = new byte[maxLength], output = new byte[maxLength];
            byte k, p = 0;
            a.CopyTo(ch1, 0);
            b.CopyTo(ch2, 0);
            for (int i = 0; i < maxLength; i++)
            {
                k = (byte)(ch1[i] + ch2[i] + p);
                if (k > 9)
                {
                    p = 1;
                    output[i] = (byte)(k % 10);
                }
                else
                {
                    p = 0;
                    output[i] = k;
                }
            }
            if (p == 1)
            {
                byte[] temp = new byte[maxLength + 1];
                output.CopyTo(temp, 0);
                temp[maxLength] = 1;
                return temp;
            }
            return output;
        }
    }
}
