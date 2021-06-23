using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay1
{
    class Max_of_2
    {

        static void Main()
        {
            int a, b, max;
            Console.WriteLine("enter value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b");
            b = Convert.ToInt32(Console.ReadLine());
            max = (a > b) ? a : b;
            Console.WriteLine("betweeen {1} and {2} MAX={0}", max, a, b);

        }
    }
}
