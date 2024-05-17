using Microsoft.EntityFrameworkCore;
using PokemonsAPI.Services;

namespace PokemonsAPI.Data;

public static class ApplicationDbContextConfiguration
{
    public async static Task Seed(this ApplicationDbContext context)
    {
        PokeAPIService.Configure();
        await context.HasAbilities();
        await context.HasPokemonTypes();
        await context.HasMoves();
        await context.HasPokemonsAndRelatedEntities();
    }
}
