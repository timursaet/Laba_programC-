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
            int n;
            int x, max, min;

            Console.WriteLine("Введите число");
            n = (int) Console.Read();

            min = 9; max = 0;

            while (n>0) {
                x =n % 10;
                n = n / 10;
                if (x < min) min = x;
                if (x > max) max = x;
            }

            Console.WriteLine("Наибольшая цифра"+max);
            Console.WriteLine("Наименьшая цифра" + min);

            Console.ReadKey();
        }  
    }
}