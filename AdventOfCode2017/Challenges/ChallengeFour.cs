using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class ChallengeFour
    {
        private static string[] input = File.ReadAllLines(@"./Inputs/Challenge4Input.txt");

        public static string ChallengeFourResult(int modifier)
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
            foreach (var line in input)
            {
                var passPhrases = new Dictionary<string, int>();

                var phrases = line.Split(' ');
                foreach (var phrase in phrases)
                {
                    if (!passPhrases.ContainsKey(phrase))
                    {
                        passPhrases.Add(phrase, 0);
                    }

                    passPhrases[phrase]++;
                }

                if (passPhrases.Select(x => x).Where(x => x.Value > 1).Count() == 0)
                {
                    output++;
                }
            }

            return output.ToString();
        }

        public static string VersionTwo()
        {
            var output = 0;
            foreach (var line in input)
            {
                var passPhrases = new Dictionary<string, int>();

                var phrases = line.Split(' ');
                foreach (var phrase in phrases)
                {
                    var orderedCharacters = phrase.Select(x => x).ToList<char>();
                    orderedCharacters.Sort();
                    var newPhrase = string.Join(string.Empty, orderedCharacters);

                    if (!passPhrases.ContainsKey(newPhrase))
                    {
                        passPhrases.Add(newPhrase, 0);
                    }

                    passPhrases[newPhrase]++;
                }

                if (passPhrases.Select(x => x).Where(x => x.Value > 1).Count() == 0)
                {
                    output++;
                }
            }

            return output.ToString();
        }
    }
}
