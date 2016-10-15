/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class Student : Person
    {
        private IWStrategy _wStrategy;

        public Student(IWStrategy wStrategy, string name, int age) : base(name, age) {
            this._wStrategy = wStrategy;
        }

        public void setWStrategy(IWStrategy wStrategy) {
            this._wStrategy = wStrategy;
        }

        public IWStrategy getWStrategy() {
            return this._wStrategy;
        }

        public void doWork() {
            this._wStrategy.doWork();
        }
    }
}
