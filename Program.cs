using System.Text;

partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Maskify("4556364607935616"));
    }

    public static string Maskify(string cc)
    {
        var result = new StringBuilder();

        for (int i = 0; i < cc.Length; i++)
        {
            if (cc.Length - 4 > i)
            {
                result.Append("#");
            }
            else
            {
                result.Append(cc[i]);
            }
        }

        return result.ToString();
    }
}
