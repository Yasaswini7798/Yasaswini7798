using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay1
{
    class Avg
    {
        static void Main()
        {
            int m1, m2, m3, total = 0;
            float avg;
            Console.WriteLine("enter 3 marks");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
            avg = float.Parse(total.ToString()) / 3;
            Console.WriteLine("total="+avg);
            switch(avg>35?"pass":"fail")
            {
                case "pass":
                    Console.WriteLine("passed");
                    break;
                case "fail":
                    Console.WriteLine("failed");
                    break;
                default:
                    Console.WriteLine("Not Valid");
                    break;
            }
        }
    }
}
