namespace dotnet_dsa.algorithms;

class QuickSort
{
  public static void Run(int[] numbers)
  {
    // int[] numbers = [435, 414, 880, 812, 623];
    Sort(numbers, 0, numbers.Length - 1);
    Console.WriteLine(string.Join(", ", numbers));
  }

  static void Sort(int[] numbers, int low, int high)
  {
    if (low < high)
    {
      int pi = Partition(numbers, low, high);
      Sort(numbers, low, pi - 1);
      Sort(numbers, pi + 1, high);
    }
  }

  static int Partition(int[] numbers, int low, int high)
  {
    int pivot = numbers[high];
    int pi = low - 1;

    for (int index = low; index < high; index++)
    {
      if (numbers[index] < pivot)
      {
        pi++;
        Swap(numbers, pi, index);
      }
    }

    Swap(numbers, pi + 1 , high);
    return pi + 1;
  }

  static void Swap(int[] numbers, int a, int b)
  {
    (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
  }
}