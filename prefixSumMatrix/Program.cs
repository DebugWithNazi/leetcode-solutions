

using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        Console.WriteLine("Add no. of rows and columns: ");
        string[] inputs = Console.ReadLine().Split();
        int rows = int.Parse(inputs[0]);
        int cols = int.Parse(inputs[1]);

        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Add the row values: ");
            string[] values = Console.ReadLine().Split();
            for (int j = 0; j < cols; j++)
            {
                array[i,j] = int.Parse(values[j]);
            }
        }

        int[,] prefix = new int[rows + 1, cols + 1];

        for(int i=0; i < rows; i++)
        {
            for(int j=0; j < cols; j++)
            {
                prefix[i + 1,j + 1] = array[i,j] + prefix[i,j + 1] + prefix[i + 1,j] - prefix[i,j];
            }
        }

        Console.WriteLine("Prefix Sum Matrix: ");

        for(int i=1; i<=rows; i++)
        {
            for(int j=1; j<=cols; j++)
            {
                Console.Write(prefix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}