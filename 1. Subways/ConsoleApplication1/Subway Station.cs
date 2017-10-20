using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Subway_Station
    {
        //Namnet på stationen
        protected string name;

        //Konstruktor
        public Subway_Station(string name) { this.name = name; }

        //Abstrakt metod för att gå till station/stänga ner programmet
        protected abstract void Goto(string input);
    }
}
