using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MaxHeap
    {
        private List<int> heap;

        public MaxHeap()
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

        // Remove and return the maximum element (root)
        public int RemoveMax()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty!");

            int max = heap[0]; // The root is the maximum value
            heap[0] = heap[heap.Count - 1]; // Replace root with the last element
            heap.RemoveAt(heap.Count - 1); // Remove the last element
            HeapifyDown(0); // Restore the heap property

            return max;
        }

        // Peek at the maximum value without removing it
        public int PeekMax()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty!");

            return heap[0]; // Root contains the maximum value
        }

        // Heapify up to restore the Max-Heap property
        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[index] > heap[Parent(index)])
            {
                Swap(index, Parent(index)); // Swap with the parent
                index = Parent(index); // Move up the tree
            }
        }

        // Heapify down to restore the Max-Heap property
        private void HeapifyDown(int index)
        {
            while (true)
            {
                int left = LeftChild(index);
                int right = RightChild(index);
                int largest = index;

                if (left < heap.Count && heap[left] > heap[largest])
                {
                    largest = left;
                }

                if (right < heap.Count && heap[right] > heap[largest])
                {
                    largest = right;
                }

                if (largest == index) break;

                Swap(index, largest); // Swap with the largest child
                index = largest; // Move down the tree
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
