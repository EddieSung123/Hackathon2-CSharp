﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 數值判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1; i<101; i++)
            {
                if(i % 3 != 0 || i % 5 != 0)
                {
                    Console.Write(i +",");
                }
               
            }
            Console.ReadLine();

        }
    }
}
