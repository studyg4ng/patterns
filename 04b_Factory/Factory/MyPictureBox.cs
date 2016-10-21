/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Factory
{
    public class MyPictureBox : PictureBox
    {
        private AbstractImage _myImage;

        public MyPictureBox(AbstractImage image)
            : base()
        {
            this._myImage = image;
            this._myImage.onImageLoaded += update;
        }

        public void update(object sender, EventArgs args) {
            if(sender is AbstractImage) {
                AbstractImage img = (AbstractImage)sender;
                base.Image = img.getImage();
            }
        }
    }
}
