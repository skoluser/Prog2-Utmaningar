using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Devices
{
    class MinaSaker
    {
        string namn;
        double vikt, värde;

        public MinaSaker(string namn, double vikt, double värde)
        {
            this.namn = namn;
            this.vikt = vikt;
            this.värde = värde;
        }

        public void Information()
        {
            Console.WriteLine($"Vad är detta? - {namn}\nVad väger detta? - {vikt}kg\nVad er den vaerd? - {värde} dkk");
        }

        public virtual void Information2()
        {
        }
    }
}
