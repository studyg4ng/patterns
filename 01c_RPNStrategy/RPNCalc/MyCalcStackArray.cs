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

namespace RPNCalc {
    class MyCalcStackArray<T> : IMyCalcStack<T> {

        private T[] _array;
        private int count = -1;

        public MyCalcStackArray(int capacity) {
            this._array = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count + 1;
            }
        }

        public T pop() {
            if(this.count >= 0) {
                T tmp = _array[count];
                count--;
                return tmp;
            }
            else {
                throw new Exception("Stack is empty");
            }
        }

        public void push(T item) {
            if(this.count < this._array.Length) {
                count++;
                _array[count] = item;
            }
            else {
                throw new Exception("Stack is full");
            }
        }
    }
}
