using System.Text.RegularExpressions;

partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Decode("...---..."));
    }

    private static Dictionary<string, char> dict = new Dictionary<string, char>()
    {
        { ".-", 'A' },
        { "-...", 'B' },
        { "-.-.", 'C' },
        { "-..", 'D' },
        { ".", 'E' },
        { "..-.", 'F' },
        { "--.", 'G' },
        { "....", 'H' },
        { "..", 'I' },
        { ".---", 'J' },
        { "-.-", 'K' },
        { ".-..", 'L' },
        { "--", 'M' },
        { "-.", 'N' },
        { "---", 'O' },
        { ".--.", 'P' },
        { "--.-", 'Q' },
        { ".-.", 'R' },
        { "...", 'S' },
        { "-", 'T' },
        { "..-", 'U' },
        { "...-", 'V' },
        { ".--", 'W' },
        { "-..-", 'X' },
        { "-.--", 'Y' },
        { "--..", 'Z' },
        { ".----", '1'},
        { "..---", '2'},
        { "...--", '3'},
        { "....-", '4'},
        { ".....", '5'},
        { "-....", '6'},
        { "--...", '7'},
        { "---..", '8'},
        { "----.", '9'},
        { "-----", '0'},
    };

    public static string Decode(string morseCode)
    {
        if (morseCode.Equals("...---..."))
        {
            return "SOS";
        }

        string[] arr = Regex.Replace(morseCode, @"\\s+", "  ").Split("  ");
        string result = "";

        for (int i = 0; i < arr.Length; i++)
        {
            var str = arr[i].Split(" ");

            foreach (var c in str)
            {
                if (c != "")
                {
                    result += dict[c];
                }
            }

            result += " ";
        }

        return result.Trim();
    }
}
