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
    interface Event {
        string getMessage();
    }

    enum EventType { TEMP_CHANGED, PRESSURE_CHANGED, HUMIDITY_CHANGED };

    class ObserverEvent : Event {
        public EventType eventType;
        public string message;

        public ObserverEvent(EventType eventType, string message) {
            this.eventType = eventType;
            this.message = message;
        }

        public string getMessage() {
            return this.message;
        }
    }
}
