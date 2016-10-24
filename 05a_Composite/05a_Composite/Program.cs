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

namespace _05a_Composite {
    class Program {
        static void Main(string[] args) {

            Task monday = new Task(0, "MONTAG");

            Task homework = new Task(0, "HOMEWORK");
            Task morning = new Task(0, "MORNING");
            Task getOutOfBed = new Task(0, "EAT");

            getOutOfBed.add(new Task(20, "Eat Sausages"));
            getOutOfBed.add(new Task(20, "Eat Bacon"));
            getOutOfBed.add(new Task(20, "Eat Pumpkin"));

            morning.add(new Task(20, "Put on Clothes"));
            morning.add(new Task(20, "Brush teeth"));
            morning.add(new Task(20, "Prepare food"));

            homework.add(new Task(1, "Open Book"));
            homework.add(new Task(333, "Do ........ homework"));
            homework.add(new Task(333, "Push to Master"));

            morning.add(getOutOfBed);
            monday.add(morning);
            monday.add(homework);

            monday.printTaskDescription("");
        }
    }
}
