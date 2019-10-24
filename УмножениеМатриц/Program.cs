using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УмножениеМатриц
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы 1 :");
            var M = Console.ReadLine();
            int[,] a = new int[100, 100];
            int m, i, j;
            while (!int.TryParse(M, out m))
            {
                Console.WriteLine("Ошибка ввода!");
                M = Console.ReadLine();
            }
            Console.WriteLine("Введите количество cтолбцов матрицы 1 :");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Ошибка ввода!");
                N = Console.ReadLine();
            }
            Console.WriteLine("Введите матрицу 1 :");
            /*for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }*/
            a = vvod(m, n);
            Console.WriteLine("<||||||||||||||||||||||||||||||||||||>");
            Console.WriteLine("Введите количество строк матрицы 2 :");
            var A1 = Console.ReadLine();
            int[,] b = new int[100, 100];
            int a1;
            while (!int.TryParse(A1, out a1))
            {
                Console.WriteLine("Ошибка ввода!");
                A1 = Console.ReadLine();
            }
            Console.WriteLine("Введите количество cтолбцов матрицы 2 :");
            var B1 = Console.ReadLine();
            int b1;
            while (!int.TryParse(B1, out b1))
            {
                Console.WriteLine("Ошибка ввода!");
                B1 = Console.ReadLine();
            }
            Console.WriteLine("Введите матрицу 2:");
            /*for (i = 0; i < a1; i++)
            {
                for (j = 0; j < b1; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }*/
            b = vvod(a1, b1);
            Console.WriteLine("<||||||||||||||||||||||||||||||||||||>");
            int maxa = a[0, 0];
            int max = maxa;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] > maxa)
                        maxa = a[i, j];
                    if (a[i, j] > max)
                        max = a[i, j];
                }
                Console.WriteLine($"Максимальное число строки {i + 1} матрицы 1: {maxa}");
                maxa = a[i + 1, 0];
            }
            Console.WriteLine($"Максимальное число матрицы 1: {max}");
            max = b[0, 0];
            Console.WriteLine("<||||||||||||||||||||||||||||||||||||>");
            int maxb = b[0, 0];
            for (i = 0; i < a1; i++)
            {
                for (j = 0; j < b1; j++)
                {
                    if (b[i, j] > maxb)
                        maxb = b[i, j];
                    if (b[i, j] > max)
                        max = b[i, j];
                }
                Console.WriteLine($"Максимальное число строки {i + 1} матрицы 2: {maxb}");
                maxb = b[i + 1, 0];
            }
            Console.WriteLine($"Максимальное число матрицы 2: {max}");
            Console.WriteLine("<||||||||||||||||||||||||||||||||||||>");
            if (n != a1)
            {
                Console.WriteLine("Невозможно умножить!");
                Environment.Exit(0);
            }
            Console.WriteLine("Результат умножения: ");
            /*for (i = 0; i < m; i++)
            {
                for (j = 0; j < b1; j++)
                {

                    for (k = 0; k < a1; k++)
                    {
                        s += a[i, k] * b[k, j];
                    }
                    Console.WriteLine($"{s}");
                    s = 0;
                }
            }*/
            ymnoz(a, b, m, b1, a1);


        }
        public static int[,] vvod(int x, int y)
        {
            int[,] b = new int[100, 100];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            return b;
        }
        public static void ymnoz(int[,] a, int[,] b, int m, int b1, int a1)
        {
            int s = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < b1; j++)
                {

                    for (int k = 0; k < a1; k++)
                    {
                        s += a[i, k] * b[k, j];
                    }
                    Console.WriteLine($"{s}");
                    s = 0;
                }
            }
        }
    }
}
