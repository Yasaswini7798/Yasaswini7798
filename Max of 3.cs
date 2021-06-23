using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay1
{
    class Max_of_3
    {

        static void Main()
        {
            int a, b, c, max;
            Console.WriteLine("enter value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of c");
            c = Convert.ToInt32(Console.ReadLine());
            //max = (a > b) ? (a>c ?a:c):(b>c?b:c);
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }

                else
                {
                    max = c;
                }

            }

            else if (b > c)
                max = b;
            else
                max = c;

            Console.WriteLine("betweeen {1} {2} {3} between max={0}",max,a, b,c);

        }
    }
}
