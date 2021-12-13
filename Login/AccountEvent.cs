using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class AccountEvent : EventArgs
    {
        private AccountAuthentication account;

        public AccountAuthentication Account { get => account; set => account = value; }

        public AccountEvent(AccountAuthentication account)
        {
            this.Account = account;
        }
    }
}
