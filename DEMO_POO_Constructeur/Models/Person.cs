using System.Globalization;

namespace DEMO_POO_Constructeur.Models
{
    public class Person
    {

        //props full (si on écrit prosfull + Tab - il y aura déjà une version "pré-écrite" = raccourci): 

        //private string? _FirstName;

        //public virtual string? FirstName
        //{ 
        //get { return _FirstName; } 
        //set { _FirstName = value; } 
        //}

        //Autoprops

        // Propriété avec encapsulation
        public string LastName { get; private set; } 

        public string? FirstName { get; private set; }

        public DateTime BirthDate { get; private set; }

        public int Age 
        { 
            get
            {
                int tempAge = DateTime.Today.Year - BirthDate.Year;

                if(DateTime.Today < BirthDate)
                {
                    tempAge--;
                }

                return tempAge;

                // return (DateTime.Today >= BirthDate) ? tempAge : tempAge -1;
            }  
        }

        // Constructeur ->
        // - Méthode utilisée lors de l'instanciation
        // - Elle porte le même nom que la classe
        // - Ne possède pas de paramétres retour (donc rien, ni void, ni rien)


        public Person(string firstName, string lastName, DateTime birthDate) : this(lastName, birthDate)
        {
            this.FirstName = firstName;
;
        }

        // - Ca reste une méthode, la surcharge est autorisé évidemment 

        public Person(string lastName, DateTime birthDate)
        {
            this.FirstName = null;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
    }
}


//Dans programme.cs
//Person p = new Person("Della", "Duck", new Date...);