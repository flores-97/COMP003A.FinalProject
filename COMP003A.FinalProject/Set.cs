using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Set : Lego, ILegoConstruct //will have lego set name, set number, msrp, resale price
    {
        //method
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun building :D.");
        }
        public override void DisplayLegoFinance()
        {
            Console.WriteLine($"\nTotal Lego in inventory: {legoName.Count}");//how many items in inventory 
            Console.WriteLine($"Total spent: {legoPrice.Sum()}");//meant to display total spent
            Console.WriteLine($"Potential resale value: ${legoResale.Sum()}");//meant to display potential resale value
            Console.WriteLine($"Lego Profit: ${legoResale.Sum() - legoPrice.Sum()}\n");//if lego sold, meant to display how much profit
        }

        public void Construction()
        {
            Console.WriteLine("Warning: Set under construction. Come back soon!\n");
        }
    }
}
