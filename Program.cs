partial class Program
{
    public static void Main(string[] args)
    {
        foreach (var item in UniqueInOrder("AAAABBBCCDAABBB"))
        {
            Console.Write(item + " ");
        }
    }

    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        T lastSymbol = default;

        foreach (var item in iterable)
        {
            if (!EqualityComparer<T>.Default.Equals(lastSymbol, item))
            {
                yield return item;
                lastSymbol = item;
            }
        }
    }
}
