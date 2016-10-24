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
    interface IComponent {
        double Price { get; }
        string Name { get; }
        void add(IComponent component);
        void remove(IComponent component);
        void operation();
        void accept(IVisitor visitor);
        IComponent search(string name);
    }
}
