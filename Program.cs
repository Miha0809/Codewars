using System.Text.RegularExpressions;

partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CountBits(1234));
    }

    public static int CountBits(int n)
    {
        string binary = Convert.ToString(n, 2);
        var countPositives = Regex.Matches(binary, "1").Count;
        return countPositives;
    }
}