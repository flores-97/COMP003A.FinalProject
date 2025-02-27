using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Set : Lego, ILegoConstruct //derived class will have lego set name, set number, msrp, resale price
    {
        public Set(string legoID, string legoName, double legoPrice, double legoResale) : base(legoID, legoName, legoPrice, legoResale)
        {
            LegoID = legoID;
            LegoName = legoName;
            LegoPrice = legoPrice;
            LegoResale = legoResale;
        }

        //method
        public override void DisplayLegoFinance()
        {
            Console.WriteLine($"Total Lego Inventory: {legoName.Count}");
            Console.WriteLine($"Total spent: {legoPrice.Sum()}");//meant to display total spent
            Console.WriteLine($"Potential resale value: ${legoResale.Sum()}");//meant to display potential resale value
            Console.WriteLine($"Lego Profit: ${legoResale.Sum() - legoPrice.Sum()}\n");//if lego sold, meant to display how much profit
        }
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun building :D.");
        }
        public void Construction()
        {
            Console.WriteLine("Warning: Set under construction. Come back soon!\n");
        }
    }
}
