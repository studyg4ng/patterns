/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace UML2Code {
    static class Program {
        static void Main() {
            Logger logger = new Logger();

            Manager drThomas = Manager.getInstance();
            Debug.Assert(drThomas == Manager.getInstance());

            drThomas.addObserver(logger);

            Student patrick = new Student(new Eagerness(), "Patrick", 20);
            Student thomas = new Student(new Procrastination(), "Thomas", 24);
            Person andi = new Student(new Eagerness(), "Andi", 32);
            Person chris = new Student(new Procrastination(), "Chris", 19);

            Person paul = new Prof(5000, "Paul", 18);
            Person valters = new Prof(6400.50m, "Paul", 50);

            drThomas.addPerson(patrick);
            drThomas.addPerson(thomas);
            drThomas.addPerson(andi);
            drThomas.addPerson(chris);

            patrick.doWork();
            thomas.doWork();

            patrick.addAdress(new Address("Urstein Süd 5", "5412", "AT", "Puch bei Hallein"));
            patrick.addAdress(new Address("Schmiedberg 16", "4483", "AT", "Hargelsberg"));
            thomas.addAdress(new Address("Salzachweg 2", "5061", "AT", "Elsbethen"));

            writeFrame();
            foreach (Address address in patrick.getAddresses())
            {
                Console.WriteLine("{0}", address.getText());
            }
            writeFrame();

            drThomas.removePerson(patrick);
            Debug.Assert(drThomas.countPersons() == 3);

            Console.ReadKey();
        }

        private static void writeFrame() {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
