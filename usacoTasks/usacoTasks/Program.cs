using usacoTask1;

Solution sol = new Solution();
Console.WriteLine("please add total number of array elements!");
var num = Console.ReadLine();
int numInput;
if (int.TryParse(num, out numInput))
{
    Console.WriteLine($"total num of elements in {numInput}");
}
else
{
    Console.WriteLine("please add valid number");
}

Console.WriteLine("please add integer type array elements");
List<int> list = new List<int>();
for(int i=0; i < numInput; i++)
{
    var s = Console.ReadLine();
    int numI;
    if(int.TryParse(s, out numI))
    {
        list.Add(numI);
    }
    else
    {
        Console.WriteLine("Please add valid number");
        i--;
    }
}

int ans = sol.Distinct(list.ToArray());
Console.WriteLine("Answer :" + ans);
