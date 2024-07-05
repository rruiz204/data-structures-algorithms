namespace dotnet_dsa.fundamentals;

struct StructCharacter(string name, int age)
{
  private string _name = name;
  private int _age = age;

  public void Deconstruct(out string name, out int age)
  {
    name = _name;
    age = _age;
  }
}

class Tuples
{
  public static void Run((string name, int age) character)
  {
    var (name, _) = character;
    Console.WriteLine($"The name of the character is: {name}");

    StructCharacter sunraku = new("sunraku", 18);
    var (sName, _) = sunraku;
    Console.WriteLine($"The name of the new character is: {sName}");
  }
}