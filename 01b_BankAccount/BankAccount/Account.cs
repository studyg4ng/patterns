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
    class Account
    {
        private List<IObserver<string>> observers = new List<IObserver<string>>();
        public string Name {get;set;}
        public string Number { get; set; }
        public double Money { get; set;}

        public Account(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public void registerObserver(IObserver<string> observer) {
            observers.Add(observer);
        }

        public void removeObserver(IObserver<string> observer) {
            observers.Remove(observer);
        }

        public void notifyObservers(string message) {
            foreach(IObserver<string> o in observers) {
                o.OnNext(String.Format("Number: {0}; Name: {1}; Money: {2}; --> ", Number, Name, Money) + message);
            }
        }

        public void Deposit(double value)
        {
            notifyObservers(String.Format("Deposit {0}", value));
            Money += value;
        }

        public virtual void WithDraw(double value)
        {
            notifyObservers(String.Format("Withdraw {0}", value));
            Money -= value;
        }

        public double GetBalance()
        {
            return Money;
        }

        public override string ToString()
        {
            return Number + " (" + Name + "): " + Money;
        }        
    }
}
