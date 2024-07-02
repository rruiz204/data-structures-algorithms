namespace dotnet_dsa.fundamentals;

class Arrays
{
  public static void Run()
  {
    // type[] name = [value, value, value]

    string[] cars = ["BMW", "Ford", "Ferrari"];
    Console.WriteLine(string.Join(", ", cars));

    cars[1] = "Bugatti";
    Console.WriteLine(string.Join(", ", cars));
  }
}