using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bird : Avifauna
    {
        //Konstruktor
        public Bird(string name, string sound, string texture, string rating) : base(name, sound, texture, rating) { }

        //DjurInfo override!
        public override void AnimalInfo()
        {
            Console.WriteLine($"This bird's name is {name}. \n{name} says {sound}. \nBirds have {texture}.");
        }

        //Rate a birb
        public override void RateBird()
        {
            Console.WriteLine($"This bird is rated {rating}");
        }
    }
}
