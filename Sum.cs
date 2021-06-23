using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay1
{
    class Sum
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b");
            b = Convert.ToInt32(Console.ReadLine());
            int add = a + b;
            Console.WriteLine("Add=" + add);
        }
    }
}
