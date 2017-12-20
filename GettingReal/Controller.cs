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
                        SqlCommand cmd = new SqlCommand("spOpdater", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Vælg hvad der skal ændres \n");
                        Console.WriteLine("1. Brugernavn");
                        Console.WriteLine("2. Fornavn");
                        Console.WriteLine("3. Efternavn");
                        Console.WriteLine("4. Adresse");
                        Console.WriteLine("5. Adresse linje 2");
                        Console.WriteLine("6. By");
                        Console.WriteLine("7. Post nummerr");
                        Console.WriteLine("8. Telefon nummer");
                        Console.WriteLine("9. Email");
                        Console.WriteLine("10. Konto nummerr");
                        Console.WriteLine("11. Registrerings nummer");
                        Console.WriteLine("12. Afdelings ID");
                        Console.WriteLine("13. Sundhedsoplysninger");
                        Console.WriteLine("14. Jobtype");
                        Console.WriteLine("15. Medarbejder nummer");
                        Console.WriteLine("16. Kontakt navn");
                        Console.WriteLine("17. Kontakt nummer");

                        Console.WriteLine("\nTryk 'Enter' for at vende tilbage til menuen");
                        var input = Console.ReadLine();

                        Menu menu = new Menu();
                        switch (input)
                        {

                            case "1":
                                Console.WriteLine("Indtast Brugernavn \n");
                                cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                                break;
                            case "2":
                                Console.WriteLine("Indtast Fornavn \n");
                                cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                                break;
                            case "3":
                                Console.WriteLine("Indtast Efternavn \n");
                                cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                                break;
                            case "4":
                                Console.WriteLine("Indtast adresse\n");
                                cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                                break;
                            case "5":
                                Console.WriteLine("Indtast adresse linje 2 \n");
                                cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                                break;
                            case "6":
                                Console.WriteLine("Indtast by \n");
                                cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                                break;
                            case "7":
                                Console.WriteLine("Indtast post nummer \n");
                                cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                                break;
                            case "8":
                                Console.WriteLine("Indtast telefon nummer \n");
                                cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                                break;
                            case "9":
                                Console.WriteLine("Indtast email \n");
                                cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                                break;
                            case "10":
                                Console.WriteLine("Indtast konto nummer \n");
                                cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                                break;
                            case "11":
                                Console.WriteLine("Indtast registrerings nummer \n");
                                cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                                break;
                            case "12":
                                Console.WriteLine("Indtast afdelings id \n");
                                cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                                break;
                            case "13":
                                Console.WriteLine("Indtast sundhedsoplysninger \n");
                                cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                                break;
                            case "14":
                                Console.WriteLine("Indtast jobtype \n");
                                cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                                break;
                            case "15":
                                Console.WriteLine("Indtast medarbejder nummer \n");
                                cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                                break;
                            case "16":
                                Console.WriteLine("Indtast kontakt navn \n");
                                cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                                break;
                            case "17":
                                Console.WriteLine("Indtast kontakt nummer \n");
                                cmd.Parameters.Add(new SqlParameter("@Navn", Console.ReadLine()));
                                break;

                            default:
                                Console.WriteLine("Default case");
                                break;

                        }
                        //Console.WriteLine("Indtast nyt brugernavn \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Brugernavn", Console.ReadLine()));
                        //Console.WriteLine("Indtast fornavn \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Fornavn", Console.ReadLine()));
                        //Console.WriteLine("Indtast efternavn \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Efternavn", Console.ReadLine()));
                        //Console.WriteLine("Indtast ny adresse \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Adresse", Console.ReadLine()));
                        //Console.WriteLine("Indtast adresse linje 2 \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Adressel2", Console.ReadLine()));
                        //Console.WriteLine("Indtast by \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@By", Console.ReadLine()));
                        //Console.WriteLine("Indtast ny post nummer \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Postnr", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt telefon nummer \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Tlf", Console.ReadLine()));
                        //Console.WriteLine("Indtast ny e-mail \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Email", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt konto nummer \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Konto", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt registrerings nummer \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Reg", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt afdelings ID \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@AfdelingsID", Console.ReadLine()));
                        //Console.WriteLine("Indtast nye sundhedsoplysninger \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@Sundhedsoplysninger", Console.ReadLine()));
                        //Console.WriteLine("Indtast ny jobtype \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@JobType", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt medarbejder nummer \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@MedarbejderNr", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt kontakt navn \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@KontaktPerson", Console.ReadLine()));
                        //Console.WriteLine("Indtast nyt kontakt nummer \n \n");
                        //cmd.Parameters.Add(new SqlParameter("@KontaktNr", Console.ReadLine()));

                        Console.Clear();

                        cmd.ExecuteNonQuery();
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
        public bool Move()
        {
            int col = 7;
            int row = 7;
            Console.SetCursorPosition(col, row);    //Places the "*" before the loop    //In column 7, row 7
            Console.Write("*");
            Console.SetCursorPosition(col, row);
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.UpArrow)       //Compares the given info in ReadKey to the given ConsoleKey ("W")
                {
                    Console.Write(" ");
                    Debug.Print("W");
                    row--;
                }
                if (info.Key == ConsoleKey.DownArrow)
                {
                    Console.Write(" ");
                    Debug.Print("S");
                    row++;
                }

                if (info.Key == ConsoleKey.LeftArrow)
                {
                    Console.Write(" ");
                    Debug.Print("A");
                    col--;
                }

                if (info.Key == ConsoleKey.RightArrow)
                {
                    Console.Write(" ");
                    Debug.Print("D");       //Writes a message followed by a line terminator to the trace listeners in the Listeners collection.
                    col++;
                }
                if (Console.WindowTop >= 180)

                    //Debug.Print & Console.Writeline
                    //Debug writes the message to the Output > Debug. Console.WriteLine writes the message to the standard output (Console).

                    Console.SetCursorPosition(col, row);    //Places the "*" after the loop
                Console.Write("*");
                Console.SetCursorPosition(col, row);
            }
        }
    }
}
