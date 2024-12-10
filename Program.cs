partial class Program
{
    public static void Main(string[] args)
    {
        foreach (var item in FriendOrFoe(["Mark", "Jimmy", "Abel", "Amanda"]))
        {
            Console.WriteLine(item);
        }
    }

    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        List<string> friends = new List<string>();

        foreach (var name in names)
        {
            if (name.Length == 4)
            {
                friends.Add(name);
            }
        }

        return friends;
    }
}
