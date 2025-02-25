using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.FinalProject
{
    internal abstract class Lego //base
    {
        private string _legoName;
        private int _legoPrice;
        private int _legoResale;

        /// <summary>
        /// constructor
        /// </summary>
        public string LegoName 
        {
            get
            { 
                return _legoName; 
            }
            set
            {
                if (LegoName == "")
                {
                    throw new ArgumentException("Enter the Lego name: ");
                }
                else
                {
                    LegoName = value;
                }
            }
        }
        public int LegoPrice
        {
            get
            {
                return _legoPrice;
            }
            set
            {
                _legoPrice = value;
            }
        }
        public int LegoResale
        {
            get
            {
                return _legoResale;
            }
            set
            {
                _legoResale = value;
            }
        }

        public abstract void DisplayInfo();

        public abstract void Awesome();
    }
}
