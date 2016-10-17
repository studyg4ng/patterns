/*1510601027 fhs38532
  Thomas Siller*/

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
        AbstractImage myImage;

        public MyPictureBox(AbstractImage image)
            : base()
        {
            this.myImage = image;
        }
    }
}
