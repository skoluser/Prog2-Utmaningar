using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sub1 : Subway_Station
    {
        public Sub1(string name) : base(name)
        {
        }

        protected override void Goto(string input)
        {
            switch (input)
            {
                case "y":
                    Console.WriteLine("Now leaving station 1...");
                    break;
                default:
                    break;
            }
        }
    }
}
