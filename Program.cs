partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Find([2, 4, 0, 100, 4, 11, 2602, 36]));
    }

    public static int Find(int[] integers)
    {
        List<int> oddNumbers = new List<int>();
        List<int> evenNumbers = new List<int>();

        foreach (var number in integers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            else
            {
                oddNumbers.Add(number);
            }
        }

        return (oddNumbers.Count == 1 ? oddNumbers[0] : evenNumbers[0]);
    }
}