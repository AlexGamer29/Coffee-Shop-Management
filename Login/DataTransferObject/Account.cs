using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataTransferObject
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;
        private int accountType;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int AccountType { get => accountType; set => accountType = value; }

        public Account(string userName, string displayName, int accountType, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.AccountType = accountType;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = (string)row["userName"].ToString();
            this.DisplayName = (string)row["displayName"].ToString();
            this.AccountType = (int)row["accountType"];
            this.Password = row["password"].ToString();
        }
    }
}
