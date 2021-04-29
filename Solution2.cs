using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day3
{
    public class Solution2 : ISolution
    {
        public Dictionary<Tuple<int, int>, int> Houses;

        public Solution2()
        {
            Houses = new Dictionary<Tuple<int, int>, int>();
        }

        public string SolveInputString(string input)
        {
            string answer = VisitHouses(input).ToString();

            return answer;
        }

        private int VisitHouses(string input)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int x1 = 0;
            int y1 = 0;
            Tuple<int, int> house1 = new Tuple<int, int>(x1, y1);

            int x2 = 0;
            int y2 = 0;
            Tuple<int, int> house2;

            // set house 0
            Houses.Add(house1, 1);
            Houses[house1] += 1;

            for (int i = 0; i < input.Length; i += 2)
            {
                switch (input[i])
                {
                    case '<':
                        x1--;
                        break;

                    case '>':
                        x1++;
                        break;

                    case 'v':
                        y1--;
                        break;

                    case '^':
                        y1++;
                        break;

                    default:
                        break;
                }

                house1 = new Tuple<int, int>(x1, y1);

                if (Houses.ContainsKey(house1))
                {
                    Houses[house1] += 1;
                }
                else
                {
                    Houses.Add(house1, 1);
                }

                switch (input[i+1])
                {
                    case '<':
                        x2--;
                        break;

                    case '>':
                        x2++;
                        break;

                    case 'v':
                        y2--;
                        break;

                    case '^':
                        y2++;
                        break;

                    default:
                        break;
                }

                house2 = new Tuple<int, int>(x2, y2);

                if (Houses.ContainsKey(house2))
                {
                    Houses[house2] += 1;
                }
                else
                {
                    Houses.Add(house2, 1);
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            return Houses.Count;
        }
    }
}
