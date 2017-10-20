using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bunny : Mammals
    {
        //Kaniner har många ungar, men hur många exakt?
        private int bunnylings;

        //Konstruktor som tar in en extra variabel unik för Bunny-klassen
        public Bunny(string name, string sound, string texture, int bunnylings) : base(name, sound, texture)
        {
            this.bunnylings = bunnylings;
        }

        //AnimalInfo override!
        public override void AnimalInfo()
        {
            Console.WriteLine($"This bunny's name is {name}. \n{name} says {sound}. \nBunnies have {texture}.");
        }

        //Metod för kaniner
        public void CheckBunnyGeneaology()
        {
            Console.WriteLine($"{name} has {bunnylings} kids.");
        }
    }
}
