using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Set: Lego, ILegoConstruct //derived class will have lego set name, set number, msrp, resale price
    {
        public Set(string legoID, string legoName, double legoPrice, double legoResale) : base(legoName, legoPrice, legoResale)
        { }
        //method
        public override void Awesome()
        {
            Console.WriteLine("Everything is awesome! Have fun building :D.");
        }
        public void Construction()
        {
            Console.WriteLine("Warning: Set under construction. Come back soon!");
        }
    }
}
