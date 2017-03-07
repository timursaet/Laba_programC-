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
            Console.WriteLine("p(1)="+P(1));
           // Console.WriteLine(P(1)-P(t)+(s-t)*P(s-t)-P(1)*P(1)*P(1));


         Console.ReadKey();
        }

        public static double P(double x)
        {
            int k;
            double y, sum;

            k = 0; y = 1; sum = 0;
            while (k<=3) {
                sum = sum + a[k] * y;
                y = y * x;
                k++;
            }

            return sum;
        }
    }
}