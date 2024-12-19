partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SpinWords("Hey fellow warriors"));
    }

    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string result = string.Empty;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 5)
            {
                char[] itemChar = words[i].ToCharArray();
                Array.Reverse(itemChar);
                words[i] = new string(itemChar);
            }

            result += words[i] + " ";
        }

        return result[..^1];
    }
}