partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Solution(35));
    }

    public static int Solution(int value)
    {
        int suma = 0;

        for (int i = 1; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                suma += i;
            }
        }

        return suma;
    }
}
