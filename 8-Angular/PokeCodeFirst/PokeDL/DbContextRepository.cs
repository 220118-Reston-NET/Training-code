using Microsoft.EntityFrameworkCore;
using PokeModel;

namespace PokeDL
{
    public class DbContextRespository : IRepository
    {
        private readonly PokeDbContext _context;

        public DbContextRespository(PokeDbContext context)
        {
            _context = context;
        }

        public Pokemon AddPokemon(Pokemon p_poke)
        {
            _context.Pokemons.Add(p_poke);
            _context.SaveChanges();

            return p_poke;
        }

        public List<Ability> GetAbilitiesByPokeId(int p_pokeId)
        {
            return _context.Abilities.Where(abi => abi.PokemonPokeId == p_pokeId).ToList();
        }

        public List<Pokemon> GetAllPokemon()
        {
            //Include method will change to eager loading to also load any related information (basically any related foreign key) for that model
            //So in this case, we essentially did an inner join with Pokemon and Ability to grab all that information
            return _context.Pokemons.Include("Abilities").ToList();
        }

        public Task<List<Pokemon>> GetAllPokemonAsync()
        {
            throw new NotImplementedException();
        }

        public Pokemon UpdatePokemon(Pokemon p_poke)
        {
            _context.Pokemons.Update(p_poke);
            _context.SaveChanges();

            return p_poke;
        }
    }
}