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

            int i, n, z, k;

            Console.WriteLine("Введите n и z");
            n = (int)Console.Read();
            z = (int)Console.Read();
            Random b = new Random();
            for (i = 1; i < n; i++) {
                a[i] = b.Next(30);
                Console.Write(a[i]+' ');
            }
            k = 0;
            for (i = 1; i < n; i++) {
                if (a[i] > z) {
                    a[i] = z; k++;
                }
            }
            for (i = 1; i < n; i++)
            {
                Console.Write(a[i]+' '); 
            }
            Console.WriteLine("Количество замен: ", k);

            Console.ReadKey();
        }  
    }
}