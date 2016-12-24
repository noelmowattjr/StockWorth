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

            //------------------------Warren Buffet's 4 Rules------------------------------//

            //--Rule 1 - Is the company managed by vigilant leaders?--//
            //--What is the D/E ratio and current ratio?
            Console.Write("Enter the company's name: ");
            string company = Console.ReadLine();

            Console.Write("Enter the total liabilities for 10 years: ");
            string liabilities = Console.ReadLine();

            Console.Write("Enter the total equity for 10 years: ");
            string equity = Console.ReadLine();

            //--Calculate with custom method here


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
