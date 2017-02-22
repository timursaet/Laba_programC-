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
            const int n = 5;
            int[,] a = new int [n+1,n+1];
            int i, j;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++) {
                    a[i,j] = 1;
                }
            for (i = 2; i <= n - 1; i++) {
                a[i,1] = 0; a[i,n] = 0;
            }
            for (i = 1; i <= n; i++) {
                for (j = 1; j <= n; j++)
                {
                    Console.Write(a[i, j]);
                } 
                Console.WriteLine();
            }
            Console.ReadKey();
        }  
    }
}
