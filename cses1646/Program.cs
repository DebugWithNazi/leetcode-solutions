
//https://cses.fi/problemset/task/1646

class Program
{
    static void Main()
    {
        Console.WriteLine("Give the size of an array and queries: ");
        var value = Console.ReadLine().Split();

        int n = int.Parse(value[0]);
        int q = int.Parse(value[1]);

        Console.WriteLine("Enter array values with space!");
        int[] array = new int[n];
        string[] inputs = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            if (i > 0)
                array[i] = array[i - 1] + int.Parse(inputs[i]);
            else
                array[i] = int.Parse(inputs[i]);

        }


        Console.WriteLine("Enter query(a,b)!");

        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split();
            int a = int.Parse(query[0]);
            int b = int.Parse(query[1]);
            int sum = 0;
            if (a >= 2)
                sum = array[b - 1] - array[a - 2];
            else
                sum = array[b - 1] - 0;

            Console.WriteLine(sum);
        }
    }
}