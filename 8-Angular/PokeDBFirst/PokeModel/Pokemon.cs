﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PokeModel
{
    public class Pokemon
    {
        //Acts as our primary key
        [Key]
        public int PokeId { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set {
                    if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                    {
                        _name = value; 
                    }
                    else
                    {
                        throw new ValidationException("Cannot have numbers in the name");
                    }
                }
        }
        
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int SpecialAttack { get; set; }
        public string Type { get; set; }

        //Full properties are required to do validation
        private List<Ability> _abilities;
        public List<Ability> Abilities





        
        {
            get { return _abilities; }
            set 
            { 
                //Cannot set abilities to have more than 4
                if (value.Count < 4)
                {
                    _abilities = value;
                }
                else
                {
                    throw new Exception("Pokemon cannot hold more than 4 abilities!");
                }
            }

        }      

        //Default constructor to add default values to the properties
        public Pokemon()
        {
            Name = "Ditto";
            Level = 1;
            Attack = 55;
            Defense = 55;
            Health = 55;
            // _abilities = new List<Ability>()
            // {
            //     new Ability()
            // };
        }

        //ToString() method is the string version of your object
        public override string ToString()
        {
            return $"Id: {PokeId}\nName: {Name}\nLevel: {Level}\nAttack: {Attack}\nDefense: {Defense}\nHealth: {Health}";
        }
    }
}

