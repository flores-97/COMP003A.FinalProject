using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Minifigs : Lego // will add name, Lego minifig ID, paid price, resale price.
    {
        //auto implemented property
        public string MinifigID { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="minifigID"></param>
        /// <param name="legoName"></param>
        /// <param name="legoPrice"></param>
        /// <param name="legoResale"></param>
        public Minifigs(string minifigID, string legoName, double legoPrice, double legoResale)
        {
            MinifigID = minifigID;
            LegoName = legoName;
            LegoPrice = legoPrice;
            LegoResale = legoResale;
        }

        //method
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun collecting :D.");
        }
    }
}
