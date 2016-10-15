/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class Address
    {
        private string _street;
        private string _zip;
        private string _country;
        private string _state;

        public Address(string street, string zip, string country, string state) {
            this._street = street;
            this._zip = zip;
            this._country = country;
            this._state = state;
        }

        public void setStreet(string street) {
            this._street = street;
        }

        public string getStreet() {
            return this._street;
        }

        public void setZip(string zip) {
            this._zip = zip;
        }

        public string getZip() {
            return this._zip;
        }

        public void setCountry(string country) {
            this._country = country;
        }

        public string getCountry() {
            return this._country;
        }

        public void setState(string state) {
            this._state = state;
        }

        public string getState() {
            return this._state;
        }

        public string getText() {
            return String.Format("{0}-{1} {2}-{3}", this._country, this._zip,  this._state, this._street);
        }

        public string toString() {
            return String.Format("Country: {0}; Zip: {1}; State: {2}; Street: {3}", this._country, this._zip, this._state, this._street);
        }
    }
}
