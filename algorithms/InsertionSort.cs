namespace dotnet_dsa.algorithms;

class InsertionSort
{
  public static void Sort(int[] numbers)
  {
    int length = numbers.Length;

    for (int index = 1; index < length; index++)
    {
      int key = numbers[index];
      int sub = index - 1;

      while (sub >= 0 && numbers[sub] > key)
      {
        numbers[sub + 1] = numbers[sub];
        sub--;
      }
      numbers[sub + 1] = key;
    }

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }
  }
}