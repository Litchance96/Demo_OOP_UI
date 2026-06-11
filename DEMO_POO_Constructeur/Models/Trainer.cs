using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DEMO_POO_Constructeur.Models
{
    public class Trainer : Person
    {
        public List<Pokemon> Pokemons {  get; private set; }

        public string? Title { get; private set; }


        public Trainer(string title, string lastName,string firstname, DateTime birthDate)
            : base(firstname, lastName, birthDate) //Chainage avec la classe parent (ordre ici est important) -- "super.self" de python
        {
            Pokemons = [];
        Title = title;
        }

    }
}
