enum Roles
{
    Admin,
    Client
}

partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Persistence(999));
    }

    public static int Persistence(long n, int count = 0)
    {
        if (n > 9)
        {
            count++;
            long multiplicative = 1;

            while (n > 0)
            {
                var lastNumber = n % 10;
                multiplicative *= lastNumber;
                n /= 10;
            }

            return Persistence(multiplicative, count);
        }

        return count;
    }
}
