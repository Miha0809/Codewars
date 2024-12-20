partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DigitalRoot(16));
    }

    public static int DigitalRoot(long n, long suma = 0)
    {
        if (n > 9)
        {
            while (n > 0)
            {
                var lastNumber = n % 10;
                suma += lastNumber;
                n /= 10;
            }

            return DigitalRoot(suma);
        }

        return (int)n;
    }
}