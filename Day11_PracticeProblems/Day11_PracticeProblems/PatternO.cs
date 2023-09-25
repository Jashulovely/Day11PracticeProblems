using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblems
{
    internal class PatternO
    {
        public void GetZeroPattern()
        {
            int row, column;

            Console.WriteLine("Enter the number of rows : ");
            int num = int.Parse(Console.ReadLine());

            for (row = 1; row <= num; row++)
            {
                for (column = 1; column <= num; column++)
                {
                    if (row == 1 || row == num || column == 1 || column == num)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

        }
    }
}
