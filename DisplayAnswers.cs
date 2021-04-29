using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public static class DisplayAnswers
    {
        public static void DisplayAnswer(Int32 answer)
        {
            Console.WriteLine($"Answer = {answer}");
            Console.WriteLine("");
        }

        public static void DisplayAnswer(int part, string answer)
        {
            Console.WriteLine($"Part{part} answer = {answer}");
            Console.WriteLine("");
        }
    }
}
