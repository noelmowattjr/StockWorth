using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Worth_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt, Jr.    
                Stock App Project */

            //--Percentage increase for 10 years--//

            //--Enter current book value
            Console.Write("Current book value: ");
            string currBookValue = Console.ReadLine(); int CurrBook;
            while (!(int.TryParse(currBookValue, out CurrBook)))
            {
                Console.Write("Invalid!\r\nCurrent book value");
                currBookValue = Console.ReadLine();
            }

            //--Enter old book value
            Console.Write("Old book value: ");
            string oldBookVaue = Console.ReadLine(); int OldBook;
            while (!(int.TryParse(oldBookVaue, out OldBook)))
            {
                Console.Write("Invalid!\r\nOld book value: ");
                oldBookVaue = Console.ReadLine();
            }

            //--Number of years between book values
            Console.Write("Numbr of years between book value? "); int yrz;
            string years = Console.ReadLine();
            while (!(int.TryParse(years, out yrz)))
            {
                Console.Write("Invalid!\r\nEnter num of years between book values");
                years = Console.ReadLine();
            }

            //--Average book value change
   
        }
    }
}
