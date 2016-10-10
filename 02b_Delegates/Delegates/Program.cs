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
            sub.handler += onValueChange;
            sub.changeTemp("45°C");
            sub.changePressure("20 bar");
            sub.changePressure("20 bar");
        }

        public static void onValueChange(object sender, EventArgs args) {
            WeatherDataEventArgs wdArgs = (WeatherDataEventArgs)args;

            switch(wdArgs.valueType) {
                case ValueType.HUMIDITY:
                    Console.WriteLine("NEW TEMP: {0}", wdArgs.changedValue);
                    break;
                case ValueType.PRESSURE:
                    Console.WriteLine("NEW PRESSURE: {0}", wdArgs.changedValue);
                    break;
                case ValueType.TEMP:
                    Console.WriteLine("NEW TEMP: {0}", wdArgs.changedValue);
                    break;
            }
        }
    }
}
