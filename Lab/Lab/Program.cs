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
            int n, f, i;
            double sum;
            Console.WriteLine("Введите N");
            n = (int) Console.Read();
            sum = 0; f = 1;
            for (i = 1; i < n; i++) {
                sum = sum + ((Math.Pow(f, i + 1)) / (i * (i + 1)));
                f = -f;
            }
            Console.WriteLine("Сумма с циклом for = "+sum);
            i = 1; sum = 0; f = 1;
            while (i <= n) {
                sum = sum + ((Math.Pow(f, i + 1)) / (i * (i + 1)));
                f = -f;
                i++;
            }
            Console.WriteLine("Сумма с циклом while = " + sum);
            i = 1; sum = 0; f = 1;
            do {
                sum = sum + ((Math.Pow(f, i + 1)) / (i * (i + 1)));
                f = -f;
                i++;
            }
            while (i<=n);
            Console.WriteLine("Сумма с циклом do while = " + sum);


        Console.ReadKey();
        }  
    }
}