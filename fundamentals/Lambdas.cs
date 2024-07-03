namespace dotnet_dsa.fundamentals;

class Lambdas
{
  Func<int, int> square = number => number * number;

  Action greeting = () => Console.WriteLine("Hello World!");

  public void Run()
  {
    int result = square(10);
    greeting();
  }
}
