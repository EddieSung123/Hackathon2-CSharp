using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 買雞
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.0;
            double y = 0.0;
            double z = 0.0;

            while(((x + y + z) != 100.0) && ((60*x) + (30*y) + (z)) != 1000.0)
            {
                x++;
                if(((900.0 - (59.0 * x)) % 29.0) == 0.0)
                {
                    y = (((900.0) - (59.0 * x)) / 29.0);
                    z = (100.0 - x - y);
                }
            }
            Console.WriteLine($"公雞 : {x} 母雞 : {y} 小雞 : {z}");
            Console.ReadLine();
        }
    }
}
