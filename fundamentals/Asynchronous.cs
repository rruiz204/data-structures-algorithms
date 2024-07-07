namespace dotnet_dsa.fundamentals;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


public class PokemonResponse
{
    public int? Count { get; }
    public string? Next { get; }
    public string? Previous { get; }
    public List<PokemonResult>? Results { get; }
}

public class PokemonResult
{
    public string? Name { get; }
    public string? Url { get; }
}

class Asynchronous
{
  public static async Task PokeAPI()
  {
    HttpClient client = new();
    string url = "https://pokeapi.co/api/v2/pokemon/";

    try
    {
      HttpResponseMessage response = await client.GetAsync(url);
      response.EnsureSuccessStatusCode();

      string body = await response.Content.ReadAsStringAsync();
      PokemonResponse? pokemon = JsonConvert.DeserializeObject<PokemonResponse>(body);

      foreach (PokemonResult result in pokemon?.Results ?? Enumerable.Empty<PokemonResult>())
      {
        Console.WriteLine($"Name: {result.Name}");
      }
    }
    catch (HttpRequestException e)
    {
      Console.WriteLine(e.Message);
    }
  }
}