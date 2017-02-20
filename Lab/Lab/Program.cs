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
            int x, y;
            Console.WriteLine("Введите кординаты точек x и y");
            x = (int) Console.Read();
            y = (int)Console.Read();
            if (((x >= -2) & (x <= -1) & (y >= 0) & (y <= 1)) |
              ((x >= 1) & (x <= 2) & (y >= -2) & (y <= 2)) | ((x >= 1) & (x <= 2) & (y >= 0) & (y <= 1)))
            {
                Console.WriteLine("Точка пренадлежит данной области");
            }
            else Console.WriteLine("Точка не пренадлежит данной области");


         Console.ReadKey();
        }  
    }
}