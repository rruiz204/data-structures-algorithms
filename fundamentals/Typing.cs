namespace dotnet_dsa.fundamentals;

public struct Coords(int p1, int p2) // Struct Example
{
  public int x = p1, y = p2;
  
  public readonly void Display()
  {
    Console.WriteLine($"x: {x}, y: {y}");
  }
}

enum Level { // Enum Example
  Low,
  Medium,
  High,
}

class Typing
{
  public static void Run()
  {
    Coords coord = new(10, 10);
    coord.Display();
  }
}