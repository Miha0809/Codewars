partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetUnique([1, 1, 1, 2, 1, 1]));
    }

    public static int GetUnique(IEnumerable<int> numbers)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        foreach (var item in numbers)
        {
            int count = 0;

            if (!dictionary.TryGetValue(item, out count))
            {
                dictionary.Add(item, count + 1);
            }
            else
            {
                count = dictionary[item];
                dictionary[item] = count + 1;
            }
        }

        return dictionary.MinBy(a => a.Value).Key;

    }
}
