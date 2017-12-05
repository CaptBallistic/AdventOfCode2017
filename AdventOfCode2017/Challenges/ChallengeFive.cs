using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class ChallengeFive
    {
        private static string[] input = File.ReadAllLines(@"./Inputs/Challenge5Input.txt");
        
        public static string ChallengeFiveResult(int modifier)
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
            var escaped = false;
            
            var intArray = input.Select(x => Convert.ToInt16(x)).ToArray();

            var i = 0;

            while (!escaped)
            {
                output++;
                var hopper = intArray[i];
                intArray[i]++;
                i += hopper;
                if (i < 0 || i >= intArray.Length)
                {
                    escaped = true;
                }
            }

            return output.ToString();
        }

        public static string VersionTwo()
        {
            var output = 0;
            var escaped = false;

            var intArray = input.Select(x => Convert.ToInt16(x)).ToArray();

            var i = 0;

            while (!escaped)
            {
                output++;
                var hopper = intArray[i];
                if (hopper >= 3)
                {
                    intArray[i]--;
                }
                else
                {
                    intArray[i]++;
                }

                i += hopper;
                if (i < 0 || i >= intArray.Length)
                {
                    escaped = true;
                }
            }

            return output.ToString();
        }
    }
}
