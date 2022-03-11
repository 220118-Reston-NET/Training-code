﻿using PokeDL.Entities;

namespace PokeDL
{
    /// <summary>
    /// - Data layer project is responsible for interacting with our database and doing CRUD operations
    /// - C - Create, R - Read, U - Update, D - Delete
    /// - It must not have logical operation that will also manipualte the data it is grabbing
    /// - Just think of Data layer as the delivery man of your uber eats. You definitely don't want your delivery man to touch
    /// the food he is delivering and just give it to you so you can do whatever you want with it.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Add a pokemon to the database
        /// </summary>
        /// <param name="p_poke">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        Pokemon AddPokemon(Pokemon p_poke);

        /// <summary>
        /// Will give all pokemon in the database
        /// </summary>
        /// <returns>Returns a list collection of Pokemon objects</returns>
        List<Pokemon> GetAllPokemon();

        Task<List<Pokemon>> GetAllPokemonAsync();

        /// <summary>
        /// Will give a list of abilities from a pokemon
        /// </summary>
        /// <param name="p_pokeId">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Ability> GetAbilitiesByPokeId(int p_pokeId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_poke"></param>
        /// <returns></returns>
        Pokemon UpdatePokemon(Pokemon p_poke);
    }
}

