using System.Net.Http;
using System.Threading.Tasks;

public class PokeApiService
{
    private readonly HttpClient _httpClient;

    public PokeApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetPokemonDataAsync(string nameOrId)
    {
        // Llamamos a la PokéAPI
        var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nameOrId}");

        if (!response.IsSuccessStatusCode)
            return null;

        // Devolvemos el JSON como string
        return await response.Content.ReadAsStringAsync();
    }
}
