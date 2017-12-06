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
                cmd.Parameters.Add(new SqlParameter("@BrugerNavn", Console.ReadLine()));
                Console.WriteLine("Indtast Pasword \n");
                cmd.Parameters.Add(new SqlParameter("@Password", Console.ReadLine()));
                Console.Clear();
                
                cmd.ExecuteNonQuery();
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
        public void Gemt()
        {

        }
        public void Slet()
        {

        }
    }
}
