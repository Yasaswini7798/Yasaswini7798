using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay1
{
    class Switch
    {
        static void Main()
        {
            int ch, qty=0, price=0;
            Console.WriteLine("1 IDLY(35)");
            Console.WriteLine("2 DOSA(50)");
            Console.WriteLine("3 PARATHA(45)");
            Console.WriteLine("4 UPMA(40)");
            Console.WriteLine("5 TEA/COFFEE(10)");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch >= 1 && ch <= 5)
            {
                Console.WriteLine("enter the quantity=");
                qty = Convert.ToInt32(Console.ReadLine());
            }
            switch (ch)
            {
                case 1:
                    price = qty * 35;
                    break;
                case 2:
                    price = qty * 50;
                    break;
                case 3:
                    price = qty * 45;
                    break;
                case 4:
                    price = qty * 40;
                    break;
                case 5:
                    price = qty * 10;
                    break;
                default:
                    Console.WriteLine("Not valid");
                    break;
            }
            if (price != 0)
                Console.WriteLine("price=" + price);


        }
    }
}
