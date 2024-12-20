using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode3042
{
    public class Solution
    {
        int count = 0;
        public int CountPrefixSuffixPairs(string[] words)
        {
            for(int i=0; i<words.Length; i++)
            {
                for (int j = i+1; j < words.Length ; j++)
                {
                    isPrefixAndSuffix(words[i], words[j]);
                }
            }
            return count;
        }

        public void isPrefixAndSuffix(string s, string t)
        {
            var preFyp = t.StartsWith(s);
            var postFyp = t.EndsWith(s);
            if(preFyp == true && postFyp == true) 
            {
                count++;
            }
        }
    }
}
