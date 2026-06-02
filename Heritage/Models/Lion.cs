using System;
using System.Collections.Generic;
using System.Text;
using Heritage.EnumsCustom;

namespace Heritage.Models
{
    public class Lion : Feline
    {
        public double VerticalJumpMax { get; set; }

        public double ManeSize { get; set; }

        public override void SharpenClaws() //OVERRIDE => Redéfinition de la méthode de la classe parente (Feline, "virtual"), permet de personnaliser le comportement pour les lions
        {
            Console.WriteLine($"{Name} à démoli le salon.");
        }
    }
}
