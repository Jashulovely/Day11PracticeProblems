using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblems
{
    internal class FrequencyCount
    {
        public void Frequency()
        {
            int i, j, count, num;
            int[] arr = new int[100];
            int[] frequency = new int[100];
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                frequency[i] = -1;
            }
            for (i = 0; i < num; i++)
            {
                count = 1;
                for (j = i + 1; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        frequency[j] = 0;
                    }
                }
                if (frequency[i] != 0)
                {
                    frequency[i] = count;
                }
            }
            Console.WriteLine("\nFrequency of all elements of array : \n");
            for (i = 0; i < num; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(arr[i] + " occurs " + frequency[i] + " times");
                }
            }
        }
    }
}
