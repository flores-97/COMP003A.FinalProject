using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Set : Lego //will have lego set name, set number, msrp, resale price
    {
        //auto implemented property
        public string SetNumber { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="setNumber"></param>
        /// <param name="legoName"></param>
        /// <param name="legoPrice"></param>
        /// <param name="legoResale"></param>
        public Set(string  setNumber, string legoName, int legoPrice, int legoResale)
        {
            SetNumber = setNumber;
            LegoName = legoName;
            LegoPrice = legoPrice;
            LegoResale = legoResale;
        }

        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun building :D.");
        }
    }
}
