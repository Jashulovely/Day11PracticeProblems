using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblems
{
    internal class MaxAndMin
    {
        public void MaxMin()
        {
            Console.Write("How many numbers do you want to store in array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}:  ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (min > numbers[i]) min = numbers[i];
                if (max < numbers[i]) max = numbers[i];
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("The minimum is: {0}", min);
            Console.WriteLine("The maximum is: {0}", max);
        }
    }
}
