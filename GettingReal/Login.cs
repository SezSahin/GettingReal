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

        private int Login_ID;
        public void Login1()
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

                    
                    cmd.Parameters.Add(new SqlParameter("@Brugernavn", Brugernavn));
                    cmd.Parameters.Add(new SqlParameter("@Password", Password));
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    

                    //if (reader.HasRows)
                    //{
                        while (reader.Read())
                        {
                            string ID = reader["AfdelingsID"].ToString();
                            string UserName = reader["Brugernavn"].ToString();
                            string Kodeord = reader["Password"].ToString();
                            string LoginString = reader["id"].ToString();
                            Login_ID = Int32.Parse(LoginString);

                            if (Brugernavn == UserName && Password == Kodeord)
                            {
                                int afdelingsID = int.Parse(ID);
                                //returned ID
                                Menu menu = new Menu();
                                menu.ShowMenu(afdelingsID);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Forkert brugernavn/password");
                                Login1();
                            }
                        }
                    //}

             

                }
                catch(SqlException e)
                {
                    Console.WriteLine("UPS " + e.Message);
                }

            }
        }
        public int GetLoginID()
        {
            return Login_ID;
        }

      
    }
}


