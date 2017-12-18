using System;
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
        public void ShowMenu(int ID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder. \n");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Skift din adgangskode");
            if (ID > 3)
            {
                Console.WriteLine("3. Opret Ny medarbejder.");
                Console.WriteLine("4. Rediger medarbejder.");
                Console.WriteLine("5. Slet medarbejder. \n");
            }
            Console.WriteLine("0. Luk konsol \n");

            string menu_answer = Console.ReadLine();
            if (ID > 3)
            {
                switch (menu_answer)
                {
                    case "1":
                        Console.WriteLine("Søg efter medarbejder. \n");
                        Søg(ID);
                        break;
                    case "2":
                        Console.WriteLine("Skift din adgangskode");
                        controller.SkiftPassword(id, brugernavn, password);
                        break;
                    case "3":
                        Console.WriteLine("Opret medarbejder \n");
                        controller.Opret(ID);
                        break;
                    case "4":
                        Console.WriteLine("Rediger medarbejder \n");
                        controller.Rediger(ID);
                        break;
                    case "5":
                        Console.WriteLine("Slet medarbejder \n");
                        controller.Slet(ID);
                        break;
                   
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                        ShowMenu(ID);
                        break;
                }
            }
            else if (ID < 4)
            {
                {
                    switch (menu_answer)
                    {
                        case "1":
                            Console.WriteLine("\nSøg efter medarbejder. \n");
                            Søg(ID);
                            break;
                        case "2":
                            Console.WriteLine("Skift din adgangskode");
                            controller.SkiftPassword(id, brugernavn, password);
                            break;
                        case "0":
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                            ShowMenu(ID);
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