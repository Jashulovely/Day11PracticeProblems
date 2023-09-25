using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblems
{
    internal class ReverseEachWord
    {
        public void RevString()
        {
            Console.WriteLine("Enter any sentence.");
            string str = Console.ReadLine();
            string strrev = "";

            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + " ";
            }
            Console.WriteLine(strrev);
        }
    }
}
