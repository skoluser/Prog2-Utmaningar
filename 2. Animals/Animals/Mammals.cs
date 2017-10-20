using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Mammals : Animals
    {
        //Konstruktor
        public Mammals(string name, string sound, string texture) : base(name, sound, texture) { }
    }
}
