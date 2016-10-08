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

namespace Delegates {
    class Program {
        static void Main(string[] args) {
            Subject sub = new Subject();
            sub.changeTemp("45°C");
            sub.handler += ObserverMethods.onValueChange;
            sub.changeTemp("45°C");
            sub.changePressure("20 bar");
            sub.changePressure("20 bar");
        }
    }
}
