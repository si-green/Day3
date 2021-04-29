using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.dataFilePath = @"D:\Users\U.5226074\Documents\advent of code\2015\day3\input.txt"; // put into config for easy access?

            Data.input = DataFileReader.ReadStringDataFile(Data.dataFilePath);

            ISolution solution1 = new Solution1();

            DisplayAnswers.DisplayAnswer(1, solution1.SolveInputString(Data.input));

            ISolution solution2 = new Solution2();

            DisplayAnswers.DisplayAnswer(2, solution2.SolveInputString(Data.input));

            Console.ReadLine();
        }
    }
}
