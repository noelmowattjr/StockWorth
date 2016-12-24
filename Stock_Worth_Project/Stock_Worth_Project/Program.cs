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
            /*  Noel Mowatt, Jr.    */

            Formula formula = new Formula();

            //------------------------Warren Buffet's 4 Rules------------------------------//
            double liabilities; double equity;

            //--Rule 1 - Is the company managed by vigilant leaders?--//
            //--What is the D/E ratio and current ratio?
            Console.Write("Enter the company's name: ");
            string company = Console.ReadLine();

            Console.Write("Enter the total liabilities for 10 years: ");
            string entryLi = Console.ReadLine();

            //--Validate and convert to double for liabilities entry
            while (!(double.TryParse(entryLi, out liabilities)))
            {
                Console.Write("Invalid!\r\nPlease enter a numeric value for liabilities: ");
                entryLi = Console.ReadLine();
            }

            Console.Write("Enter the total equity for 10 years: ");
            string entryEq = Console.ReadLine();
            while (!(double.TryParse(entryEq, out equity)))
            {
                Console.Write("Invalid!\r\nPlease enter a numeric value for equity: ");
                entryEq = Console.ReadLine();
            }

            //--Calculate with custom method here
            var debtTOequityRatio = Math.Round(formula.DEratio(liabilities, equity), 2);
            Console.WriteLine("The D/E Ration for {0} is {1}", company, debtTOequityRatio);

            //--Rule 2 - Does the company has long term prospects?
            //--Are earnings sustainable? Is the company likely to be around 30 years from now?
            Console.Write("Enter the industry: ");
            string industry = Console.ReadLine();

            Console.Write("What is {0}'s commodity: ", company);

            //--Rule 3 - Is the stock stable and understandable?
            //--Is the debt to equity history stable and are you able to determine an intrinsic value accurately?

            //--Rule 4 - Is the stock undervalued?
            
            //-------------If all 4 rules are met, then stock is a buy------------//
        }
    }
}
