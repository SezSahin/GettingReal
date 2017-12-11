using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        Controller controller = new Controller();
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder. \n");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Opret Ny medarbejder.");
            Console.WriteLine("3. Rediger medarbejder.");
            Console.WriteLine("4. Slet medarbejder. \n");
            Console.WriteLine("0. Luk konsol \n");

            string menu_answer = Console.ReadLine();

            switch(menu_answer)
            {
                case "1": Console.WriteLine("Søg efter medarbejder. \n");
                    Søg();
                    break;
                case "2": Console.WriteLine("Opret medarbejder \n");
                    controller.Opret();
                    break;
                case "3": Console.WriteLine("Rediger medarbejder \n");
                    controller.Rediger();
                    break;
                case "4": Console.WriteLine("Slet medarbejder \n");
                    controller.Slet();
                    break;
                case "0":
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                    ShowMenu();
                    break;
            }
        }
        public void Søg()
        {
            Console.WriteLine("\nIndtast Nøgleord \n");
            string nøgleord = Console.ReadLine();

            controller.Søg(nøgleord);


        }
    }
}
