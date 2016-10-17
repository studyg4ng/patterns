/*1510601027 fhs38532
  Thomas Siller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.ComponentModel; //needed for BackgroundWorker

namespace Factory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //TODO: remove the static keywords

        /*private static BackgroundWorker bgw;


        private static void test()
        {

            bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.DoWork += new DoWorkEventHandler(doSomething);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerAsync();
        }

        private static void doSomething(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("start...");
            for (int i = 0; i < 1000000000; i++)
            {
                //nothing.
            }
            Console.WriteLine("finished.");
            bgw.ReportProgress(100);
        }

        private static void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 100)
                Console.WriteLine("received completion notification.");
        }*/
    }
}
