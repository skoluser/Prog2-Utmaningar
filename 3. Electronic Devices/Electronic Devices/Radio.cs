using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Devices
{
    class Radio : MinaSaker, IElektronik
    {
        public Radio(string namn, int vikt, int värde) : base(namn, vikt, värde)
        {
        }

        public override void Information2()
        {
            Console.WriteLine("Radion kan ta emot ljudmeddelanden(?) via radiovågor");
        }

        public void Off()
        {
            Console.WriteLine("Inget händer; slut på batteri");
        }

        public void On()
        {
            Console.WriteLine("Inget händer; slut på batteri");
        }
    }
}
