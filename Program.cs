partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetVowelCount("abracadabra"));
    }

    public static int GetVowelCount(string str)
    {
        var count = 0;
        var vowels = new[] {'a', 'e', 'i', 'o', 'u'};

        foreach (var item in str)
        {
            if (vowels.Contains(item))
            {
                count++;
            }
        }

        return count;
    }
}
