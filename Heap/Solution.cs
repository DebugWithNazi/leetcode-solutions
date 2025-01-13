using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{

    class Solution
    {
        static void main()
        {
            var minHeap = new PriorityQueue<int, int>();

            // Insert elements into Min-Heap
            minHeap.Enqueue(10, 10);
            minHeap.Enqueue(5, 5);
            minHeap.Enqueue(20, 20);
            minHeap.Enqueue(1, 1);

            Console.WriteLine("Min-Heap:");
            while (minHeap.Count > 0)
            {
                Console.WriteLine(minHeap.Dequeue()); // Output: 1, 5, 10, 20
            }

            // Max-Heap using PriorityQueue (custom comparator by negating priority)
            var maxHeap = new PriorityQueue<int, int>();

            // Insert elements into Max-Heap
            maxHeap.Enqueue(10, -10);
            maxHeap.Enqueue(5, -5);
            maxHeap.Enqueue(20, -20);
            maxHeap.Enqueue(1, -1);

            Console.WriteLine("\nMax-Heap:");
            while (maxHeap.Count > 0)
            {
                Console.WriteLine(maxHeap.Dequeue()); // Output: 20, 10, 5, 1
            }
        }
    }
}
