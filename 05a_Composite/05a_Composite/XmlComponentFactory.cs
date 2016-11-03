/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Xml;

namespace Composite {
    class XmlComponentFactory : IComponentFactory {
        private static XmlComponentFactory _instance;

        private XmlComponentFactory() { }

        public static XmlComponentFactory getInstance() {
            if (XmlComponentFactory._instance == null) return XmlComponentFactory._instance = new XmlComponentFactory();
            else return XmlComponentFactory._instance;
        }

        public IComponent createComponentTree(Object o) {
            XmlDocument xmldoc = o as XmlDocument;
            IComponent root = buildComponentSubTree(xmldoc.FirstChild);
            return root;
        }

        private IComponent buildComponentSubTree(XmlNode node) {
            switch (node.Name)
            {
                case "list":
                    return createList(node);
                case "book":
                    return createBook(node);
                case "cd":
                    return createCd(node);
                default:
                    return null;
            }
        }
        
        private List createList(XmlNode node) {
            List list = new List();
            list.Name = node.Attributes["name"].Value;

            foreach (XmlNode child in node.ChildNodes)
            {
                list.add(buildComponentSubTree(child));
            }

            return list;
        }

        private Book createBook(XmlNode node) {
            Book book = new Book();
            book.Name = node.Attributes["name"].Value;
            book.Isbn = node.Attributes["isbn"].Value;
            double price = Double.TryParse(node.Attributes["price"].Value, out price) ? price : 0;
            book.Price = price;

            return book;
        }

        private Cd createCd(XmlNode node) {
            Cd cd = new Cd();
            cd.Name = node.Attributes["name"].Value;
            double price = Double.TryParse(node.Attributes["price"].Value, out price) ? price : 0;
            cd.Price = price;

            return cd;
        }
    }
}
