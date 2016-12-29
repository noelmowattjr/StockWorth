using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Worth_Project
{
    class WarrensFourRules
    {
        private bool HasVigilantLeaders;
        private bool HasLongTermProspects;
        private bool StockIsStableAndUnderstandable;
        private bool IsUnderValued;

        //--Constructor
        public WarrensFourRules(bool hasVigilantLeaders, bool hasLongTermProspects, bool stockStableUnderstandable, bool isUndervalued)
        {
            HasVigilantLeaders = hasVigilantLeaders; HasLongTermProspects = hasLongTermProspects;
            StockIsStableAndUnderstandable = stockStableUnderstandable; IsUnderValued = isUndervalued;
        }

        //--------------Getters & Setters--------------------//
        public bool _HasVigilantLeaders
        {
            get { return HasVigilantLeaders; }
            set { HasVigilantLeaders = value; }
        }

        public bool _HasLongTermProspects
        {
            get { return HasLongTermProspects; }
            set { HasLongTermProspects = value; }
        }

        public bool _StockIsStableAndUnderstandable
        {
            get { return StockIsStableAndUnderstandable; }
            set { StockIsStableAndUnderstandable = value; }
        }

        public bool _IsUnverValued
        {
            get { return IsUnderValued; }
            set { IsUnderValued = value; }
        }
    }
}
