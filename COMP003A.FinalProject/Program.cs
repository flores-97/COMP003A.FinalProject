// Author: Victor Flores
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using System.Net.Http.Headers;
using System.Xml.Linq;
using COMP003A.FinalProject;
using Microsoft.VisualBasic;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lego> legos = new List<Lego>();

            string minifigsID = Console.ReadLine();
            string setNumber = Console.ReadLine();
            string legoName = Console.ReadLine();
            int legoPrice = int.Parse(Console.ReadLine());
            int legoResale = int.Parse(Console.ReadLine());

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

                if (choice == 5) break;

                else if (choice == 1)
                {

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the number of the set: ");
                            string SetNumber = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(SetNumber)) throw new Exception("\nSet's number cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("\nEnter the name of the Set: ");
                            string LegoName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(LegoName)) throw new Exception("\nSet's name cannot be blank.");
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
                            Console.Write("Enter the retail price: ");
                            int LegoPrice = int.Parse(Console.ReadLine());
                            if (LegoPrice <= 0) throw new Exception("\nPrice cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price of resale: ");
                            int legoresale = int.Parse(Console.ReadLine());
                            if (legoResale <= 0) throw new Exception("\nResale price cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    Set set = new Set(setNumber, legoName, legoPrice, legoResale);
                    legos.Add(set);

                    Console.WriteLine("lego Set built successfully!");
                }

                else if (choice == 2)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the minifigure ID: ");
                            string MinifigID = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(MinifigID)) throw new Exception("\nSet's number cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("\nEnter the name of the minifigure: ");
                            string LegoName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(LegoName)) throw new Exception("\nSet's name cannot be blank.");
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
                            Console.Write("Enter the price paid: ");
                            int LegoPrice = int.Parse(Console.ReadLine());
                            if (LegoPrice <= 0) throw new Exception("\nPrice cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price of resale: ");
                            int legoresale = int.Parse(Console.ReadLine());
                            if (legoResale <= 0) throw new Exception("\nResale price cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    Minifigs minifigs = new Minifigs(setNumber, legoName, legoPrice, legoResale);
                    legos.Add(minifigs);

                    Console.WriteLine("Minifigure added successfully!");
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Which Lego item would you like to remove? ");
                    int index = legoName.IndexOf(Console.ReadLine());

                    if (index != -1)
                    {
                        Console.Write("How much did you sell it for? ");
                        legoResale.Equals(int.Parse((string)Console.ReadLine()));
                        Console.WriteLine("Lego sold. So not awesome.");
                        break;
                    }
                    else
                    {
                        {
                            Console.WriteLine("Lego not found. Review your Lego list in menu option 4.");
                            break;
                        }
                    }

                }

                else if (choice == 4)
                {
                    foreach (Lego lego in legos)
                    {
                        Console.WriteLine($"{lego.LegoName}");
                    }
                    Console.WriteLine($"Total Lego in inventory: {legoName.Length}");
                    Console.WriteLine($"Total spent: {legoPrice}");
                    Console.WriteLine($"Potential resale value: {legoResale}");
                    Console.WriteLine($"Lego Profit: {legoResale - legoPrice}");
                }

                else
                {
                    Console.WriteLine("\nInvalid entry. Select an option on the menu.\n");
                }
            }

        }//ends program


    }
}
