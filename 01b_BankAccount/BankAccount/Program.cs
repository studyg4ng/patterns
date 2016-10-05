/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Account a = new Account("Hans", "1234-001");
            Account b = new Account("Susi", "1234-002");
            Debug.Assert(m.CountAccounts() == 0);
            m.AddAccount(a);
            m.AddAccount(b);
            Debug.Assert(m.CountAccounts() == 2);

            Console.Out.WriteLine("---");
            m.DumpAccounts();
            Console.Out.WriteLine("---");
            Console.Out.WriteLine(a);
            a.Deposit(100);
            Console.Out.WriteLine(a);
            a.WithDraw(200);
            Console.Out.WriteLine(a);
            Console.Out.WriteLine("---");
            m.DumpAccounts();

            BoundedAccount tom = new BoundedAccount("Thomas", "0000-0001");
            Logger logger = new Logger();
            tom.registerObserver(logger);
            tom.Deposit(20000);
            tom.Deposit(10000);
            tom.Deposit(25000);
            tom.Deposit(30000);
            tom.Deposit(40000);
            Console.WriteLine("Tom's aktuelles Geld: " + tom.Money);

            try
            {
                tom.WithDraw(50000);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            tom.WithDraw(20000);
            Console.WriteLine("Tom's aktuelles Geld: " + tom.Money);

            Console.In.ReadLine();
        }
    }
}
