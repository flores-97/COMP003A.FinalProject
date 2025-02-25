// Author: Victor Flores
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Final Project
using System.Net.Http.Headers;
using System.Security.Cryptography;
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

            List<string> legoName = new List<string>();
            List<string> setNumber = new List<string>();
            List<string> minifigID = new List<string>();

            List<int> legoPrice = new List<int>();
            List<int> legoResale = new List<int>();


            Set set = new Set(setNumber, legoName, legoPrice, legoResale);
            Minifig minifig = new Minifig(minifigID, legoName, legoPrice, legoResale);

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
                            Console.Write("\nEnter the number of the set: ");
                            string SetNumber = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(SetNumber)) throw new Exception("\nSet's number cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                        setNumber.Add(Console.ReadLine());
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the name of the Set: ");
                            string LegoName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(LegoName)) throw new Exception("\nSet's name cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                        legoName.Add(Console.ReadLine());
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price paid: $");
                            legoPrice.Add(int.Parse(Console.ReadLine()));
                            int LegoPrice = 0;
                            if (LegoPrice <= -1) throw new Exception("\nPrice cannot be less than 0.");
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
                            legoResale.Add(int.Parse(Console.ReadLine()));
                            int LegoResale = 0;
                            if (LegoResale <= -1) throw new Exception("\nResale price cannot be less than 0.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                    }

                    legos.Add(set);

                    Console.WriteLine("Lego Set built successfully!");
                    set.Awesome();
                    set.Construction();
                }

                else if (choice == 2)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nEnter the minifigure ID: ");
                            string MinifigID = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(MinifigID)) throw new Exception("\nMinifigure's ID cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                        minifigID.Add(Console.ReadLine());
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the name of the minifigure: ");
                            string LegoName = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(LegoName)) throw new Exception("\nMinifigure's name cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.");
                        }
                        legoName.Add(Console.ReadLine());
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the price paid: $");
                            legoPrice.Add(int.Parse(Console.ReadLine()));
                            int LegoPrice = 0;
                            if (LegoPrice <= -1) throw new Exception("\nPrice cannot be less than 0.");
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
                            legoResale.Add(int.Parse(Console.ReadLine()));
                            int LegoResale = 0;
                            if (LegoResale <= -1) throw new Exception("\nResale price cannot be less than 0.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    legos.Add(minifig);

                    Console.WriteLine("Minifigure added successfully!");
                    minifig.Awesome();
                    minifig.Construction();
                }

                else if (choice == 3)
                {
                    Console.Write("Which Lego item did you sell? ");
                    int index = legoName.IndexOf(Console.ReadLine());
                    if (index != -1)
                    {
                        Console.Write("How much did you sell it for? (please include minus sign) $");
                        legoResale.Remove(int.Parse(Console.ReadLine()));
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
                    set.DisplayInfo();
                    minifig.DisplayInfo();

                    Console.WriteLine($"Total Lego in inventory: {legos.Count}");//how many items in inventory 
                    Console.WriteLine($"Total spent: {legoPrice.Sum()}");//meant to display total spent
                    Console.WriteLine($"Potential resale value: ${legoResale.Sum()}");//meant to display potential resale value
                    Console.WriteLine($"Lego Profit: ${legoResale.Sum() - legoPrice.Sum()}");//if lego sold, meant to display how much profit 
                }

                else
                {
                    Console.WriteLine("\nInvalid entry. Select an option on the menu.\n");
                }
            }
        }//ends program
    }
}
