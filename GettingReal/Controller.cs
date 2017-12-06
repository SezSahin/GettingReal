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
        Menu menu = new Menu();
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
                cmd.Parameters.Add(new SqlParameter("@BrugerNavn", Console.ReadLine()));
                Console.WriteLine("Indtast Pasword \n");
                cmd.Parameters.Add(new SqlParameter("@Password", Console.ReadLine()));
                Console.Clear();
                    Console.WriteLine("Gem? Ja = y|| Nej = n ");
                    var input = Console.ReadKey(true).Key;
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
