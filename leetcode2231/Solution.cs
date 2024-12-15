using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2231
{
    public class Solution
    {
        public int LargestInteger(int num)
        {
            string final = "";
            int k = 0, l = 0;
            List<int> digits = num.ToString().Select(x => x - '0').ToList();
            List<int> oddNums = digits.Where(x => x % 2 != 0).OrderByDescending(d => d).ToList();
            List<int> evenNums = digits.Where(x => x % 2 == 0).OrderByDescending(d => d).ToList();
            for(int i=0; i<digits.Count; i++)
            {
                if (digits[i]%2 == 0)
                {
                    final += evenNums[k].ToString(); k++;
                }
                else
                {
                    final += oddNums[l].ToString(); l++;
                }
            }
            
            return int.Parse(final);

        }
    }
}
