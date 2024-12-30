using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode849
{
    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < seats.Length; i++)
            {
                int left = 0, right = 0, j = i, count = 0;

                while (i < seats.Length && seats[i] == 0)
                {
                    // Count left empty seats
                    left++;
                    j = i;

                    // Count right empty seats
                    while (j < seats.Length && seats[j] == 0)
                    {
                        right++;
                        j++;
                    }

                    // Calculate distance
                    int distance = (i == 0 || j == seats.Length)
                        ? Math.Max(left, right) // Edge stretches
                        : Math.Min(left, right); // Middle stretches

                    // Use stretch start index as key
                    if (!dict.ContainsKey(i))
                        dict[i] = distance;

                    right = 0; // Reset right counter for next segment
                    i++;
                    count++;
                }

                if (count != 0)
                    i--; // Adjust `i` to avoid skipping elements
            }

            // Return the maximum value from the dictionary
            return dict.Count > 0 ? dict.Values.Max() : 0;
        }

    }
}
