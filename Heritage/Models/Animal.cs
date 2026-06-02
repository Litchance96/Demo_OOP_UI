using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }

        public void Sleep(int hours)
        {
            Console.WriteLine($"{Name} is sleeping for {hours} hours.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }
    }
}
