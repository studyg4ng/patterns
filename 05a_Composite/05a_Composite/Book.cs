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
    class Book : IComponent {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }

        public IComponent search(string name) {
            return (this.Name == name) ? this : null;
        }

        public void add(IComponent component) {
            throw new NotImplementedException();
        }

        public void remove(IComponent component) {
            throw new NotImplementedException();
        }
    }
}
