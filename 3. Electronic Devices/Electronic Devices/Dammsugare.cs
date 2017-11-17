using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Devices
{
    class Dammsugare : MinaSaker, IElektronik
    {
        public Dammsugare(string namn, int vikt, int värde) : base(namn, vikt, värde)
        {
        }

        public override void Information2()
        {
            Console.WriteLine("Dammsugare är till för att hålla rent");
        }

        public void Off()
        {
            Console.WriteLine("Nu blev det tyst");
        }

        public void On()
        {
            Console.WriteLine("Dammsugaren börjar suga. Den låter illa");
        }
    }
}
