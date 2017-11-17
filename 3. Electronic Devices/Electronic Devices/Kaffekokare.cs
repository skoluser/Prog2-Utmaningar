using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Devices
{
    class Kaffekokare : MinaSaker, IElektronik
    {
        public Kaffekokare(string namn, int vikt, int värde) : base(namn, vikt, värde)
        {
        }

        public override void Information2()
        {
            Console.WriteLine("Kaffekokare är till för att koka kaffe");
        }

        public void Off()
        {
            Console.WriteLine("Kaffekokaren slutar brygga kaffe");
        }

        public void On()
        {
            Console.WriteLine("Kaffekokaren börjar brygga kaffe");
        }
    }
}
