using System.Collections.Generic;
using System.Linq;

namespace LongestCommonSubsequence
{
    public class Subsequencer
    {
        public string FindLongestCommonSubsequence(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return string.Empty;

            var subsequences = new List<string>();

            for (int i = 0; i < s1.Length; i++)
            {
                var subsequence = FindSubsequenceStartingAtPosition(i, s1, s2);
                if (!string.IsNullOrEmpty(subsequence))
                    subsequences.Add(subsequence);
            }

            return subsequences.OrderByDescending(s => s.Length).FirstOrDefault() ?? string.Empty;
        }

        private static string FindSubsequenceStartingAtPosition(int startingIndex, in string s1, in string s2)
        {
            var subsequence = string.Empty;

            var tmpS2 = s2;

            for (int i = startingIndex; i < s1.Length; i++)
            {
                for (int j = 0; j < tmpS2.Length; j++)
                {
                    if (s1[i] == tmpS2[j])
                    {
                        subsequence += s1[i];
                        tmpS2 = tmpS2.Substring(j + 1);
                        break;
                    }
                }
            }

            return subsequence;
        }
    }
}