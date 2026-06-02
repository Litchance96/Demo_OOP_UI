using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Heritage.Models
{
    public class Dog : Animal  //HERITAGE LES DEUX POINTS POUR LES TRUCS EN COMMUN ENTRE LES ANIMAUX
    {
        public string Race { get; set; }

        public string Color { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Istrained { get; set; }

    }
}
