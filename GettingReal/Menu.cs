﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        private string brugernavn;
        private string password;
        private int id;

        Controller controller = new Controller();
        Login l = new Login();
        public void ShowMenu(int AfdelingsID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder. \n");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Skift din adgangskode");
            if (AfdelingsID > 3)
            {
                Console.WriteLine("3. Opret Ny medarbejder.");
                Console.WriteLine("4. Rediger medarbejder.");
                Console.WriteLine("5. Slet medarbejder.");
            }
            Console.WriteLine("6. Log af. \n");
            Console.WriteLine("0. Luk konsol \n");
            string menu_answer = Console.ReadLine();
            if (AfdelingsID > 3)
            {
                switch (menu_answer)
                {
                    case "1":
                        Console.WriteLine("Søg efter medarbejder. \n");
                        Søg(AfdelingsID);
                        break;
                    case "2":
                        Console.WriteLine("Skift din adgangskode");
                        controller.SkiftPassword(id, brugernavn, password, AfdelingsID);
                        break;
                    case "3":
                        Console.WriteLine("Opret medarbejder \n");
                        controller.Opret(AfdelingsID);
                        break;
                    case "4":
                        Console.WriteLine("Rediger medarbejder \n");
                        controller.Rediger(AfdelingsID);
                        break;
                    case "5":
                        Console.WriteLine("Slet medarbejder \n");
                        controller.Slet(AfdelingsID);
                        break;
                    case "6":
                        l.Login1();
                        break;
                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                        ShowMenu(AfdelingsID);
                        break;
                }
            }
            else if (AfdelingsID < 4)
            {
                {
                    switch (menu_answer)
                    {
                        case "1":
                            Console.WriteLine("\nSøg efter medarbejder. \n");
                            Søg(AfdelingsID);
                            break;
                        case "2":
                            Console.WriteLine("Skift din adgangskode");
                            controller.SkiftPassword(id, brugernavn, password, AfdelingsID);
                            break;
                        case "0":
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                            ShowMenu(AfdelingsID);
                            break;
                    }
                }
            }
        }
        public void Søg(int ID)
        {
            Console.WriteLine("\nIndtast Nøgleord \n");
            string nøgleord = Console.ReadLine();

            controller.Søg(nøgleord, ID);


        }

        public string Brugernavn {
            get { return brugernavn; }
            set { brugernavn = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }
    }
}