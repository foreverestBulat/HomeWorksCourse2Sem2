using FillData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PokemonsAPI.Data;

//namespace FillData;


Console.WriteLine("start");
var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseNpgsql("Host=localhost;Port=5432;Database=PokemonAPI;Username=postgres;Password=subuhankulov;").Options;
var context = new ApplicationDbContext(options);

PokeAPIService.Configure();
await context.AddPokemonsAndRelatedEntities();
//await context.AddAbilities();
//await context.AddMoves();
//await context.AddPokemonTypes();
await context.SaveChangesPokeAPIAsync();



//public static class Program
//{
//    public static void Main(string[] args)
//    {


//        //var hostBuilder = Host.CreateDefaultBuilder(args);
//        //hostBuilder.ConfigureServices((context, services) =>
//        //{
//        //    services.AddDbContext<ApplicationDbContext>(opt =>
//        //        opt.UseNpgsql("Host=localhost;Port=5432;Database=PokemonAPI;Username=postgres;Password=subuhankulov;"));
//        //});
//        //var host = hostBuilder.Build();
//        //using (var scope = host.Services.CreateScope())
//        //{
//        //    var services = scope.ServiceProvider;
//        //}
//    }
//}

