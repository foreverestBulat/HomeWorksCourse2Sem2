using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using PokemonsAPI.Models;
using System.Reflection;

namespace PokemonsAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {

    }

    public DbSet<Pokemon> Pokemons => Set<Pokemon>();
    public DbSet<PokemonDetails> PokemonsDetails => Set<PokemonDetails>();
    public DbSet<Move> Moves => Set<Move>();
    public DbSet<Ability> Abilities => Set<Ability>();
    public DbSet<PokemonStats> PokemonsStats => Set<PokemonStats>();
    public DbSet<PokemonType> PokemonTypes => Set<PokemonType>();


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.Entity<Pokemon>()
            .HasOne(e => e.Details)
            .WithOne(e => e.Pokemon)
            .HasForeignKey<PokemonDetails>("PokemonId")
            .IsRequired(true);

        builder.Entity<PokemonDetails>()
            .HasOne(e => e.Stats)
            .WithOne(e => e.Details)
            .HasForeignKey<PokemonStats>("PokemonDetailsId")
            .IsRequired(true);

        builder.Entity<Pokemon>()
            .HasMany(e => e.Types)
            .WithMany(e => e.Pokemons);

        builder.Entity<PokemonDetails>()
            .HasMany(e => e.Types)
            .WithMany(e => e.PokemonsDetails);

        builder.Entity<PokemonDetails>()
            .HasMany(e => e.Moves)
            .WithMany(e => e.PokemonsDetails);

        builder.Entity<PokemonDetails>()
            .HasMany(e => e.Abilities)
            .WithMany(e => e.PokemonsDetails);
    }

    public override int SaveChanges()
    {
        return SaveChangesAsync().GetAwaiter().GetResult();
    }
}
