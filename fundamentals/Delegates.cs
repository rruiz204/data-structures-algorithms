namespace dotnet_dsa.fundamentals;

using System.Collections.Generic;

public class Person(string name, int age)
{
  public string Name { get; } = name;
  public int Age { get; } = age;
}

class Delegates
{
  private delegate bool FilterDelegate(Person person);

  public static void Run()
  {
    Person p1 = new("John", 41);
    Person p2 = new("Jane", 69);
    Person p3 = new("Jake", 12);
    Person p4 = new("Jessie", 25);

    List<Person> people = [p1, p2, p3, p4];

    DisplayPeople("Children:", people, IsChild);
    DisplayPeople("Adults:", people, IsAdult);
    DisplayPeople("Seniors:", people, IsSenior);
  }

  static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
  {
    Console.WriteLine(title);

    foreach (Person person in people)
    {
      if (filter(person))
      {
        Console.WriteLine($"{person.Name}, {person.Age} years old");
      }
    }

    Console.Write("\n\n");
  }
  static bool IsChild(Person person)
  {
    return person.Age < 18;
  }

  static bool IsAdult(Person person)
  {
    return person.Age >= 18;
  }

  static bool IsSenior(Person person)
  {
    return person.Age >= 65;
  }
}