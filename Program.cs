using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp1ParrotTrouble
{
    internal class Program
    {
        static void Main(string[] args) {

            Console.WriteLine(parrotTrouble(true, 6));
            Console.WriteLine(parrotTrouble(true, 7));
            Console.WriteLine(parrotTrouble(false, 6));
            Console.ReadLine();


        }

        static Boolean parrotTrouble(Boolean talking, int hour) {

            if (talking == true && hour < 7 || hour > 20)
            {

                return true;

            }

            else {

                return false;
            
            }
        
        }
    }
}
