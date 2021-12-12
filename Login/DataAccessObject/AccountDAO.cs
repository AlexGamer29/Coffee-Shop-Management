﻿using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USERPROC_Login @userName , @password";
            DataTable result = DataAccess.Instance.ExecuteQuery(query, new object[] {userName, passWord});
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string password, string newPassword)
        {
            string query = "USERPROC_UpdateAccount @userName , @displayName , @password , @newPassword";
            int data = DataAccess.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, password, newPassword });
            return data > 0;
        }

        /**
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataAccess.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        **/
        
        public Account GetAccountByUserName(string userName)
        {
            string query = "USERPROC_GetAccountByUserName @userName";
            DataTable data = DataAccess.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}