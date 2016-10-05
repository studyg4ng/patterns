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

namespace RPNCalc
{
    class Program
    {
        static void Main(string[] args) {

            args = new string[] { "1,5", "2", "+", "3", "4", "-", "*" };

            IMyCalcStack<double> stack1 = new MyCalcStackArray<double>(20);
            IMyCalcStack<double> stack2 = new MyCalcStackLinkedList<double>();
            RPNCalc rpnClac1 = new RPNCalc(stack1);
            RPNCalc rpnClac2 = new RPNCalc(stack2);

            Console.WriteLine("ARRAY:");
            rpnClac1.calculateAndPrint(args);
            Console.WriteLine();

            Console.WriteLine("LinkedList:");
            rpnClac2.calculateAndPrint(args);
            Console.ReadLine();

        }
    }
}
