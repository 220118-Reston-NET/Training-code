using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PokeDL;
using PokeModel;
using Xunit;

namespace PokeTest
{
    public class DbContextRepositoryTest
    {

        private readonly DbContextOptions<PokeDbContext> options;

        //The constructor is called on before every unit tests
        public DbContextRepositoryTest()
        {
            //Gets the DbContextOptions from the inmemory database that is created using SQLite as the engine
            options = new DbContextOptionsBuilder<PokeDbContext>().UseSqlite("Filename = Test.db").Options;
            Seed();
        }

        [Fact]
        void GetAllPokemonShouldGetAllPokemon()
        {
            using (PokeDbContext context = new PokeDbContext(options))
            {
                //Arrange
                IRepository repo = new DbContextRespository(context);

                //Act
                List<Pokemon> listOfPoke = repo.GetAllPokemon();

                //Assert
                Assert.Equal(2, listOfPoke.Count);
                Assert.Equal("JasmineT", listOfPoke[0].Name);
            }
        }

        [Fact]
        void AddPokemonShouldAddPokemonInDB()
        {
            using (PokeDbContext context = new PokeDbContext(options))
            {
                //Arrange
                string name = "testPoke";
                int level = 1;
                string type = "Green";
                Pokemon dummyPoke = new Pokemon();
                dummyPoke.Name = name;
                dummyPoke.Level = level;
                dummyPoke.Type = type;

                IRepository repo = new DbContextRespository(context);

                //Act
                repo.AddPokemon(dummyPoke);

                //Assert
                Pokemon pokemonActual = context.Pokemons.First(poke => poke.Name == name);
                Assert.Equal(level, pokemonActual.Level);
            }
        }

        //This will add data into our inmemory database
        private void Seed()
        {
            using (PokeDbContext context = new PokeDbContext(options))
            {
                //We want to make sure that our database is consistent for each unit test we run on
                //As Jasmine T said in 3/11/2022 "We start on a clean state"
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Pokemons.AddRange(
                    new Pokemon
                    {
                        PokeId = 1,
                        Name = "JasmineT",
                        Attack = 10,
                        Defense = 10,
                        Health = 100,
                        Level = 24,
                        Speed = 1,
                        SpecialAttack = 30,
                        Type = "Fire",
                        Abilities = new List<Ability>(){new Ability {
                                AbId = 1,
                                Name = "Sleeping",
                                Accuracy = 100,
                                Power = 0,
                                PP = 9999
                            }
                        }
                    },
                    new Pokemon
                    {
                        PokeId = 2,
                        Name = "Andrew",
                        Attack = 800,
                        Defense = 1,
                        Health = 1,
                        Level = 1,
                        Speed = 1,
                        SpecialAttack = 800,
                        Type = "Annoying",
                        Abilities = new List<Ability>(){new Ability {
                                AbId = 2,
                                Name = "Bad at coding",
                                Accuracy = 1,
                                Power = 0,
                                PP = 9999
                            }
                        }
                    }
                );

                context.SaveChanges();
            }
        }
    }
}