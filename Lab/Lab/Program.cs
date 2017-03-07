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
            string s;
            int i;
            Console.WriteLine("Введите строку включая закрывающую и открывающие скобки");
            s = Console.ReadLine();
            for (i=s.IndexOf('(')+1; i<s.IndexOf(')');i++) {
                Console.Write(s[i]);
            }


         Console.ReadKey();
        }  
    }
}