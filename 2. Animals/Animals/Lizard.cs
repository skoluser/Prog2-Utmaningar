using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Lizard : Reptiles
    {
        //Konstruktor
        public Lizard(string name, string sound, string texture) : base(name, sound, texture) { }

        //AnimalInfo överskrid!
        public override void AnimalInfo()
        {
            Console.WriteLine($"This reptile's name is {name}. \n{name} says {sound}. \nReptiles have {texture}.");
        }

        //Checkar reptilens aktivitet
        public override void CheckReptileActivity()
        {
            Console.WriteLine("The lizard is doing nothing.");
        }
    }
}
