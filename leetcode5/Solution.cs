using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode5
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            string longest = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    string substring = s.Substring(i, j - i + 1);
                    if (IsPalindrom(substring) && substring.Length > longest.Length)
                    {
                        longest = substring;
                    }
                }
            }
            return longest;
        }

        public bool IsPalindrom(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left++] != s[right--])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

