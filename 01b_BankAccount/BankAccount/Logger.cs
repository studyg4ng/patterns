/*1510601027 fhs38532
  Thomas Siller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Logger : IObserver<string> {
        public void OnCompleted() {
            throw new NotImplementedException();
        }

        public void OnError(Exception error) {
            throw new NotImplementedException();
        }

        public void OnNext(string value) {
            Console.WriteLine("LOGGER: {0}", value);
        }
    }
}
