/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        private String _urlPrefix = "http://student.cosy.sbg.ac.at/~anaderli/fh/";
        private String[] _filenames = { "Penguins.jpg", "Koala.jpg", "Desert.jpg", "Tulips.jpg", "Jellyfish.jpg", "Lighthouse.jpg" };
        private MyPictureBox _pb;
        private AbstractImage _image;

        public Form1()
        {
            InitializeComponent();
            ImageFactory imageFactory = ImageFactory.getInstance();

            _image = imageFactory.createImage(_urlPrefix + _filenames[0]);

            _pb = new MyPictureBox(_image);
            _pb.Image = _image.getImage();

            _pb.SizeMode = PictureBoxSizeMode.Zoom;
            _pb.Size = new Size(200, 200);
            _pb.Location = new Point(0, 0);
            Controls.Add(_pb);
        }
    }
}
