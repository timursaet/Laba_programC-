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
            int m, i, max;
            double a, eps, s, x, f;
             Console.WriteLine("Введите m");  m = (int) Console.Read();
             Console.WriteLine("Введите eps");  eps = (int)Console.Read();
             Console.WriteLine("Введите max"); max = (int)Console.Read();
             Console.WriteLine("Введите x"); x = (int)Console.Read();

            f = 1;
            for (i = 1; i < m; i++) {
                f = f / (1-x);
            }
            a = 1; s = a; i = 0;
                while((Math.Abs(a)>eps) & (i<=max)) {
                 a = -a * x * (-m - 1) / (i + 1);
                 s = s + a;
                 i++;
            }
            if (i > max) Console.WriteLine("Нет сходимости");
            else {
                Console.WriteLine("Сумма ряда"+s);
                Console.WriteLine("Количество члена ряда"+i);
                Console.WriteLine("(1-x)^(-"+m+ ")="+f);
            }

            Console.ReadKey();
        }  
    }
}