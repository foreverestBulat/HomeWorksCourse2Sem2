using Microsoft.EntityFrameworkCore;
using PokemonsAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonsAPI.Services;

public static class Apply
{
    //public async static void Start(this ApplicationDbContext context)
    //{
    //    Console.WriteLine("start");
    //    if (context is null)
    //    {
    //        var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=FOREVEREST;Database=PokemonsAPI;User id=FOREVEREST;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=600;").Options;
    //        context = new ApplicationDbContext(options);
    //    }

    //    PokeAPIService.Configure();
    //    //await context.AddAbilities();
    //    //await context.AddPokemonTypes();
    //    //await context.AddMoves();
    //    //await context.AddPokemonsAndRelatedEntities();
    //    await context.SaveChangesPokeAPIAsync();
    //}
}
