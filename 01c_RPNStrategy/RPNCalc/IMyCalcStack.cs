﻿/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalc
{
    interface IMyCalcStack<T>
    {
        int count { get; }
        T pop();
        void push(T item);
    }
}
