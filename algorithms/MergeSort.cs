namespace dotnet_dsa.algorithms;

class MergeSort
{
  public static void Run(int[] numbers)
  {
    if (numbers.Length <= 1) return;

    int[] left = new int[numbers.Length / 2];
    int[] right = new int[numbers.Length - left.Length];

    Array.Copy(numbers, 0, left, 0, left.Length);
    Array.Copy(numbers, left.Length, right, 0, right.Length);

    Run(left);
    Run(right);
    Merge(left, right, numbers);
  }

  public static void Merge(int[] left, int[] right, int[] numbers)
  {
    int leftIndex = 0;
    int rightIndex = 0;
    int pointer = 0;

    while (leftIndex < left.Length && rightIndex < right.Length)
    {
      if (left[leftIndex] <= right[rightIndex])
      {
        numbers[pointer++] = left[leftIndex++];
      }
      else
      {
        numbers[pointer++] = right[rightIndex++];
      }
    }

    while (leftIndex < left.Length)
    {
      numbers[pointer++] = left[leftIndex++];
    }

    while (rightIndex < right.Length)
    {
      numbers[pointer++] = right[rightIndex++];
    }
  }

  public static void Print(int[] numbers)
  {
    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }
  }
}