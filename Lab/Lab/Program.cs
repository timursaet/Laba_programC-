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
            int[] a = new int[3];
            int i, t, s;
            double z;
            Random b = new Random();
                for (i=1;i<=3;i++) {
                    a[i] = b.Next(2);
                Console.WriteLine(a[i]);
                }
            Console.WriteLine("Введите s и t");
            s = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());


         Console.ReadKey();
        }  
    }
}