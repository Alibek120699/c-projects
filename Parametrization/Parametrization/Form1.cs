using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametrization
{
    public partial class Form1 : Form
    {

        Graphics g;
        Bitmap bmp;
        Pen pen = new Pen(Color.Black);
        //int x = 5;
        //int y = 5;
        //bool d = true;
        int xc, yc, r, rs, asec;
        int prevx, prevy, curx, cury;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            xc = 95;
            yc = 95;
            r = 90;
            rs = r;
            asec = 90;
            prevx = (int)(rs * Math.Cos(asec * Math.PI / 180));
            prevy = (int)(rs * Math.Sin(asec * Math.PI / 180));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            asec += 1;
            xc += 1;
            curx = (int)(rs * Math.Cos(asec * Math.PI / 180));
            cury = (int)(rs * Math.Sin(asec * Math.PI / 180));
            g.DrawLine(pen, xc + curx, yc +cury, xc +prevx,yc + prevy);
            prevx = curx;
            prevy = cury;
            Refresh();
        }

      

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue);
            e.Graphics.DrawEllipse(pen, xc - r, yc - r, 2 * r, 2 * r);
            int xs = (int)(rs * Math.Cos(asec * Math.PI / 180));
            int ys = (int)(rs * Math.Sin(asec * Math.PI / 180));
            
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), xc + xs, yc + ys, 4, 4);
        }
    }
}
