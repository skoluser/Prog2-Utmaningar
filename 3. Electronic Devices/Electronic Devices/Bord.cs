using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Devices
{
    class Bord : MinaSaker
    {
        public Bord(string namn, int vikt, int värde) : base(namn, vikt, värde)
        {
        }

        public override void Information2()
        {
            Console.WriteLine("Bord är möbler gjorda för att ha saker på");
        }
    }
}
