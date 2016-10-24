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
using System.Xml;

namespace Composite {
    class JsonComponentFactory : IComponentFactory {
        private static JsonComponentFactory _instance;

        private JsonComponentFactory() { }

        public static JsonComponentFactory getInstance() {
            if (JsonComponentFactory._instance == null) return JsonComponentFactory._instance = new JsonComponentFactory();
            else return JsonComponentFactory._instance;
        }

        public IComponent createComponentTree(Object o) {
            return new List();
        }
    }
}
