using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Minifig : Lego, ILegoConstruct //derived class will add name, Lego minifig ID, paid price, resale price.
    {
        public Minifig(string legoID, string legoName, double legoPrice, double legoResale) : base(legoName, legoPrice, legoResale)
        { }
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
