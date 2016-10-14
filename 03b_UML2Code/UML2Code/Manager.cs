/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;

namespace UML2Code {
    class Manager : ISubject
    {
        private static Manager _instance;
        private List<IObserver> _observers = new List<IObserver>();

        private Manager() {

        }

        public static Manager getInstance() {
            if(_instance == null) return new Manager();
            else return _instance;
        }

        public void addObserver(IObserver observer) {
            this._observers.Add(observer);
        }

        public void notifiyObserver() {
            foreach(IObserver observer in _instance._observers) {
                observer.update(new Event());
            }
        }

        public void removeObserver(IObserver observer) {
            _instance._observers.Remove(observer);
        }
    }
}
