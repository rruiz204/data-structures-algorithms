namespace dotnet_dsa.fundamentals;

using System.Collections.Generic;

class Collections
{
  public static void Run()
  {
    List<int> numbers = [];

    numbers.Add(100);
    numbers.Add(100);
    numbers.Add(100);

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }


    HashSet<string> letters = [];

    letters.Add("A");
    letters.Add("B");
    letters.Add("V");

    letters.Add("A");

    foreach (string letter in letters)
    {
      Console.WriteLine(letter);
    }
  }
}