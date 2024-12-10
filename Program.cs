partial class Program
{
    public static void Main(string[] args)
    {
        foreach(var item in GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 123}))
        {
            Console.WriteLine(item);
        }
    }

    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> result = new List<int>();
     
      foreach (var item in listOfItems)
      {
          if (item.GetType() == typeof(int))
          {
              result.Add(Convert.ToInt32(item));
          }
      }
     
     return result;
   }
}
