using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InitialProxy
{
    public partial class Form1 : Form
    {
        //private String urlPrefix = "file:///c:/Users/Andreas/Pictures/";     // private readonly Image DUMMY = Image.FromFile(@"C:\Users\Andreas\Pictures\WAITING.jpg");
        static private String urlPrefix = "http://student.cosy.sbg.ac.at/~anaderli/fh/";
        static String[] filenames = { "Penguins.jpg", "Koala.jpg", "Desert.jpg", "Tulips.jpg", "Jellyfish.jpg", "Lighthouse.jpg" };
        static MyPictureBox pb;
        static AbstractImage image = new ProxyImage(urlPrefix + filenames[0], new ProgressChangedEventHandler(bgw_ProgressChanged));

        public Form1()
        {
            InitializeComponent();

            //RealImage image = new RealImage(urlPrefix + filenames[0]);
            
            pb = new MyPictureBox(image);
            
            pb.Image = image.getImage();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(200, 200);
            pb.Location = new Point(0, 0);
            Controls.Add(pb);
        }

        private static void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            pb.Image = image.getImage();
        }
    }
}
