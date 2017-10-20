using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    //Abstrakt klass
    abstract class Animals
    {
        //Variabler gemensamma för alla djur
        protected string name, sound, texture;

        //Konstruktor
        public Animals(string name, string sound, string texture)
        {
            this.name = name;
            this.sound = sound;
            this.texture = texture;
        }

        //Abstrakt, kommer skriva ut info om djuret
        abstract public void AnimalInfo();
    }
}
