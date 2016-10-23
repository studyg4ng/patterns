/*1510601027 fhs38532
  Thomas Siller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Decorator {
    class Program {
        static void Main(string[] args) { 
            StreamReader reader = new StreamReader(new StreamRot13(new StreamRot13(File.OpenRead(@"../../input.txt")), true));
            Console.WriteLine(reader.ReadLine());
            Console.ReadKey();
        }
    }
}
