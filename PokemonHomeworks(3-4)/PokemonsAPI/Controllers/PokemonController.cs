using Microsoft.AspNetCore.Mvc;
using PokemonsAPI.Data;
using PokemonsAPI.Models;


namespace PokemonsAPI.Controllers;

public class PokemonController : ApiControllerBase
{
    private readonly ApplicationDbContext _context;
    public PokemonController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("Pokemons")]
    public List<Pokemon> GetListPokemons(int index, int count)
    {
        return _context.Pokemons.Skip(index).Take(count).ToList();
    }

    [HttpGet("Pokemon")]
    public Pokemon GetPokemon(int index)
    {
        return _context.Pokemons.Find(index);
    }
}
