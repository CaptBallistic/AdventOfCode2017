using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class ChallengeThree
    {
        private static string input = File.ReadAllText(@"./Challenge3Input.txt");

        public static string ChallengeThreeResult(int modifier)
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
            return output.ToString();
        }

        public static string VersionTwo()
        {
            var output = 0;
            return output.ToString();
        }
    }
}
