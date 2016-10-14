/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    interface ISubject // weicht ab
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifiyObserver();
    }
}
