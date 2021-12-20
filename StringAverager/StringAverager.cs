using System.Collections.Generic;
using System.Linq;

namespace StringAverage
{
    public class StringAverager
    {
        private readonly string InvalidString = "n/a";

        private static readonly Dictionary<string, int> NumberDic = new Dictionary<string, int> 
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };

        public string AverageString(string str)
        {
            var totalNum = 0;

            var strAry = str.Trim().Split(" ");
            foreach (var s in strAry)
            {
                if (!IsValid(s))
                {
                    return InvalidString;
                }

                totalNum += NumberDic[s];
            }

            var averageString = GetAverageString(totalNum, strAry.Count());

            return averageString;
        }

        private static string GetAverageString(int totalNum, int count)
        {
            var average = totalNum / count;

            return NumberDic.First(x => x.Value == average).Key;
        }


        private static bool IsValid(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            
            return NumberDic.ContainsKey(str.ToLower());
        }
        
    }
}