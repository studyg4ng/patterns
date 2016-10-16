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
        private int _count = -1;

        public MyCalcStackArray(int capacity) {
            this._array = new T[capacity];
        }

        public int count
        {
            get
            {
                return this._count + 1;
            }
        }

        public T pop() {
            if(this._count >= 0) {
                T tmp = _array[_count];
                _count--;
                return tmp;
            }
            else {
                throw new Exception("Stack is empty");
            }
        }

        public void push(T item) {
            if(this._count < this._array.Length) {
                _count++;
                _array[_count] = item;
            }
            else {
                throw new Exception("Stack is full");
            }
        }
    }
}
