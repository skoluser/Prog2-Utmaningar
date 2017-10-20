using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    //Abstrakt
    abstract class Reptiles : Animals
    {
        //Konstruktor
        public Reptiles(string name, string sound, string texture) : base(name, sound, texture) { }

        //Abstrakt
        abstract public void CheckReptileActivity();
    }
}
