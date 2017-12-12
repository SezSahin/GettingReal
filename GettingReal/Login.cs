using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GettingReal
{
    class Login
    {
        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";


        public Login()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spLogin", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Indtast Brugernavn");
                    string Brugernavn = Console.ReadLine();
                    Console.WriteLine("Indtast Password");
                    string Password = Console.ReadLine();

                    //cmd.Parameters.Add(new SqlParameter("@Brugernavn", Brugernavn));
                    //cmd.Parameters.Add(new SqlParameter("@Password", Password));

                    if (Brugernavn == /**/ && Password == /**/)
                    {
                        //returned ID
                        Menu menu = new Menu();
                        menu.ShowMenu(/**/);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Forkert brugernavn/password");
                        Login();
                    }
                }
                catch
                {
                    Console.WriteLine("UPS " + e.Message);
                }

            }
        }

        public bool CheckUsername(string user)
        {
            throw new NotImplementedException();
        }
        public bool CheckPassword(string pass)
        {
            throw new NotImplementedException();
        }
        public bool CheckAll(string user, string pass)
        {
            throw new NotImplementedException();
        }
        public void LoginError()
        {

        }
        public void PassToRank()
        {

        }
    }
}


