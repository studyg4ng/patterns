/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using ObSi;
using System.Xml;
using System.Diagnostics;

namespace Composite {
    class Program {
        static void Main(string[] args) {
            XmlDocument doc = FileIO.getXMLContent("../../media/input.xml");
            XmlComponentFactory componentFactory = XmlComponentFactory.getInstance();
            IComponent component = componentFactory.createComponentTree(doc);
            IComponent component1 = component.search("root");
            IComponent component2 = component.search("B4");
            IComponent component3 = component.search("C1");

            Debug.Assert(component.Name == component1.Name);
            Debug.Assert(component2.Price == 60);
            Debug.Assert(component.Price == 155);
            Console.ReadKey();
        } 
    }
}
