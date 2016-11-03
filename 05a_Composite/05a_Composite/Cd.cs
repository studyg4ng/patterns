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

namespace Composite {
    class Cd : IComponent {
        public string Name { get; set; }
        public double Price { get; set; }

        public IComponent search(string name) {
            return (this.Name == name) ? this : null;
        }
    }
}
