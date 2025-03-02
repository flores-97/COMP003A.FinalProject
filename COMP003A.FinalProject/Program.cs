// Author: Victor Flores
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Final Project
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Xml.Linq;
using COMP003A.FinalProject;
using Microsoft.VisualBasic;

namespace COMP003A.LegoInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lego> legos = new List<Lego>();

            Console.WriteLine("Welcome to the awesome Lego Inventory Management System!");

            int choice;

            while (true)
            {
                Console.WriteLine("\nInventory Management System Menu: \n");
                Console.WriteLine("1. Add a Lego Set");
                Console.WriteLine("2. Add a Lego Minifigure");
                Console.WriteLine("3. Remove a Lego");
                Console.WriteLine("4. Display All Lego");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                string legoID, legoName;
                double legoPrice, legoResale;

                if (choice == 5) break;

                else if (choice == 1)
                {
                    while (true)
                    {
                        //enter a set
                        try
                        {
                            Console.Write("\nEnter the number of the set: ");
                            legoID = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(legoID)) throw new Exception("\nSet's number cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the name of the Set: ");
                            legoName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(legoName)) throw new Exception("\nSet's name cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price paid: $");
                            legoPrice = Convert.ToDouble(Console.ReadLine());
                            if (legoPrice <= 0) throw new Exception("\nPrice cannot be less than 0.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price of resale: $");
                            legoResale = Convert.ToDouble(Console.ReadLine());
                            if (legoResale <= 0) throw new Exception("\nResale price cannot be less than 0.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }
                    Set set = new Set(legoID, legoName, legoPrice, legoResale);
                    legos.Add(set);
                    Console.WriteLine("\nLego Set built successfully!");
                    ((Set)legos.Last()).Awesome();
                    ((Set)legos.Last()).Construction();
                }

                else if (choice == 2)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nEnter the minifigure ID: ");
                            legoID = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(legoID)) throw new Exception("\nMinifigure's ID cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    while (true)
                    {
                        //enter a minifigure
                        try
                        {
                            Console.Write("Enter the name of the minifigure: ");
                            legoName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(legoName)) throw new Exception("\nMinifigure's name cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price paid: $");
                            legoPrice = Convert.ToDouble(Console.ReadLine());
                            if (legoPrice <= 0) throw new Exception("\nPrice cannot be less than 0.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price of resale: $");
                            legoResale = Convert.ToDouble(Console.ReadLine());
                            if (legoResale <= 0) throw new Exception("\nResale price cannot be less than 0.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }
                    Minifig minifig = new Minifig(legoID, legoName, legoPrice, legoResale);
                    legos.Add(minifig);
                    Console.WriteLine("\nMinifigure added successfully!");
                    ((Minifig)legos.Last()).Awesome();
                    ((Minifig)legos.Last()).Construction();
                }

                else if (choice == 3)
                {
                    //if item sold this will remove 
                    //assited by StackOverflow
                    Console.Write("\nWhich Lego was sold: ");
                    string removedLego = Console.ReadLine();

                    int removedCount = legos.RemoveAll(lego => lego.LegoName.Equals(removedLego));
                    if (removedCount > 0)
                    {
                        Console.WriteLine($"{removedCount} {removedLego} removed");
                    }
                    else
                    {
                        Console.WriteLine("Lego not found. Review inventory list.");
                    }
                }

                else if (choice == 4)
                {

                    Console.WriteLine("\nRunning Total");
                    Console.WriteLine($"Total Lego: {legos.Count}");//total lego sets and minifigures
                    Console.WriteLine($"Total Spent: ${legos.Sum(lego => lego.LegoPrice)}");//adds entire price paid in total 
                    Console.WriteLine($"Potential Resale: ${legos.Sum(lego => lego.LegoResale)}");//adds entire resale potential in total
                    Console.WriteLine($"Total Profit: ${legos.Sum(lego => lego.LegoResale) - legos.Sum(lego => lego.LegoPrice)}");//adds entire possible profit
                    foreach (Lego lego in legos)
                    {
                        Console.WriteLine($"-{lego.LegoName}: ${lego.LegoPrice}");//display lego name and price paid 
                    }
                }

                else 
                {
                    Console.WriteLine("\nInvalid entry. Select an option on the menu.\n");
                }
            }
        }//ends program
    }
}
