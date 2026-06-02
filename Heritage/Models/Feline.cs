using System;
using System.Collections.Generic;
using System.Text;
using Heritage.EnumsCustom;

namespace Heritage.Models
{
    public class Feline : Animal
    {
        public CoatTypeEnum CoatType { get; set; }

        public bool CanBePetted { get; set; }

        public virtual void SharpenClaws() //VIRTUAL => Version par défaut, permet de dire que cette méthode peut être redéfinie dans les classes filles (Lion, Chat, etc.), il autorise un OVERRIDE.
        {
            Console.WriteLine($"{Name} fait ses griffes.");
        }
    }
}
