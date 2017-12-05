using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder.");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Opret Ny medarbejder.");
            string menu_answer = Console.ReadLine();

            switch(menu_answer)
            {
                case 1: Console.WriteLine("Søg efter medarbejder.");
                    break;
                case 2: Console.WriteLine("Opret medarbejder");
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
