using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay1
{
    class if_and_else
    {
        static void Main()
        {
            string Signal;
            Console.WriteLine("enter the signal=");
            Signal = Console.ReadLine();
            Signal = Signal.ToUpper();
            Console.WriteLine("your entry=" + Signal);
            if (Signal == "GREEN")
                Console.WriteLine("Move");
            else if (Signal == "RED")
                Console.WriteLine("Stop");
            else if (Signal == "ORANGE")
                Console.WriteLine("Start");
            else
                Console.WriteLine("invalid entry");

        }
    }
}
