using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.FinalProject
{
    abstract class Lego //base
    {
        private string _legoID;
        private string _legoName;
        private double _legoPrice;
        private double _legoResale;
        /// <summary>
        /// properties
        /// </summary>
        public string LegoID
        { get { return _legoID; } }

        public string LegoName
        {
            get { return _legoName; }
            set { _legoName = value; }
        }

        public double LegoPrice
        {
            get { return _legoPrice; }
            set
            {
                if (value <= -1)
                {
                    _legoPrice = value;
                }
            }
        }
        public double LegoResale
        {
            get { return _legoResale; }
            set
            {
                if (value <= -1)
                {
                    _legoResale = value;
                }
            }
        }
        public abstract void DisplayLegoFinance();
        public abstract void Awesome();
    }
}
