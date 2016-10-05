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
    class RPNCalc
    {
        IMyCalcStack<double> _stack;

        public RPNCalc(IMyCalcStack<double> stack) { // set implementation
            this._stack = stack;
        }

        private Boolean tryParseToDouble(string element, out double parsedElement) {
            if(Double.TryParse(element, out parsedElement)) {
                return true;
            }
            return false;
        }

        public void calculateAndPrint(string[] rpnExpression) {
            Console.WriteLine("RPN-Expression: " + String.Join("; ", rpnExpression));
            string result = this.calculate(rpnExpression);
            Console.WriteLine("Result: " + result);
        }

        private string calculate(string[] expression) {
            double tmp;

            foreach(String str in expression) {
                if(tryParseToDouble(str.Trim(), out tmp)) {
                    _stack.push(tmp);
                }
                else {
                    char op = str[0];
                    Double v2 = _stack.pop();
                    Double v1 = _stack.pop();
                    switch(op) {
                        case '+':
                            _stack.push(v1 + v2);
                            break;
                        case '-':
                            _stack.push(v1 - v2);
                            break;
                        case '*':
                            _stack.push(v1 * v2);
                            break;
                        case '/':
                            _stack.push(v1 / v2);
                            break;
                        default:
                            throw new Exception("Illegal argument: " + str);
                    }
                }
            }

            if(_stack.Count == 1) {
                return _stack.pop().ToString();
            }
            else {
                throw new Exception("Invalid Expression");
            }
        }
    }
}
