namespace dotnet_dsa.fundamentals;

class Exceptions
{
  public static void Run()
  {
    int[] numbers = [1, 2, 3];

    try
    {
      Console.WriteLine(numbers[10]);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }
}