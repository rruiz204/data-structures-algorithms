namespace dotnet_dsa;

using dotnet_dsa.algorithms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bubble Sort");
        int[] numbers = [8, 4, 2, 9, 10, 87, 3, 23];
        BubbleSort.sort(numbers);
    }
}
