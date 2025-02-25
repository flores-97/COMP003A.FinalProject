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
        public string LegoName { get; set; }
        public int LegoPrice { get; set; } = 0;
        public int LegoResale { get; set; } = 0;
        public abstract void Awesome();
    }
}
