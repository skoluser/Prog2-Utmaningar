using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Avifauna : Animals
    {
        //Variabel för fågelns rating
        protected string rating;

        //Konstruktor som tar in en extra variabel unik för Avifauna-klassen
        public Avifauna(string name, string sound, string texture, string rating) : base(name, sound, texture)
        {
            this.rating = rating;
        }

        //Rate:a fågeln.
        abstract public void RateBird();
    }
}
