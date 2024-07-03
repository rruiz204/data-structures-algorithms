namespace dotnet_dsa.fundamentals;

public struct Coord(int p1, int p2)
{
  private int x = p1, y = p2;

  public void Display()
  {
    Console.WriteLine($"x: {x}, y: {y}");
  }
}

class Structs
{
  public static void Run()
  {
    Coord coords = new(10, 19);
    coords.Display();
  }
}