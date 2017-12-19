using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Diagnostics;

namespace GettingReal
{
    public class Controller
    {
        
        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";
     
        public void SøgMere(string nøgleord, int afdelingsID)
        {
            Menu menu = new Menu();
            string[] ord = nøgleord.Split(' ');

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    //hey
                    //con.Open();
                    //string ID = "";
                    //string[] idCheck = new string[200];
                    //idCheck[0] = "0";

                    //for (int i = 0; i < ord.Length; i++)
                    //{
                    //if (ord[i] == "")
                    //{
                    //    ord[i] = null;
                    //}

                    //SqlCommand cmd = new SqlCommand("spSøg", con);
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@Keyword", ord[i]));

                    //SqlDataReader reader = cmd.ExecuteReader();
                    if (ord.Length == 1)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));
                        if (ord[0] == "")
                        {
                            ord[0] = null;
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                Console.ForegroundColor = ConsoleColor.White;
                                string ID = reader["ID"].ToString();

                                //if (!idCheck.Contains(ID))
                                //{
                                //idCheck[i] = ID;
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
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNr);
                            }
                        }
                    }
                    //reader.Close();
                    //}

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
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNr);
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
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNr);
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
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNr);
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
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - Adresselinje 1: " + Address + "\n - Adresselinje 2: " + AddressL2 + "\n - By: " + AddressCity + "\n - Post nr: " + AddressZip + "\n - Telefon nr: " + PhoneNumber + "\n - Email: " + Email + "\n - CPR nr: " + SocialSecurity + "\n - Konto nr: " + AccountNumber + "\n - Reg nr: " + RegNumber + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + JobType + "\n - MedarbejderNr: " + EmployeeNr + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNr);
                            }
                        }
                    }
                    if (ord.Length > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Din søgning var for lang.");
                        Thread.Sleep(2000);

                        menu.ShowMenu(afdelingsID);
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (afdelingsID > 3)
                    {
                        Console.WriteLine("\nTryk '1' for at redigere");
                        Console.WriteLine("\nTryk '2' for at slette");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nTryk 'Enter' for at vende tilbage til menuen");
                    var input = Console.ReadKey(true).Key;
 
                    //Console.Clear();
                    switch (input)
                    {
                        case ConsoleKey.D1:
                            Rediger(afdelingsID);
                            break;
                        case ConsoleKey.D2:
                            Slet(afdelingsID);
                            break;
                        case ConsoleKey.Enter:
                            menu.ShowMenu(afdelingsID);
                            break;

                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ugyldig information " + e.Message + "\n");
                }
            }
        }
        public void Søg(string nøgleord, int AfdelingsID)
        {
            Menu menu = new Menu();
            string[] ord = nøgleord.Split(' ');

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    //hey
                    //con.Open();
                    //string ID = "";
                    //string[] idCheck = new string[200];
                    //idCheck[0] = "0";

                    //for (int i = 0; i < ord.Length; i++)
                    //{
                    //if (ord[i] == "")
                    //{
                    //    ord[i] = null;
                    //}

                    //SqlCommand cmd = new SqlCommand("spSøg", con);
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@Keyword", ord[i]));

                    //SqlDataReader reader = cmd.ExecuteReader();
                    if (ord.Length == 1)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", ord[0]));
                        if (ord[0] == "")
                        {
                            ord[0] = null;
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                            

                            string ID = reader["ID"].ToString();
                                
                            //if (!idCheck.Contains(ID))
                            //{
                                //idCheck[i] = ID;
                                string UserName = reader["Brugernavn"].ToString();
                                string FirstName = reader["Navn"].ToString();
                                string LastName = reader["Efternavn"].ToString();
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - MedarbejderNr: " + EmployeeNr);
                            }
                        }
                    }
                        //reader.Close();
                    //}

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
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - MedarbejderNr: " + EmployeeNr);
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
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - MedarbejderNr: " + EmployeeNr);
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
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - MedarbejderNr: " + EmployeeNr);
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
                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + UserName + "\n - Fornavn " + FirstName + "\n - Efternavn " + LastName + "\n - MedarbejderNr: " + EmployeeNr);
                            }
                        }
                    }
                    if(ord.Length > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Din søgning var for lang.");
                        Thread.Sleep(2000);

                        menu.ShowMenu(AfdelingsID);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    if (AfdelingsID > 3)
                    {
                        Console.WriteLine("\nTryk '1' for at hente mere information");
                        Console.WriteLine("\nTryk '2' for at redigere");
                        Console.WriteLine("\nTryk '3' for at slette");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nTryk 'Enter' for at vende tilbage til menuen");
                    var input = Console.ReadKey(true).Key;

                    //Console.Clear();
                    switch (input)
                    {
                        case ConsoleKey.D1:
                            SøgMere(nøgleord, AfdelingsID);
                            break;
                        case ConsoleKey.D2:
                            Rediger(AfdelingsID);
                            break;
                        case ConsoleKey.D3:
                            Slet(AfdelingsID);
                            break;
                        case ConsoleKey.Enter: menu.ShowMenu(AfdelingsID);
                            break;

                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ugyldig information " + e.Message + "\n");
                }
            }
        }
        
        public void Opret(int ID)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (ID > 3)
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
                        Console.WriteLine("Indtast Kontakt navn \n");
                        cmd.Parameters.Add(new SqlParameter("@KontaktPerson", Console.ReadLine()));
                        Console.WriteLine("Indtast Kontakt nr. \n");
                        cmd.Parameters.Add(new SqlParameter("@KontaktNr", Console.ReadLine()));


                        Console.Clear();

                        //cmd.ExecuteNonQuery();

                        Console.Clear();

                        Console.WriteLine("Gem? Ja = y|| Nej = n ");

                        var input = Console.ReadKey(true).Key;

                        Menu menu = new Menu();
                        switch (input)
                        {

                            case ConsoleKey.Y: Gemt(cmd); menu.ShowMenu(ID); break;

                            case ConsoleKey.N: menu.ShowMenu(ID); break;

                            default:
                                Console.WriteLine("Default case");
                                break;

                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("UPS " + e.Message + "\n");
                    }
                }
                else
                {
                    Menu menu = new Menu();
                    menu.ShowMenu(ID);
                }
            }
        }

        public void Rediger(int ID)
        {
            if (3 < ID)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spFinnMedarbejder", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Console.Clear();
                        Console.WriteLine("Indtast Medarbejder nr.");
                        cmd.Parameters.Add(new SqlParameter("@MedarbejderNr", Console.ReadLine()));
                        cmd.ExecuteNonQuery();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string UserName = reader["Brugernavn"].ToString();
                                Console.WriteLine("Indtast Brugernavn");
                                Console.WriteLine("Nuværende Bruger navn: " + UserName);
                                string Username1 = Console.ReadLine();
                                if(Username1 != "")
                                {
                                    UserName = Username1;
                                }

                                string Navn = reader["Navn"].ToString();
                                Console.WriteLine("Indtast Navn");
                                Console.WriteLine("Nuværende Navn: " + Navn);
                                string Navn1 = Console.ReadLine();
                                if (Navn1 != "")
                                {
                                    Navn = Navn1;
                                }

                                string Efternavn = reader["Efternavn"].ToString();
                                Console.WriteLine("Indtast Efternavn");
                                Console.WriteLine("Nuværende Efternavn: " + Efternavn);
                                string Efternavn1 = Console.ReadLine();
                                if (Efternavn1 != "")
                                {
                                    Efternavn = Efternavn1;
                                }

                                string Addresse = reader["Addresse"].ToString();
                                Console.WriteLine("Indtast Addresse");
                                Console.WriteLine("Nuværende Addresse: " + Addresse);
                                string Addresse1 = Console.ReadLine();
                                if (Addresse1 != "")
                                {
                                    Addresse = Addresse1;
                                }

                                string Addresse2 = reader["Addresse2"].ToString();
                                Console.WriteLine("Indtast Addresse2");
                                Console.WriteLine("Nuværende Addresse2: " + Addresse2);
                                string Addresse21 = Console.ReadLine();
                                if (Addresse21 != "")
                                {
                                    Addresse2 = Addresse21;
                                }

                                string Addresse_by = reader["Addresse_by"].ToString();
                                Console.WriteLine("Indtast By");
                                Console.WriteLine("Nuværende By: " + Addresse_by);
                                string Addresse_by1 = Console.ReadLine();
                                if (Addresse_by1 != "")
                                {
                                    Addresse_by = Addresse_by1;
                                }

                                string addresse_postnr = reader["addresse_postnr"].ToString();
                                Console.WriteLine("Indtast Postnummer");
                                Console.WriteLine("Nuværende Postnummer: " + addresse_postnr);
                                string addresse_postnr1 = Console.ReadLine();
                                if (addresse_postnr1 != "")
                                {
                                    addresse_postnr = addresse_postnr1;
                                }

                                string Tlf = reader["Tlf"].ToString();
                                Console.WriteLine("Indtast telefonnummer");
                                Console.WriteLine("Nuværende telefonnummer: " + Tlf);
                                string Tlf1 = Console.ReadLine();
                                if (Tlf1 != "")
                                {
                                    Tlf = Tlf1;
                                }

                                string Email = reader["Email"].ToString();
                                Console.WriteLine("Indtast email");
                                Console.WriteLine("Nuværende email: " + Email);
                                string Email1 = Console.ReadLine();
                                if (Email1 != "")
                                {
                                    Email = Email1;
                                }

                                string CPR_nr = reader["CPR_nr"].ToString();
                                Console.WriteLine("Indtast CPR nr");
                                Console.WriteLine("Nuværende CPR nr: " + CPR_nr);
                                string CPR_nr1 = Console.ReadLine();
                                if (CPR_nr1 != "")
                                {
                                    CPR_nr = CPR_nr1;
                                }

                                string konto_nr = reader["konto_nr"].ToString();
                                Console.WriteLine("Indtast Konto nr");
                                Console.WriteLine("Nuværende Konto nr: " + konto_nr);
                                string konto_nr1 = Console.ReadLine();
                                if (konto_nr1 != "")
                                {
                                    konto_nr = konto_nr1;
                                }

                                string reg_nr = reader["reg_nr"].ToString();
                                Console.WriteLine("Indtast Registrerings nr");
                                Console.WriteLine("Nuværende Registrerings nr: " + reg_nr);
                                string reg_nr1 = Console.ReadLine();
                                if (reg_nr1 != "")
                                {
                                    reg_nr = reg_nr1;
                                }

                                string Sundhedsoplysninger = reader["Sundhedsoplysninger"].ToString();
                                Console.WriteLine("Indtast Sundhedsoplysninger");
                                Console.WriteLine("Nuværende Sundhedsoplysninger: " + Sundhedsoplysninger);
                                string Sundhedsoplysninger1 = Console.ReadLine();
                                if (Sundhedsoplysninger1 != "")
                                {
                                    Sundhedsoplysninger = Sundhedsoplysninger1;
                                }

                                string JobType = reader["JobType"].ToString();
                                Console.WriteLine("Indtast JobType");
                                Console.WriteLine("Nuværende JobType: " + JobType);
                                string JobType1 = Console.ReadLine();
                                if (JobType1 != "")
                                {
                                    JobType = JobType1;
                                }

                                string MedarbejderNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("Indtast MedarbejderNr");
                                Console.WriteLine("Nuværende MedarbejderNr: " + MedarbejderNr);
                                string MedarbejderNr1 = Console.ReadLine();
                                if (MedarbejderNr1 != "")
                                {
                                    MedarbejderNr = MedarbejderNr1;
                                }

                                string KontaktPerson = reader["KontaktPerson"].ToString();
                                Console.WriteLine("Indtast Kontaktperson");
                                Console.WriteLine("Nuværende Kontaktperson: " + KontaktPerson);
                                string KontaktPerson1 = Console.ReadLine();
                                if (KontaktPerson1 != "")
                                {
                                    KontaktPerson = KontaktPerson1;
                                }

                                string KontaktNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("Indtast kontaktpersons telefonnummer");
                                Console.WriteLine("Nuværende kontaktpersons telefonnummer: " + KontaktNr);
                                string KontaktNr1 = Console.ReadLine();
                                if (KontaktNr1 != "")
                                {
                                    KontaktNr = KontaktNr1;
                                }


                                SqlCommand cmd2 = new SqlCommand("spOpdater", con);
                                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd2.Parameters.Add(new SqlParameter("@MedarbejderNr", Navn));
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Medarbejder Finn's ikke \n prøv igen");
                            Rediger(ID);
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Prøv igen " + e.Message + "\n");
                    }
                }
            }
        }

        public void Gemt(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
            Console.WriteLine("Gemt!");
            Thread.Sleep(2000);
        }

        public void Slet(int ID)
        {
            if (3 < ID)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
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
                            case ConsoleKey.Enter: menu.ShowMenu(ID); break;

                            default:
                                Console.WriteLine("Default case");
                                break;
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Dårligt lavet.." + e.Message + "\n");
                    }
                }
            }
            else
            {
                Menu menu = new Menu();
                menu.ShowMenu(ID);
            }
        }

        public void SkiftPassword(int id, string brugernavn, string kodeord, int AfdelingsID)
        {
              Menu menu = new Menu();
            Login l = new Login();
             using (SqlConnection con = new SqlConnection(connectionString))
             {

                 try
                 {
                     con.Open();
                     SqlCommand cmd = new SqlCommand("SkiftPassword", con);
                     cmd.CommandType = System.Data.CommandType.StoredProcedure;
                     Console.WriteLine("Indtast Nyt Password \n");
                     cmd.Parameters.Add(new SqlParameter("@Password", Console.ReadLine()));
                     cmd.Parameters.Add(new SqlParameter("@id", id));

                     cmd.ExecuteNonQuery();
                    l.Login1();
                 }
                 catch(SqlException e)
                 {
                     Console.WriteLine("UPS S S S S " + e.Message);
                 }
             }
        }
        
    }
}
