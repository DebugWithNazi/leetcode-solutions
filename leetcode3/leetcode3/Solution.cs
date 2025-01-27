using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> list = new List<char>();
            int max = 0;

           
            foreach(var c in s)
            {
                while (list.Contains(c))
                {
                    list.RemoveAt(0); 
                }

                
                list.Add(c);

              
                max = Math.Max(max, list.Count);
            }
            return max;
        }
    }
}
