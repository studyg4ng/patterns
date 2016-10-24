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
    class Task {
        private List<Task> _tasks = new List<Task>();
        private double _time;
        private string _description;

        public Task(double time = 0, string description = "!description missing!") {
            this._time = time;
            this._description = description;
        }

        public void add(Task task) {
            this._tasks.Add(task);
        }

        public void remove(Task task) {
            this._tasks.Remove(task);
        }

        public double getTime() {
            double timeSum = this._time;

            foreach (Task t in _tasks) {
                timeSum += t.getTime();
            }
            return timeSum;
        }

        public string formateTaskInformation() {
            return String.Format("{0} ({1}t)", this._description, this.getTime());
        }

        public void printTaskDescription(string tmp) {
            Console.WriteLine(tmp + this.formateTaskInformation());

            foreach (Task t in _tasks) {
                t.printTaskDescription("-" + tmp);
            }
        }
    }
}
