using System;
using System.Collections.Generic;
using System.Text;


// CA PART EN ALLEMAND 
namespace DEMO_POO_Props_Indexeurs.Models
{
    public class Charakter
    {
        // Champs (Donnée brute)
        private string _Name;

        private List<Ausstattung> AusstattungListe;

        // Encapsulation (getters/setters)
        /* Exemple de getter/setter classique cachés derrieres les propriétés
        //public void SetName(string name)
        //{
        //    _Name = name;
        //}

        //public string GetName()
        //{
        //    return _Name;
        //}

        // Perso.SetName(perso.GetName() + "!"); // "Jean" => "Jean!" --> pour modifier on est en set et pour lire on est en get, on ne peut pas faire les deux en même temps
        Perso.Name = perso.Name + "!"; // "Jean" => "Jean!" on fait des priorités qui cachent des données
        */

        // - Propriétés (encapsulation améliorée, syntaxe plus simple)
        public string Name
        {
            get { return _Name; }
            set { _Name = value.ToUpper(); } // On peut faire des traitements dans les accesseurs, ici on force le nom à être en majuscules
        }

        public int Lebenspunkte { get; set; } // Auto-implémentée (pas de champ privé, le compilateur gère ça pour nous)

        public string CharakterKlasse { get; set; }


        public double Gewicth { get; set; }

        public double MaximalGewicht { get; set; }


        // - Indexeurs (permet d'accéder à une collection de manière plus intuitive, comme un tableau)

        public List<Ausstattung> this[string kategorie] // Indexeur pour accéder à l'équipement du personnage (on aurait pu écrire n'importe quoi)
        {
            get
            {
                List<Ausstattung> ausstattungGefunden = [];
                foreach (Ausstattung items in AusstattungListe) 
                {
                    if (items.Kategorie == kategorie)
                    {
                        ausstattungGefunden.Add(items);
                    }
                }
                return ausstattungGefunden;
            }

        }


    }



}
