using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bounceParametrization
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        Pen pen = new Pen(Color.Black, 1);
        Brush dot = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //gfx.DrawEllipse(pen, 40, 40, 100, 100);
            //gfx.FillEllipse(dot, 90, 90, 5, 5);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        void drawCircle()
        {

        }
        
    }
}
