using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Minifig : Lego, ILegoConstruct // will add name, Lego minifig ID, paid price, resale price.
    {
        //auto implemented property
        public string MinifigID { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="minifigsID"></param>
        /// <param name="legoName"></param>
        /// <param name="legoPrice"></param>
        /// <param name="legoResale"></param>
        public Minifig(string minifigsID, string legoName, int legoPrice, int legoResale)
        {
            MinifigID = minifigsID;
            LegoName = legoName;
            LegoPrice = legoPrice;
            LegoResale = legoResale;
        }

        public int legoPrice
        {
            get { return legoPrice; }
            set { legoPrice = value; }
        }
        public int legoResale
        {
            get { return LegoResale; }
            set { legoResale = value; }
        }

        //method
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun collecting :D.");
        }

        public void Construction()
        {
            Console.WriteLine("Note: Lego minifigure collected. Be mindful of budget!");
        }
    }
}
