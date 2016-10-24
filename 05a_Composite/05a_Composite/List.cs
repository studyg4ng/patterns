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
    class List : IComponent {
        private List<IComponent> _list = new List<IComponent>();
        public string Name { get; set; }

        public double Price {
            get {
                double sum = 0;
                foreach (IComponent component in this._list)
                {
                    sum += component.Price;   
                }
                return sum;
            }
        }

        public void add(IComponent component) {
            this._list.Add(component);
        }

        public void remove(IComponent component) {
            this._list.Remove(component);
        }
        public void operation() {
            throw new NotImplementedException();
        }

        public void accept(IVisitor visitor) {
            visitor.visit(this);
        }

        public IComponent search(string name) {
            if (this.Name == name) return this;
            else
            {
                foreach (IComponent component in _list)
                {
                    if (component.search(name) != null) return component.search(name);
                    // return component.search(name);
                }
            }
            return null; // not found
        }
    }
}
