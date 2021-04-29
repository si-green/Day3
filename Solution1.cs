using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public class Solution1 : ISolution
    {
        public Dictionary<Tuple<int, int>, int> Houses;

        public Solution1()
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
            int x = 0;
            int y = 0;
            Tuple<int, int> house = new Tuple<int, int>(x, y);

            // set house 0
            Houses.Add(house, 1);
            Houses[house] += 1;

            foreach (char direction in input)
            {
                switch (direction)
                {
                    case '<':
                        x --;
                        break;

                    case '>':
                        x ++;
                        break;

                    case 'v':
                        y --;
                        break;

                    case '^':
                        y ++;
                        break;

                    default:
                        break;
                }

                house = new Tuple<int, int>(x, y);

                if (Houses.ContainsKey(house))
                {
                    Houses[house] += 1;
                }
                else
                {
                    Houses.Add(house, 1);
                }
            }

            return Houses.Count;
        }
    }
}
