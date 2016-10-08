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
    class ObserverMethods {
        public static void onValueChange(object sender, EventArgs args) {
            WeatherDataEventArgs wdArgs = (WeatherDataEventArgs) args;

            switch(wdArgs.valueType) {
                case ValueType.HUMIDITY_CHANGED:
                    Console.WriteLine("NEW TEMP: {0}", wdArgs.changedValue);
                    break;
                case ValueType.PRESSURE_CHANGED:
                    Console.WriteLine("NEW PRESSURE: {0}", wdArgs.changedValue);
                    break;
                case ValueType.TEMP_CHANGED:
                    Console.WriteLine("NEW TEMP: {0}", wdArgs.changedValue);
                    break;
            }
        }
    }
}
