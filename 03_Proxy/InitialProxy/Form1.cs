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
        private String urlPrefix = "http://student.cosy.sbg.ac.at/~anaderli/fh/";
        String[] filenames = { "Penguins.jpg", "Koala.jpg", "Desert.jpg", "Tulips.jpg", "Jellyfish.jpg", "Lighthouse.jpg" };

        public Form1()
        {
            InitializeComponent();

            //RealImage image = new RealImage(urlPrefix + filenames[0]);
            AbstractImage image = new ProxyImage();
            MyPictureBox pb = new MyPictureBox(image);
            
            pb.Image = image.getImage(urlPrefix + filenames[0]);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(200, 200);
            pb.Location = new Point(0, 0);
            Controls.Add(pb);
        }
    }
}
