﻿using System;
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
                Console.WriteLine("Enter your choice.\n   1   -->   Reverse String.\n" +
                    "   0   -->   QUIT");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ReverseEachWord reverseEachWord = new ReverseEachWord();
                        reverseEachWord.RevString();
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
