using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GettingReal
{
    class Controller
    {
        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";
        public void Søg(int id, string navn, string adresse, string cpr, string email, double løn, double skat)
        {

        }
        public void Opret()
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spOpretBruger", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Indtast Brugernavn \n");
                    cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                    Console.WriteLine("Indtast Pasword \n");
                    cmd.Parameters.Add(new SqlParameter("@Password", Console.ReadLine()));
                    Console.WriteLine("Indtast Navn og mellem navn \n");
                    cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                    Console.WriteLine("Indtast Efternavn \n");
                    cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                    Console.WriteLine("Indtast Addresselinje 1 \n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse", Console.ReadLine()));
                    Console.WriteLine("Indtast Addresselinje 2 (hvis der ikke er noget at skrive, skriv pik)\n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse_l2", Console.ReadLine()));
                    Console.WriteLine("Indtast Addresse By\n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse_by", Console.ReadLine()));
                    Console.WriteLine("Indtast Post nr.\n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse_postnr", Console.ReadLine()));
                    Console.WriteLine("Indtast Telefon nr.\n");
                    cmd.Parameters.Add(new SqlParameter("@Tlf", Console.ReadLine()));
                    Console.WriteLine("Indtast CPR \n");
                    cmd.Parameters.Add(new SqlParameter("@CPR_nr", Console.ReadLine()));
                    Console.WriteLine("Indtast Konto nr. \n");
                    cmd.Parameters.Add(new SqlParameter("@konto_nr", Console.ReadLine()));
                    Console.WriteLine("Indtast Reg nr. \n");
                    cmd.Parameters.Add(new SqlParameter("@reg_nr", Console.ReadLine()));
                    Console.WriteLine("Indtast AfdelingsID \n");
                    cmd.Parameters.Add(new SqlParameter("@AfdelingsID", Console.ReadLine()));


                    Console.Clear();
                
                    //cmd.ExecuteNonQuery();

                    Console.Clear();

                    Console.WriteLine("Gem? Ja = y|| Nej = n ");

                    var input = Console.ReadKey(true).Key;

                    Menu menu = new Menu();
                    switch (input)
                    {
                        
                        case ConsoleKey.Y: Gemt(cmd); menu.ShowMenu(); break;

                        case ConsoleKey.N: menu.ShowMenu(); break;

                        default:
                            Console.WriteLine("Default case");
                            break;

                    }

                }
                catch(SqlException e)
                {
                     Console.WriteLine("UPS " + e.Message);
                }
            }
        }
        public void Rediger()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spRediger", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Indtast fornavn \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Fornavn", Console.ReadLine()));
                    Console.WriteLine("Indtast efternavn \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                    Console.WriteLine("Indtast ny adresse \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Adresse", Console.ReadLine()));
                    Console.WriteLine("Indtast adresse linje 2 \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Adresse_l2", Console.ReadLine()));
                    Console.WriteLine("Indtast by \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Adresse_by", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt telefon nummer \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Telef", Console.ReadLine()));
                    Console.WriteLine("Indtast ny e-mail \n \n");
                    cmd.Parameters.Add(new SqlParameter("@mail", Console.ReadLine()));

                    Console.Clear();

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Prøv igen" + e.Message);
                }
            }
        }
        public void Gemt(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
            Console.WriteLine("Gemt!");
        }
        public void Slet()
        {

        }
    }
}
