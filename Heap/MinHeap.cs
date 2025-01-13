using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MinHeap
    {
        private List<int> heap;

        public MinHeap()
        {
            heap = new List<int>();
        }

        // Get the parent index
        private int Parent(int index) => (index - 1) / 2;

        // Get the left child index
        private int LeftChild(int index) => 2 * index + 1;

        // Get the right child index
        private int RightChild(int index) => 2 * index + 2;

        // Insert a new value into the heap
        public void Insert(int value)
        {
            heap.Add(value); // Add the value at the end
            HeapifyUp(heap.Count - 1); // Restore the heap property
        }

        // Remove and return the minimum element (root)
        public int RemoveMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty!");

            int min = heap[0]; // The root is the minimum value
            heap[0] = heap[heap.Count - 1]; // Move the last element to the root
            heap.RemoveAt(heap.Count - 1); // Remove the last element
            HeapifyDown(0); // Restore the heap property

            return min;
        }

        // Heapify up to restore the heap property
        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[index] < heap[Parent(index)])
            {
                Swap(index, Parent(index)); // Swap with the parent
                index = Parent(index); // Move up the tree
            }
        }

        // Heapify down to restore the heap property
        private void HeapifyDown(int index)
        {
            while (true)
            {
                int left = LeftChild(index);
                int right = RightChild(index);
                int smallest = index;

                if (left < heap.Count && heap[left] < heap[smallest])
                {
                    smallest = left;
                }

                if (right < heap.Count && heap[right] < heap[smallest])
                {
                    smallest = right;
                }

                if (smallest == index) break;

                Swap(index, smallest); // Swap with the smallest child
                index = smallest; // Move down the tree
            }
        }

        // Swap two elements in the heap
        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        // Display the heap elements
        public void Display()
        {
            Console.WriteLine(string.Join(", ", heap));
        }
    }
}
