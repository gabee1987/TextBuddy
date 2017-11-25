using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextBuddy
{
    class RegexManager
    {
        public static List<string> SearchAndGetMatches(string input, string inputPattern)
        {
            List<string> foundMatches = new List<string>();
            string pattern = inputPattern;
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            //Match match = regex.Match(input);
            foreach (Match match in matches)
            {
                foundMatches.Add(match.Value.ToString());
            }
            return foundMatches;
        }

        private static string ReformatDate(string dateInput)
        {
            string pattern = @"([12]\d{3}/(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01]))";
            string foundDate = DateTime.Parse(Regex.Match(dateInput, pattern).Value).ToString("MM/dd/yyyy");

            return Regex.Replace(dateInput, pattern, foundDate);
        }
    }
}
