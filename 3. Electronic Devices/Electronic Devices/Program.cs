using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Devices
{
    class Program //Hugo
    {
        static void Main(string[] args)
        {
            List<object> hej = new List<object>();

            hej.Add(new Bord("bord", 8, 1400));
            hej.Add(new Radio("radio", 2, 500));
            hej.Add(new Dammsugare("dammsugare", 6, 750));
            hej.Add(new Kaffekokare("kaffekokare", 4, 450));

            foreach (MinaSaker item in hej)
            {
                item.Information();
                Console.WriteLine();
                item.Information2();

                if (item is IElektronik)
                {
                    Console.WriteLine("Detta föremål är elektroniskt (!!!)");
                    Console.WriteLine("Vad händer när man sätter på föremålet?");
                    IElektronik mojäng = (IElektronik)item;
                    mojäng.On();
                    Console.WriteLine();
                    Console.WriteLine("Vad händer när man stänger av föremålet?");
                    mojäng.Off();
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
