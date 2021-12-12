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
        private Account account;

        public Account Account { get => account; set => account = value; }

        public AccountEvent(Account account)
        {
            this.Account = account;
        }
    }
}
