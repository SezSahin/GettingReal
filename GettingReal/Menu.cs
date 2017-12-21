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
        Login l = new Login();
        public void ShowMenu(int afdelingsID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder. \n");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Skift din adgangskode");
            if (afdelingsID > 3)
            {
                Console.WriteLine("3. Opret Ny medarbejder.");
                Console.WriteLine("4. Rediger medarbejder.");
                Console.WriteLine("5. Slet medarbejder.");
                Console.WriteLine("6. Log af.");
            }
            if(afdelingsID < 4)
            {
                Console.WriteLine("3. Log af.");
            }
            Console.WriteLine("\n0. Luk konsol \n");
            string menu_answer = Console.ReadLine();
            if (afdelingsID > 3)
            {
                switch (menu_answer)
                {
                    case "1":
                        Console.WriteLine("Søg efter medarbejder. \n");
                        Søg(afdelingsID);
                        break;
                    case "2":
                        Console.WriteLine("Skift din adgangskode");
                        controller.SkiftPassword(id, brugernavn, password, afdelingsID);
                        break;
                    case "3":
                        Console.WriteLine("Opret medarbejder \n");
                        Console.WriteLine("Indtast Brugernavn \n");
                        string newuser = Console.ReadLine();  
                        Console.WriteLine("Indtast Pasword \n");
                        string  newpassword = Console.ReadLine();
                        Console.WriteLine("Indtast Navn og mellem navn \n");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Indtast Efternavn \n");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Indtast Addresselinje 1 \n");
                        string address1 = Console.ReadLine();
                        Console.WriteLine("Indtast Addresselinje 2 \n");
                        string address2 = Console.ReadLine();
                        Console.WriteLine("Indtast Addresse By\n");
                        string city = Console.ReadLine();
                        Console.WriteLine("Indtast Post nr.\n");
                        string zipnr = Console.ReadLine();
                        Console.WriteLine("Indtast Telefon nr.\n");
                        string telephonenr = Console.ReadLine();
                        Console.WriteLine("Indtast e-mail \n \n");
                        string email = Console.ReadLine();
                        Console.WriteLine("Indtast CPR \n");
                        string cpr = Console.ReadLine();
                        Console.WriteLine("Indtast Konto nr. \n");
                        string accountnr = Console.ReadLine();
                        Console.WriteLine("Indtast Reg nr. \n");
                        string reqnr= Console.ReadLine();
                        Console.WriteLine("Indtast AfdelingsID \n");
                        string departmentnr= Console.ReadLine();
                        Console.WriteLine("Indtast Sundhedsoplysninger \n");
                        string health= Console.ReadLine();
                        Console.WriteLine("Indtast Jobtype \n");
                        string jobtype = Console.ReadLine();
                        Console.WriteLine("Indtast Medarbejder nr. \n");
                        string employmentnr= Console.ReadLine();
                        Console.WriteLine("Indtast Kontakt navn \n");
                        string contactperson= Console.ReadLine();
                        Console.WriteLine("Indtast Kontakt nr. \n");
                        string ContactTelephoneNr= Console.ReadLine();
                        controller.Opret(newuser, newpassword, firstname, lastname,
                            address1, address2, city, zipnr, telephonenr, email,
                            cpr, accountnr, reqnr, departmentnr, health, jobtype, 
                            employmentnr, contactperson, ContactTelephoneNr, 
                            afdelingsID);
                        break;
                    case "4":
                        Console.WriteLine("Rediger medarbejder \n");
                        Console.WriteLine("Indtast Medarbejder nr.");
                        string employeenr = Console.ReadLine();
                        controller.Rediger(employeenr, afdelingsID);
                        break;
                    case "5":
                        Console.WriteLine("Slet medarbejder \n");
                        Console.WriteLine("\nSlet bruger med fornavn: \n");
                        firstname = Console.ReadLine();
                        Console.WriteLine("\nSlet bruger med efternavn: \n");
                        lastname = Console.ReadLine();
                        Console.WriteLine("\nSlet bruger med medarbejder nummer: \n");
                        employeenr = Console.ReadLine();
                        controller.Slet(firstname, lastname, employeenr, afdelingsID);
                        break;
                    case "6":
                        l.Login1();
                        break;
                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                        ShowMenu(afdelingsID);
                        break;
                }
            }
            else if (afdelingsID < 4)
            {
                {
                    switch (menu_answer)
                    {
                        case "1":
                            Console.WriteLine("\nSøg efter medarbejder. \n");
                            Søg(afdelingsID);
                            break;
                        case "2":
                            Console.WriteLine("Skift din adgangskode");
                            controller.SkiftPassword(id, brugernavn, password, afdelingsID);
                            break;
                        case "3":
                            l.Login1();
                            break;
                        case "0":
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                            ShowMenu(afdelingsID);
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