using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_POO_Constructeur.Models
{
    public class Pokemon
    {
     public string Name { get; private set; }
     public int Id { get; private set; }
     
     public Pokemon(int id, string name)
        {
            this.Id = id;
            Name = name;
        }

    }
}
