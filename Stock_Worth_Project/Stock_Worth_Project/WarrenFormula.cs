using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Worth_Project
{
    class WarrenFormula
    {
        private readonly double D_E_Ratio;
        private readonly double BookValue;
        private readonly double MarketValue;
        private readonly string Company;

        //--Constructor
        public WarrenFormula(double d_e_ratio, double bookvalue, double marketvalue, string company)
        {
            D_E_Ratio = d_e_ratio;
            BookValue = bookvalue;
            MarketValue = marketvalue;
            Company = company;
        }
        
    }
}
