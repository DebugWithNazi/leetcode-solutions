using Heap;

MinHeap minHeap = new MinHeap();

// Insert elements into the heap
minHeap.Insert(10);
minHeap.Insert(20);
minHeap.Insert(5);
minHeap.Insert(30);
minHeap.Insert(2);

Console.WriteLine("Heap after insertion:");
minHeap.Display();

// Remove elements from the heap
Console.WriteLine("\nRemove Min: " + minHeap.RemoveMin());
Console.WriteLine("Heap after removing min:");
minHeap.Display();

Console.WriteLine("\nRemove Min: " + minHeap.RemoveMin());
Console.WriteLine("Heap after removing min:");
minHeap.Display();