using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Worth_Project
{
    interface IEvaluate
    {
        double DEratio();
        double CurrentRatio();
        bool Undervalued();
    }

    class Formula : IEvaluate
    {
        public double DEratio()
        {
            return 1.1;
        }

        public double CurrentRatio()
        {
            return 1.0;
        }

        public bool Undervalued()
        {
            return true;
        }
    }
}
