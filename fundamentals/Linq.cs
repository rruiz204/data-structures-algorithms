namespace dotnet_dsa.fundamentals;

using System.Linq;
using System.Collections.Generic;

class Linq
{
  public static void Run()
  {
    List<int> numbers = [49, 327, 3248, 34, 12, 654, 4, 10];

    List<int> pairs = numbers.Where(number => number % 2 == 0).ToList();
    foreach (int number in pairs)
    {
      Console.WriteLine(number);
    }
  }
}