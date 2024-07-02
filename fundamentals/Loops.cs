namespace dotnet_dsa.fundamentals;

class Loops
{
  public static void Run()
  {
    int control = 0;
    while (control < 5)
    {
      Console.WriteLine(control);
      control++;
    }

    for (int index = 0; index < 5; index++)
    {
      Console.WriteLine(index);
    }

    string[] cars = ["BMW", "Ford", "Volvo"];
    foreach (string car in cars)
    {
      Console.WriteLine(car);
    }
  }
}