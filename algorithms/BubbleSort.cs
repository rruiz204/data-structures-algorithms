namespace dotnet_dsa.algorithms;

class BubbleSort
{
  public static void sort(int[] numbers)
  {
    int length = numbers.Length;

    for (int index = 0; index < length; index++)
    {
      for (int sub = 0; sub < (length - index - 1); sub++)
      {
        // Compare 2 Numbers
        if (numbers[sub] > numbers[sub + 1])
        {
          // Tupple Swapping
          (numbers[sub], numbers[sub + 1]) = (numbers[sub + 1], numbers[sub]);
        }
      }
    }

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }
  }
}