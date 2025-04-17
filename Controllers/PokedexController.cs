using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PokedexController : ControllerBase
{
    private readonly PokeApiService _pokeApiService;

    public PokedexController(PokeApiService pokeApiService)
    {
        _pokeApiService = pokeApiService;
    }

    // Ruta para obtener Pokémon por nombre o ID
    [HttpGet("{nameOrId}")]
    public async Task<IActionResult> GetPokemon(string nameOrId)
    {
        var data = await _pokeApiService.GetPokemonDataAsync(nameOrId);

        if (data == null)
            return NotFound("Pokémon no encontrado");

        return Ok(data);  // Devolvemos el JSON tal cual
    }
}
