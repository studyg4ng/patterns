/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class Prof : Person
    {
        private decimal _salary; // weicht ab

        public Prof(decimal salary, string name, int age) : base(name, age) {
            this._salary = salary;
        }

        public decimal getSalary() {
            return this._salary;
        }

        public void setSalary(decimal salary) {
            this._salary = salary;
        }
    }
}
