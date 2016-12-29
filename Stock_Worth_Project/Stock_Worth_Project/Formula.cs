using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Worth_Project
{
    interface IEvaluate
    {
        double DEratio(double li, double eq);
        double CurrentRatio(double assets, double li);
        bool Undervalued(double intrinsicValue, double marketValue);
    }

    class Formula : IEvaluate
    {
        public double DEratio(double li, double eq)
        {
            return li / eq;
        }

        public double CurrentRatio(double assets, double li)
        {
            return assets / li;
        }

        public bool Undervalued(double intrinsicValue, double marketValue)
        {
            return intrinsicValue > marketValue;
        }
    }
}
