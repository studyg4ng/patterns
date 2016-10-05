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
    class Program
    {
        static void Main(string[] args) {
            Subject sub = new Subject();
            sub.registerObserver(new TempObserver());
            sub.changePressure("10 bar");
            sub.registerObserver(new PressureObserver());
            sub.changeTemp("45°C");
            sub.changePressure("20 bar");
        }
    }
}
