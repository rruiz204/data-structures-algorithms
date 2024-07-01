namespace dotnet_dsa.algorithms;

class SelectionSort
{
  public static void Sort(int[] numbers)
  {
    int length = numbers.Length;

    for (int index = 0; index < length; index++)
    {
      int minimum = index;

      for (int sub = index + 1; sub < length; sub++)
      {
        if (numbers[sub] < numbers[minimum])
        {
          minimum = sub;
        }
      }

      if (minimum != index)
      {
        // Tupple Swapping
        (numbers[index], numbers[minimum]) = (numbers[minimum], numbers[index]);
      }
    }

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }
  }
}