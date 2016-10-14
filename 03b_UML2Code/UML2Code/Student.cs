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
        private WStrategy _wStrategy;

        public Student(WStrategy wStrategy) {
            this._wStrategy = wStrategy;
        }

        public void setWStrategy(WStrategy wStrategy) {
            this._wStrategy = wStrategy;
        }

        public void doWork() {
            this._wStrategy.doWork();
        }

    }
}
