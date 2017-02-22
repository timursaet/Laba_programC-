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
            int[] a = new int[100];

            int i, k;

            Console.WriteLine("Введите n и z");
            int n = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Random b = new Random();
            for (i = 1; i < n; i++)
            {
                a[i] = b.Next(30);
                Console.Write(a[i] + " ");
            }
            k = 0; Console.WriteLine();
            for (i = 1; i < n; i++)
            {
                if (a[i] > z)
                {
                    a[i] = z; k++;
                }
            }
            for (i = 1; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество замен: "+k);

            Console.ReadKey();
        }  
    }
}
