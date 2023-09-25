using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblems
{
    internal class DownTrianglePattern
    {
        public void  TrianglePattern()
        {
            Console.WriteLine("Enter number of Rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
