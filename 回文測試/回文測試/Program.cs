using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文測試
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入要判斷的文字 : ");
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string input2 = new string(array);
            if (input == input2)
            {
                Console.WriteLine($"{input}  是回文");
            }
            else
            {
                Console.WriteLine($"{input2}  不是回文");
            }
            Console.ReadLine();
        }

       
      }
    }

