using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals 
{
    class Program //Hugo
    {
        static void Main(string[] args)
        {
            //Skapar djur
            Bunny kanin = new Bunny("Marmelade", "\"seize the means of production\"", "fur", 3);
            Bird birb = new Bird("Gaston", "CAAAWW", "feathers", "5 stars");
            Lizard ödla = new Lizard("Manfroy", "\"OwO what's this?\"", "scales");

            //Använder djurens metoder(?)
            kanin.AnimalInfo();
            kanin.CheckBunnyGeneaology();

            Console.WriteLine();

            birb.AnimalInfo();
            birb.RateBird();

            Console.WriteLine();

            ödla.AnimalInfo();
            ödla.CheckReptileActivity();

            Console.ReadLine();
        }
    }
}
