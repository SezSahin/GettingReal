using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace GettingReal
{
    class Controller
    {
        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";
        public void Søg(string nøgleord)
        {
            string[] ord = nøgleord.Split(' ');

            using (SqlConnection con = new SqlConnection(connectionString))
            {
            
                try
                {
                    //hey
                    if (ord.Length == 1)
                    {
                        if (ord[0] == "")
                        {
                            ord[0] = null;
                        }

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string UserName = reader["Brugernavn"].ToString();
                                string FirstName = reader["Navn"].ToString();
                                string LastName = reader["Efternavn"].ToString();
                                string Address = reader["Addresse"].ToString();
                                string AddressL2 = reader["Addresse_l2"].ToString();
                                string AddressCity = reader["Addresse_by"].ToString();
                                string AddressZip = reader["Addresse_postnr"].ToString();
                                string PhoneNumber = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SocialSecurity = reader["CPR_nr"].ToString();
                                string AccountNumber = reader["konto_nr"].ToString();
                                string RegNumber = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string JobType = reader["JobType"].ToString();
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["PårørendeNavn"].ToString();
                                string ContactNr = reader["PårørendeNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - PårørendeNr: " + ContactName + "\n ContactName: " + ContactNr);
                            }
                        }
                    }

                    if (ord.Length == 2)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg2P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", ord[1]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string UserName = reader["Brugernavn"].ToString();
                                string FirstName = reader["Navn"].ToString();
                                string LastName = reader["Efternavn"].ToString();
                                string Address = reader["Addresse"].ToString();
                                string AddressL2 = reader["Addresse_l2"].ToString();
                                string AddressCity = reader["Addresse_by"].ToString();
                                string AddressZip = reader["Addresse_postnr"].ToString();
                                string PhoneNumber = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SocialSecurity = reader["CPR_nr"].ToString();
                                string AccountNumber = reader["konto_nr"].ToString();
                                string RegNumber = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string JobType = reader["JobType"].ToString();
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["PårørendeNavn"].ToString();
                                string ContactNr = reader["PårørendeNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - PårørendeNr: " + ContactName + "\n ContactName: " + ContactNr);
                            }
                        }
                    }

                    if (ord.Length == 3)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg3P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", ord[1]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword3", ord[2]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string UserName = reader["Brugernavn"].ToString();
                                string FirstName = reader["Navn"].ToString();
                                string LastName = reader["Efternavn"].ToString();
                                string Address = reader["Addresse"].ToString();
                                string AddressL2 = reader["Addresse_l2"].ToString();
                                string AddressCity = reader["Addresse_by"].ToString();
                                string AddressZip = reader["Addresse_postnr"].ToString();
                                string PhoneNumber = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SocialSecurity = reader["CPR_nr"].ToString();
                                string AccountNumber = reader["konto_nr"].ToString();
                                string RegNumber = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string JobType = reader["JobType"].ToString();
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["PårørendeNavn"].ToString();
                                string ContactNr = reader["PårørendeNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - PårørendeNr: " + ContactName + "\n ContactName: " + ContactNr);
                            }
                        }
                    }

                    if (ord.Length == 4)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg4P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", ord[1]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword3", ord[2]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword4", ord[3]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string UserName = reader["Brugernavn"].ToString();
                                string FirstName = reader["Navn"].ToString();
                                string LastName = reader["Efternavn"].ToString();
                                string Address = reader["Addresse"].ToString();
                                string AddressL2 = reader["Addresse_l2"].ToString();
                                string AddressCity = reader["Addresse_by"].ToString();
                                string AddressZip = reader["Addresse_postnr"].ToString();
                                string PhoneNumber = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SocialSecurity = reader["CPR_nr"].ToString();
                                string AccountNumber = reader["konto_nr"].ToString();
                                string RegNumber = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string JobType = reader["JobType"].ToString();
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["PårørendeNavn"].ToString();
                                string ContactNr = reader["PårørendeNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - PårørendeNr: " + ContactName + "\n - ContactName: " + ContactNr);
                            }
                        }
                    }

                    if (ord.Length == 5)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg4P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", ord[1]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword3", ord[2]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword4", ord[3]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword5", ord[4]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string UserName = reader["Brugernavn"].ToString();
                                string FirstName = reader["Navn"].ToString();
                                string LastName = reader["Efternavn"].ToString();
                                string Address = reader["Addresse"].ToString();
                                string AddressL2 = reader["Addresse_l2"].ToString();
                                string AddressCity = reader["Addresse_by"].ToString();
                                string AddressZip = reader["Addresse_postnr"].ToString();
                                string PhoneNumber = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SocialSecurity = reader["CPR_nr"].ToString();
                                string AccountNumber = reader["konto_nr"].ToString();
                                string RegNumber = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string JobType = reader["JobType"].ToString();
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["PårørendeNavn"].ToString();
                                string ContactNr = reader["PårørendeNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - PårørendeNr: " + ContactName + "\n ContactName: " + ContactNr);
                            }
                        }
                    }

                    Console.WriteLine("Tryk 'Enter' for at fortsætte");
                    var input = Console.ReadKey(true).Key;

                    Menu menu = new Menu();
                    switch (input)
                    {
                        case ConsoleKey.Enter: menu.ShowMenu(); break;

                        default:
                            Console.WriteLine("Default case");
                            break;
                    }                    
                }
                catch(SqlException e)
                {
                    Console.WriteLine("Ugyldig information" + e.Message + "\n");
                }
            }
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
                    Console.WriteLine("Indtast Addresselinje 2 \n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse_l2", Console.ReadLine()));
                    Console.WriteLine("Indtast Addresse By\n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse_by", Console.ReadLine()));
                    Console.WriteLine("Indtast Post nr.\n");
                    cmd.Parameters.Add(new SqlParameter("@Addresse_postnr", Console.ReadLine()));
                    Console.WriteLine("Indtast Telefon nr.\n");
                    cmd.Parameters.Add(new SqlParameter("@Tlf", Console.ReadLine()));
                    Console.WriteLine("Indtast e-mail \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Email", Console.ReadLine()));
                    Console.WriteLine("Indtast CPR \n");
                    cmd.Parameters.Add(new SqlParameter("@CPR_nr", Console.ReadLine()));
                    Console.WriteLine("Indtast Konto nr. \n");
                    cmd.Parameters.Add(new SqlParameter("@konto_nr", Console.ReadLine()));
                    Console.WriteLine("Indtast Reg nr. \n");
                    cmd.Parameters.Add(new SqlParameter("@reg_nr", Console.ReadLine()));
                    Console.WriteLine("Indtast AfdelingsID \n");
                    cmd.Parameters.Add(new SqlParameter("@AfdelingsID", Console.ReadLine()));
                    Console.WriteLine("Indtast Sundhedsoplysninger \n");
                    cmd.Parameters.Add(new SqlParameter("@Sunhedsoplysninger", Console.ReadLine()));
                    Console.WriteLine("Indtast Jobtype \n");
                    cmd.Parameters.Add(new SqlParameter("@JobType", Console.ReadLine()));
                    Console.WriteLine("Indtast Medarbejder nr. \n");
                    cmd.Parameters.Add(new SqlParameter("@MedarbejderNr", Console.ReadLine()));
                    Console.WriteLine("Indtast Pårørendes navn \n");
                    cmd.Parameters.Add(new SqlParameter("@PårørendeNavn", Console.ReadLine()));
                    Console.WriteLine("Indtast Pørerendes nr. \n");
                    cmd.Parameters.Add(new SqlParameter("@PårørendeNr", Console.ReadLine()));


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
                     Console.WriteLine("UPS " + e.Message + "\n");
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
                    SqlCommand cmd = new SqlCommand("spOpdater", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Indtast nyt ID \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Id", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt brugernavn \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                    Console.WriteLine("Indtast fornavn \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Fornavn", Console.ReadLine()));
                    Console.WriteLine("Indtast efternavn \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                    Console.WriteLine("Indtast ny adresse \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Adresse", Console.ReadLine()));
                    Console.WriteLine("Indtast adresse linje 2 \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Adressel2", Console.ReadLine()));
                    Console.WriteLine("Indtast by \n \n");
                    cmd.Parameters.Add(new SqlParameter("@By", Console.ReadLine()));
                    Console.WriteLine("Indtast ny post nummer \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Postnr", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt telefon nummer \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Tlf", Console.ReadLine()));
                    Console.WriteLine("Indtast ny e-mail \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Email", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt konto nummer \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Konto", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt registrerings nummer \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Reg", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt afdelings ID \n \n");
                    cmd.Parameters.Add(new SqlParameter("@AfdelingsID", Console.ReadLine()));
                    Console.WriteLine("Indtast nye sunhedsoplysninger \n \n");
                    cmd.Parameters.Add(new SqlParameter("@Sunhedsoplsyninger", Console.ReadLine()));
                    Console.WriteLine("Indtast ny jobtype \n \n");
                    cmd.Parameters.Add(new SqlParameter("@JobType", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt medarbejder nummer \n \n");
                    cmd.Parameters.Add(new SqlParameter("@MedarbejderNr", Console.ReadLine()));
                    Console.WriteLine("Indtast nyt pårørende navn \n \n");
                    cmd.Parameters.Add(new SqlParameter("@PårørebdeNavn", Console.ReadLine()));
                    Console.WriteLine("Indtast nye pårørendeNr \n \n");
                    cmd.Parameters.Add(new SqlParameter("@PårørendeNr", Console.ReadLine()));
                    //@Sunhedsoplysninger, @JobType, @MedarbejderNr, @PårørendeNavn, @PårørendeNr

                    Console.Clear();

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Prøv igen" + e.Message + "\n");
                }
            }
        }
        public void Gemt(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
            Console.WriteLine("Gemt!");
            Thread.Sleep(2000);
        }
        public void Slet()
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spSletBruger", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("\nSlet bruger med fornavn: \n");
                    cmd.Parameters.Add(new SqlParameter("@Fornavn", Console.ReadLine()));
                    Console.WriteLine("\nSlet bruger med efternavn: \n");
                    cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                    Console.WriteLine("\nSlet bruger med medarbejder nummer: \n");
                    cmd.Parameters.Add(new SqlParameter("@MedarbejderNr", Console.ReadLine()));

                    Console.Clear();

                    Console.WriteLine("Medarbejder slettet! \n");

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Tryk 'Enter' for at fortsætte");
                    var input = Console.ReadKey(true).Key;

                    Menu menu = new Menu();
                    switch (input)
                    {
                        case ConsoleKey.Enter: menu.ShowMenu(); break;

                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
                catch(SqlException e)
                {
                    Console.WriteLine("Dårligt lavet.." + e.Message + "\n");
                }
            }
        }
    }
}
