/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class Eagerness : IWStrategy {
        public void doWork() {
            Console.WriteLine("{0} in {1}", "doWork", this.GetType().Name);
        }
    }
}
