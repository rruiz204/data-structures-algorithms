namespace dotnet_dsa.fundamentals;

class Conditions
{
  public static void Run()
  {
    int numberA = 100;
    int numberB = 87;

    if (numberA > numberB)
    {
      Console.WriteLine($"{numberA} is greater than {numberB}");
    }
    else
    {
      Console.WriteLine($"{numberA} is not greater than {numberB}");
    }

    // Ternary Operator
    string idk = (numberA > numberB) ? "yes" : "no";
  }
}