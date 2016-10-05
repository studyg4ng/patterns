/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Manager
    {
        private List<Account> accounts = new List<Account>();

        public List<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public void AddAccount(Account a)
        {
            accounts.Add(a);
        }

        public void DumpAccounts()
        {
            foreach (Account a in accounts) Console.Out.WriteLine(a);
        }

        public int CountAccounts()
        {
            return accounts.Count();
        }
    }
}
