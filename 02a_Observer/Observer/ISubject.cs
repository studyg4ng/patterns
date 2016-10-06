/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer {
    interface ISubject {
        void registerObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers(Event e);
    }
}
