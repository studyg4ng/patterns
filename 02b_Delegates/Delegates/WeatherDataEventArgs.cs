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

    enum ValueType { TEMP, PRESSURE, HUMIDITY };

    class WeatherDataEventArgs : EventArgs {
        public ValueType valueType;
        public string changedValue;

        public WeatherDataEventArgs(ValueType valueType, string changedValue) {
            this.valueType = valueType;
            this.changedValue = changedValue;
        }
    }
}
