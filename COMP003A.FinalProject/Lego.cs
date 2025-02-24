using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal abstract class Lego //base
    {
        private string _legoName;
        private double _legoPrice;
        private double _legoResale;


        /// <summary>
        /// constructor
        /// </summary>
        public string LegoName { get; set; }
        public double LegoPrice { get; set; }
        public double LegoResale { get; set; }

        public abstract void Awesome();
    }
}
