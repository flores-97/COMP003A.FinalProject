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
        //method
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun collecting :D.");
        }
        public override void DisplayLegoFinance()
        {
            Console.WriteLine($"\nTotal Lego in inventory: {LegoName.Count}");//how many items in inventory 
            Console.WriteLine($"Total spent: {LegoPrice.Sum()}");//meant to display total spent
            Console.WriteLine($"Potential resale value: ${LegoResale.Sum()}");//meant to display potential resale value
            Console.WriteLine($"Lego Profit: ${LegoResale.Sum() - LegoPrice.Sum()}\n");//if lego sold, meant to display how much profit
        }
        public void Construction()
        {
            Console.WriteLine("Note: Lego minifigure collected. Be mindful of budget!\n");
        }
    }
}
