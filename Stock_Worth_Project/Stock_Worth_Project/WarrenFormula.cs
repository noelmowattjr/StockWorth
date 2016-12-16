using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Worth_Project
{
    class WarrenFormula
    {
        private double D_E_Ratio;
        private double BookValue;
        private double MarketValue;
        private string Company;

        //--Constructor
        public WarrenFormula(double d_e_ratio, double bookvalue, double marketvalue, string company)
        {
            D_E_Ratio = d_e_ratio;
            BookValue = bookvalue;
            MarketValue = marketvalue;
            Company = company;
        }

        //-------------------Getters and Setters--------------------------//
        public double DERatio_GS
        {
            get { return D_E_Ratio; }
            set { D_E_Ratio = value; }
        }

        public double BookValue_GS
        {
            get { return BookValue; }
            set { BookValue = value; }
        }
        
    }
}
