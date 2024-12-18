partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(string.Join(' ', ArrayDiff([1, 2, 2, 2, 3], [2])));
    }

    public static int[] ArrayDiff(int[] a, int[] b)
    {
        if (a.Length == 0)
        {
            return [];
        }

        List<int> result = new List<int>();
        HashSet<int> removeNumber = new HashSet<int>(b);

        foreach (var item in a)
        {
            if (!removeNumber.Contains(item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }
}
