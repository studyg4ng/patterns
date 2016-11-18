using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario {
    class Program {
        private static ConsoleKey _inputKey; 

        static void Main(string[] args) {
            Hero SuperMario = new Hero();

            while(_inputKey != ConsoleKey.Escape) {
                _inputKey = Console.ReadKey().Key;
                SuperMario.handleInput(_inputKey);
            }
        }
    }
}
