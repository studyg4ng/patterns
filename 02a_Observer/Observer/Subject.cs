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
    class Subject : ISubject {

        private List<IObserver> _observers = new List<IObserver>();
        private string _temp, _pressure, _humidity;

        public void registerObserver(IObserver observer) {
            _observers.Add(observer);
        }

        public void removeObserver(IObserver observer) {
            _observers.Remove(observer);
        }

        public void notifyObservers(Event e) {
            foreach (IObserver observer in this._observers) {
                observer.update(e);
            }
        }

        public void changeTemp(string temp) {
            this._temp = temp;
            notifyObservers(new ObserverEvent(EventType.TEMP_CHANGED, temp));
        }

        public void changePressure(string pressure) {
            this._pressure = pressure;
            notifyObservers(new ObserverEvent(EventType.PRESSURE_CHANGED, pressure));
        }

        public void changeHumidity(string humidity) {
            this._humidity = humidity;
            notifyObservers(new ObserverEvent(EventType.HUMIDITY_CHANGED, humidity));
        }
    }
}
