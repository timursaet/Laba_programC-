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
            const int n = 10;
            const int m = 10;
            int[][] a = new int [n][m];
            int i, j;
            for (i = 1; i < n; i++)
                for (j = 1; j < n; j++) {
                    a[i][j] = 1;
                }
            for (i = 2; i < n - 1; i++) {
                a[i][1] = 0; a[i][n] = 0;
            }
            for (i = 1; i < n; i++) {
                for (j = 1; j < m; j++)
                    Console.WriteLine(a[i][j]);
                Console.ReadLine();
            }
            Console.ReadKey();
        }  
    }
}