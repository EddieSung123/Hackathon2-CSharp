using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字 : ");
            string input = Console.ReadLine();
            var value2 = input.ToCharArray();
            string A = "";
            string B = "";
            string C = "";
            foreach (var item in value2)
            {
                int item2 = Convert.ToInt32(item);

                switch (item2)
                {
                    case '0':
                        A+=" _ ";
                        B+="| |";
                        C+="|_|";
                        break;
                    case  '1':
                        A+=" ";
                        B+="|";
                        C+="|";
                        break;
                    case '2':
                        A+=" _ ";
                        B+=" _|";
                        C+="|_ ";
                        break;
                    case '3':
                        A+=" _ ";
                        B+=" _|";
                        C+=" _|";
                        break;
                    case '4':
                        A += "   ";
                        B += "|_|";
                        C += "  |";
                        break;
                    case '5':
                        A += " _ ";
                        B += "|_ ";
                        C += " _|";
                        break;
                    case '6':
                        A += " _ ";
                        B += "|_ ";
                        C += "|_|";
                        break;
                    case '7':
                        A += " _ ";
                        B += "  |";
                        C += "  |";
                        break;
                    case '8':
                        A += " _ ";
                        B += "|_|";
                        C += "|_|";
                        break;
                    case '9':
                        A += " _ ";
                        B += "|_|";
                        C += " _|";
                        break;
                    default:
                        A += "無法顯示";
                        B += "";
                        C += "";
                        break;
                }                  
            }
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.ReadLine();

            

              
                
        }
    }
}
