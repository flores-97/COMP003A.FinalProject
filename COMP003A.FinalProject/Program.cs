// Author: Victor Flores
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Final Project
using System.Linq;
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
            Set set = new Set();
            
            Minifig minifig = new Minifig();

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
                            string legoID = Console.ReadLine();
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
                            Console.Write("\nEnter the name of the Set: ");
                            string legoName = Console.ReadLine();
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
                            Console.Write("\nEnter the price paid: $");
                            int legoPrice = int.Parse(Console.ReadLine());
                            if (legoPrice <= -1) throw new Exception("\nPrice cannot be less than 0.");
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
                            Console.Write("\nEnter the price of resale: $");
                            int legoResale = int.Parse(Console.ReadLine());
                            if (legoResale <= -1) throw new Exception("\nResale price cannot be less than 0.");
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
                            string legoID = Console.ReadLine();
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
                        try
                        {
                            Console.Write("\nEnter the name of the minifigure: ");
                            string legoName = Console.ReadLine();
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
                            Console.Write("\nEnter the price paid: $");
                            double legoPrice = int.Parse(Console.ReadLine());
                            if (legoPrice <= -1) throw new Exception("\nPrice cannot be less than 0.");
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
                            Console.Write("\nEnter the price of resale: $");
                            double legoResale = int.Parse(Console.ReadLine());
                            if (legoResale <= -1) throw new Exception("\nResale price cannot be less than 0.");
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
                    //create something that will remove legoName 
                }

                else if (choice == 4)
                {
                    foreach (Lego lego in legos)
                    {
                        Console.WriteLine(lego);//display all legoName with legoPrice in list form

                        lego.DisplayLegoFinance();
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
