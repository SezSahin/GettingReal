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
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder. \n");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Opret Ny medarbejder. \n");
            string menu_answer = Console.ReadLine();

            switch(menu_answer)
            {
                case "1": Console.WriteLine("Søg efter medarbejder.");
                    controller.Søg();
                    break;
                case "2": Console.WriteLine("Opret medarbejder");
                    controller.Opret();
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                    ShowMenu();
                    break;
            }
        }
        public void Show()
        {

        }
    }
}
