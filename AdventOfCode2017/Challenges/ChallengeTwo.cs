using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenges
{
    public class ChallengeTwo
    {
        private static string input = File.ReadAllText(@"./Inputs/Challenge2Input.txt");

        public static string ChallengeTwoResult(int modifier)
        {
            switch (modifier)
            {
                case 1:
                    return VersionOne();
                case 2:
                    return VersionTwo();
                default:
                    return string.Empty;
            }
        }

        public static string VersionOne()
        {
            var output = 0;
            var rowDifferences = new List<int>();

            foreach (var line in input.Split('\n'))
            {
                var rowEntries = line.Split(' ').Select(x => x).Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt16(x)).ToArray();
                var minValue = rowEntries.Min();
                var maxValue = rowEntries.Max();
                var difference = maxValue - minValue;

                rowDifferences.Add(difference);
            }

            output = rowDifferences.Sum();

            return output.ToString();
        }

        public static string VersionTwo()
        {
            var output = 0;
            
            var resultsOfRoundedDivision = new List<int>();

            foreach (var line in input.Split('\n'))
            {
                var rowEntries = line.Split(' ').Select(x => x).Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt16(x)).ToArray();

                foreach (var entry in rowEntries)
                {
                    var thing = rowEntries.Select(x => x).Where(x => IsRoundWhenDivided(entry, x)).Where(x => x != entry);
                    if (thing.Count() > 0)
                    {
                        resultsOfRoundedDivision.Add(entry / thing.First());
                        Console.WriteLine(string.Format("{0} divided by {1} is {2}", entry, thing.First(), (entry / thing.First()).ToString()));
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
