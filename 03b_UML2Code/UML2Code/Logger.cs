/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class Logger : IObserver {
        public void update(Event e) {
            Console.WriteLine("LOG: {0}", "notImplemented");
        }
    }
}
