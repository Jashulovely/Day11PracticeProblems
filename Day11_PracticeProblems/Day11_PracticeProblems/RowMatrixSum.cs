using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblems
{
    internal class RowMatrixSum
    {
        int i, j, m, n;
        int[,] a = new int[20, 20];
        public void GetMatrix()
        {
            Console.WriteLine("Enter The Number of Rows : ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Number of Columns : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void RowSum()
        {
            int r;
            for (i = 1; i <= m; i++)
            {
                r = 0;
                for (j = 1; j <= n; j++)
                {
                    r = r + a[i, j];
                }
                Console.WriteLine("{0} Row Sum : {1}", i, r);
            }
            Console.WriteLine();
        }
    }
}
