using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    public class Solution
    {
        public void Counting(int[] array)
        {
            int max = array[0];
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int[] count = new int[max + 1];
            for(int i=0; i< array.Length; i++)
            {
                count[array[i]]++;
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    array[index] = i;
                    index++;
                    count[i]--;
                }
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
