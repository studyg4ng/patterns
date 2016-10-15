/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class Logger : IObserver {
        public void update(EventArgs args) {
            PersonEventArgs personArgs = args as PersonEventArgs; // casts e in pArgs
            Console.WriteLine("LOG: {0} has been {1}.", personArgs.person.getName(), personArgs.methodName);
        }
    }
}
