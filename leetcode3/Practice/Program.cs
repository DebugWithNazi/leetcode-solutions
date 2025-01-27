
class Program //task3
{
    static void Main()
    {
        Console.WriteLine("Give the number k:");
        int m = int.Parse(Console.ReadLine());
        int n = m;
        for (int i = 2; i <= n; i++)
        {
            if (n != 1 && n % i == 0)
            {
                n = n / i;
            }
        }
        if (n == 1) { Console.WriteLine(m); }
        else { Console.WriteLine(n); }
    }
    //static void Main()
    //{
    //    // Read the number of judges to invalidate (N)
    //    Console.WriteLine("Give the number of judges:");
    //    int N = int.Parse(Console.ReadLine());

    //    // Read the scores given by 5N judges
    //    Console.WriteLine($"Enter {5 * N} scores:");
    //    var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

    //    // Validate input length
    //    if (nums.Count != 5 * N)
    //    {
    //        Console.WriteLine("Invalid input: Number of scores must equal 5 * N.");
    //        return;
    //    }

    //    // Remove the top N maximum and bottom N minimum grades
    //    for (int i = 0; i < N; i++)
    //    {
    //        nums.Remove(nums.Max()); // Remove highest grade
    //        nums.Remove(nums.Min()); // Remove lowest grade
    //    }

    //    // Calculate the sum of the remaining scores
    //    int sum = nums.Sum();

    //    // Calculate the average of the remaining scores
    //    double avg = (double)sum / nums.Count;

    //    // Print the average with required precision
    //    Console.WriteLine(avg.ToString("F5"));
    //}
}



//class Program //task1
//{
//    static void Main()
//    {
//        Console.WriteLine("Give the value of two integers:");
//        var values = Console.ReadLine().Split();
//        int a = int.Parse(values[0]);
//        int b = int.Parse(values[1]);

//        Console.WriteLine("Give me a boolean (either 0 or 1)");
//        var boolValue = Console.ReadLine();

//        if(boolValue == "0")
//        {
//            Console.WriteLine(a + b);
//        }
//        else
//        {
//            Console.WriteLine(a * b);
//        }
//    }
//}