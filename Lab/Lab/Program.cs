using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, m, tmp;
            int max, iPos, jPos;
            int[,] a = new int[100,100];

            Console.WriteLine("Введите размерность массива");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Random b = new Random();

            max = 0;
            Console.WriteLine("Исходная матрица");
            for (i = 1; i < n; i++) {
                for (j = 1; j < m; j++) {
                    a[i, j] = b.Next(30);
                    if (a[i, j] > max) {
                        max = a[i,j]; iPos = i; jPos = j;
                    }
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элемент находится на a["+iPos+","+jPos+"]="+max);
            for (i = 1; i < n; i++) {
                tmp = a[i, 1]; a[i, 1] = a[i, jPos]; a[i, jPos] = tmp;
            }
            for (j = 1; i < n; j++)
            {
                tmp = a[1, j]; a[1, j] = a[iPos, j]; a[iPos,j] = tmp;
            }
            Console.WriteLine("Результат матрицы");
            for (i = 1; i < n; i++) {
                for (j = 1; j < m; j++) {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }  
    }
}