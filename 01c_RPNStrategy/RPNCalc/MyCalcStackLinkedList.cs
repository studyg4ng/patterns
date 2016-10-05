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
    class MyCalcStackLinkedList<T> : IMyCalcStack<T> {

        private LinkedList<T> _linkedList = new LinkedList<T>();

        public MyCalcStackLinkedList() { }

        public int Count
        {
            get
            {
                return this._linkedList.Count;
            }
        }

        public T pop() {
            if(this._linkedList.Count > 0) {
                T tmp = this._linkedList.Last.Value;
                this._linkedList.RemoveLast();
                return tmp;
            }
            else {
                throw new Exception("Stack is empty");
            }
        }

        public void push(T item) {
            this._linkedList.AddLast(item);
        }
    }
}
