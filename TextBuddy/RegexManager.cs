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
            Regex regex = new Regex(inputPattern);
            MatchCollection matches = regex.Matches(input);
            //Match match = regex.Match(input);
            foreach (Match match in matches)
            {
                foundMatches.Add(match.Value.ToString());
            }
            return foundMatches;
        }

        public static string ReplaceFoundMatches(string input, string searchPattern, string replacePattern)
        {
            try
            {
                return Regex.Replace(input, searchPattern, replacePattern, RegexOptions.None, TimeSpan.FromMilliseconds(150));
            }
            catch (RegexMatchTimeoutException re)
            {
                Console.WriteLine(re);
                return input;
            }
        }

        public static int CountFoundMatches(string input, string searchPattern)
        {
            return Regex.Matches(input, searchPattern).Count;
        }

        public static string FormatDate(string input, string pattern, string newDateFormat)
        {
            List<string> splittedDocument = input.Split('\n').Select(s => s.Trim()).ToList();
            string result = "";
            Regex regex = new Regex(pattern);

            foreach (String line in splittedDocument)
            {
                result += ReformatDate(line, pattern, newDateFormat) + "\n";
            }
            return result;
        }

        private static string ReformatDate(string dateInput, string searchPattern, string newDateFormat)
        {
            try
            {
                string foundDate = DateTime.Parse(Regex.Match(dateInput, searchPattern).Value).ToString(newDateFormat);
                return Regex.Replace(dateInput, searchPattern, foundDate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return dateInput;
        }

    }
}
