partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ToCamelCase("the-stealth-warrior"));
    }

    public static string ToCamelCase(string str)
    {
        string[] camelCase = str.Split(
            new char[] { '-', '_' },
            StringSplitOptions.RemoveEmptyEntries
        );

        for (int i = 1; i < camelCase.Length; i++)
        {
            camelCase[i] = char.ToUpper(camelCase[i][0]) + camelCase[i].Substring(1);
        }

        return string.Concat(camelCase);

    }
}