﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Set : Lego, ILegoConstruct //will have lego set name, set number, msrp, resale price
    {
        private List<string> setNumber;
        private List<string> legoName;
        private List<int> legoPrice;
        private List<int> legoResale;

        //auto implemented property
        public string SetNumber
        {
            get
            {
                return SetNumber;
            }
            set
            {
                if (SetNumber == "")
                {
                    throw new ArgumentException("Enter the Lego set number.");
                }
                else
                {
                    SetNumber = value;
                }
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="setNumber"></param>
        /// <param name="legoName"></param>
        /// <param name="legoPrice"></param>
        /// <param name="legoResale"></param>

        public Set(List<string> setNumber, List<string> legoName, List<int> legoPrice, List<int> legoResale)
        {
            this.setNumber = setNumber;
            this.legoName = legoName;
            this.legoPrice = legoPrice;
            this.legoResale = legoResale;
        }

        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun building :D.");
        }

        public void Construction()
        {
            Console.WriteLine("Warning: Set under construction. Come back soon!\n");
        }

        public override void DisplayInfo()
        {
            foreach (var item in SetNumber)
            {
                Console.WriteLine($"{setNumber} - {legoName}: ${legoPrice}");
            }
        }

    }
}
