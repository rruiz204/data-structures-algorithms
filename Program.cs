namespace dotnet_dsa;

using dotnet_dsa.algorithms;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Bubble Sort");
        int[] numbers = [8, 4, 2, 9, 10, 87, 3, 23];
        BubbleSort.Sort(numbers); */

        /* Console.WriteLine("Selection Sort");
        int[] numbers = [64, 25, 12, 22, 11];
        SelectionSort.Sort(numbers); */

        Console.WriteLine("Insertion Sort");
        int[] numbers = [5, 2, 9, 1, 5, 6];
        InsertionSort.Sort(numbers);
    }
}
