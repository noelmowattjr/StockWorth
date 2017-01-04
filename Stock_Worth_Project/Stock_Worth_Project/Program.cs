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

            //--Average change for 10 years--//

            //--Enter current book value
            Console.Write("Current book value: ");
            string currBookValue = Console.ReadLine(); double CurrBook;
            while (!(double.TryParse(currBookValue, out CurrBook)))
            {
                Console.Write("Invalid!\r\nCurrent book value");
                currBookValue = Console.ReadLine();
            }

            //--Enter old book value
            Console.Write("Old book value: ");
            string oldBookVaue = Console.ReadLine(); double OldBook;
            while (!(double.TryParse(oldBookVaue, out OldBook)))
            {
                Console.Write("Invalid!\r\nOld book value: ");
                oldBookVaue = Console.ReadLine();
            }

            //--Number of years between book values
            Console.Write("Numbr of years between book value? "); double yrz;
            string years = Console.ReadLine();
            while (!(double.TryParse(years, out yrz)))
            {
                Console.Write("Invalid!\r\nEnter num of years between book values");
                years = Console.ReadLine();
            }

            //--Find percentage increase
            var percIncreased = PercentIncreaseBy(CurrBook, OldBook); Console.WriteLine("Percent increase {0}", percIncreased);
            var tenYearIncrease = percIncreased * 10;

            Console.WriteLine("Here's the 10 year percent increase "+tenYearIncrease);


            //--Average book value change Formula: FV = PV(1 + i)^n
            /*  FV = Current Book Value
                PV = Old Book Value
                i = Solving for i
                n = the number of years between book values (exponent)*/
            
        }
        public static double PercentIncreaseBy(double newNum, double oldNum)
        {
            double theIncrease = newNum / oldNum;
            double percentIncrease = (oldNum / theIncrease) / 100;
            return percentIncrease;
        }
    }
}
