using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{

    internal class Minifig : Lego, ILegoConstruct // will add name, Lego minifig ID, paid price, resale price.
    {
        private List<string> minifigID;
        private List<string> legoName;
        private List<int> legoPrice;
        private List<int> legoResale;

        //auto implemented property
        public string MinifigID
        {
            get
            {
                return MinifigID;
            }
            set
            {
                if (MinifigID == "")
                {
                    throw new ArgumentException("Enter the Lego minifigure name.");
                }
                else
                {
                    MinifigID = value;
                }
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="minifigID"></param>
        /// <param name="legoName"></param>
        /// <param name="legoPrice"></param>
        /// <param name="legoResale"></param>


        public Minifig(List<string> minifigID, List<string> legoName, List<int> legoPrice, List<int> legoResale)
        {
            this.minifigID = minifigID;
            this.legoName = legoName;
            this.legoPrice = legoPrice;
            this.legoResale = legoResale;
        }


        //method
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun collecting :D.");
        }

        public void Construction()
        {
            Console.WriteLine("Note: Lego minifigure collected. Be mindful of budget!\n");
        }

        public override void DisplayInfo()
        {
            foreach (var item in MinifigID)
            {
                Console.WriteLine($"{minifigID} - {legoName}: ${legoPrice}");
            }
        }
    }
}
