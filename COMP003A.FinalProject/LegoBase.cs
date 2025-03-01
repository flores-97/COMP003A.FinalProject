using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    abstract class Lego
    {
        //field
        private string _legoID;
        private string _legoName;
        private double _legoPrice;
        private double _legoResale;
        /// <summary>
        /// properties
        /// </summary>
        /// 
        public string LegoID
        {
            get { return _legoID; }
            set
            {
                if (string.IsNullOrEmpty(value)) ;
                else
                {
                    _legoID = value;
                }
            }
        }
        public string LegoName
        {
            get { return _legoName; }
            set
            {
                if (string.IsNullOrEmpty(value)) ;
                else
                {
                    _legoName = value;
                }
            }
        }

        public double LegoPrice
        {
            get { return _legoPrice; }
            set
            {
                if (value >= 0)
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
                if (value >= 0)
                {
                    _legoResale = value;
                }
            }
        }

        List<double> LegoPrices = new List<double>();
        List<double> LegoResales = new List<double>();


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="legoID"></param>
        /// <param name="legoName"></param>
        /// <param name="legoPrice"></param>
        /// <param name="legoResale"></param>
        public Lego(string legoID, string legoName, double legoPrice, double legoResale)
        {
            LegoID = legoID;
            LegoName = legoName;
            LegoPrice = legoPrice;
            LegoResale = legoResale;
        }

        protected Lego(string legoName, double legoPrice, double legoResale)
        {
            LegoName = legoName;
            LegoPrice = legoPrice;
            LegoResale = legoResale;
        }

        public virtual void DisplayLegoFinance()
        {
            Console.WriteLine($"Total spent: {LegoPrices.Sum()}");//meant to display total spent
            Console.WriteLine($"Potential resale value: ${LegoResales.Sum()}");//meant to display potential resale value
            Console.WriteLine($"Lego Profit: ${LegoResales.Sum() - LegoPrices.Sum()}\n");//if lego sold, meant to display how much profit
        }

        public virtual void RemoveLego()
        {
        }
        public abstract void Awesome();
    }
}
