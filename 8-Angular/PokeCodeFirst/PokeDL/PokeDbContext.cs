using Microsoft.EntityFrameworkCore;
using PokeModel;

namespace PokeDL
{
    public class PokeDbContext : DbContext
    {
        //We supply a bunch of DbSet properties to map our models to this upcoming DbContext
        public DbSet<Pokemon> Pokemons {get; set;}
        public DbSet<Ability> Abilities { get; set; }

        public PokeDbContext() : base()
        { }

        public PokeDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder p_modelBuilder)
        {
            //Create self generating Id
            //Fluent API
            p_modelBuilder.Entity<Pokemon>()
                .Property(poke => poke.PokeId)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();
            
            p_modelBuilder.Entity<Ability>()
                .Property(abi => abi.AbId)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();
        }
    }
}