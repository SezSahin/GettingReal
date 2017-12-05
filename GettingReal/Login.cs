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

        private string username;
        private string password;
        private bool usersuccessful;
        private bool passsuccessful;

        public Login(string user, string pass)
        {
            
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


