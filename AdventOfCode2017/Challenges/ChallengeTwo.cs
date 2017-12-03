using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class ChallengeTwo
    {
        private static string input = File.ReadAllText(@"./Challenge2Input.txt");

        public static string challengeTwo(int modifier)
        {
            switch (modifier)
            {
                case 1:
                    return versionOne();
                case 2:
                    return versionTwo();
                default:
                    return "";
            }
        }

        public static string versionOne()
        {
            var output = 0;
            var rowDifferences = new List<int>();

            foreach (var line in input.Split('\n'))
            {
                var rowEntries = line.Split(' ').Select(x => x).Where(x => !String.IsNullOrEmpty(x)).Select(x => Convert.ToInt16(x)).ToArray();
                var minValue = rowEntries.Min();
                var maxValue = rowEntries.Max();
                var difference = maxValue - minValue;

                rowDifferences.Add(difference);
            }

            output = rowDifferences.Sum();

            return output.ToString();
        }

        public static string versionTwo()
        {
            var output = 0;
            
            var resultsOfRoundedDivision = new List<int>();

            foreach (var line in input.Split('\n'))
            {
                var rowEntries = line.Split(' ').Select(x => x).Where(x => !String.IsNullOrEmpty(x)).Select(x => Convert.ToInt16(x)).ToArray();

                foreach (var entry in rowEntries)
                {
                    var thing = rowEntries.Select(x => x).Where(x => IsRoundWhenDivided(entry, x)).Where(x => x != entry);
                    if (thing.Count() > 0)
                    {
                        resultsOfRoundedDivision.Add(entry / thing.First());
                        Console.WriteLine(String.Format("{0} divided by {1} is {2}", entry, thing.First(), (entry / thing.First()).ToString()));
                    }                    
                }
            }

            output = resultsOfRoundedDivision.Sum();
            return output.ToString();
        }

        private static bool IsRoundWhenDivided(int x, int y)
        {
            if (x % y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
