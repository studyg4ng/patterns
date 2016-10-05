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
    class BoundedAccount : Account
    {
        public BoundedAccount(string name, string number) : base(name,number)
        {
        }

        public override void WithDraw(double value)
        {
            if (base.Money - value < 0)
            {
                throw new Exception("Student Account may not withdraw more than available");
            }
            else base.WithDraw(value); //redundancy removed 
        }
    }
}
