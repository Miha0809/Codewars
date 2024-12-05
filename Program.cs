using Codewars;

partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FindMissingLetter(new [] { 'a','b','c','d','f' }));
    }

    public static char FindMissingLetter(char[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var prevChar = ((int)array[i-1]) + 1;
            var currentChar = (int)array[i];

            if (prevChar != currentChar)
            {
                return (char)prevChar;
            }
        }

        return ' ';
    }
}
