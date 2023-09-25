using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day11_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool interested = true;
            while (interested)
            {
                Console.WriteLine("Enter your choice.\n   1   -->   Reverse String.\n   2   -->   Sum Of Digits in given number.\n" +
                    "   3   -->   Row matrix sum.\n   4   -->   Down Triangle Pattern.\n   0   -->   QUIT");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ReverseEachWord reverseEachWord = new ReverseEachWord();
                        reverseEachWord.RevString();
                        Console.ReadLine();
                        break;
                    case 2:
                        DigitsSum digitsSum = new DigitsSum();
                        digitsSum.SumOfDigits();
                        Console.ReadLine();
                        break;
                    case 3:
                        RowMatrixSum rowMatrixSum = new RowMatrixSum();
                        rowMatrixSum.GetMatrix();
                        rowMatrixSum.RowSum();
                        Console.ReadLine(); 
                        break;
                    case 4:
                        DownTrianglePattern downTrianglePattern = new DownTrianglePattern();
                        downTrianglePattern.TrianglePattern();
                        Console.ReadLine();
                        break;
                    case 0:
                        interested = false;
                        Console.WriteLine("Thanks for your interest.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
