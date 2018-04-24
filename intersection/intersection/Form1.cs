using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intersection
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        public Button btn;

        private void Form1_Load(object sender, EventArgs e)
        {
            int k = 0;   
            for (int i=0; i<6; ++i)
            {
                for(int j=0; j<6; ++j)
                {
                    btn = new Button();
                    btn.Location = new Point(i * 70, j * 70);
                    btn.Name = i.ToString() + "_" + j.ToString();
                    btn.Text = k.ToString();
                    k++;
                    btn.Size = new Size(70, 70);
                    this.Controls.Add(btn);
                    this.btn.Click += draw_intersection;
                    
                }
            }
        }

        private void draw_intersection(object sender, EventArgs e)
        {
            Clear();
            Button btn = sender as Button;
            int x = int.Parse(btn.Name[0].ToString());
            int y = int.Parse(btn.Name[2].ToString());
            for (int i=0; i<6; i++)
            {
                this.Controls[6 * x + i].BackColor = Color.Red;
                this.Controls[i * 6 + y].BackColor = Color.Red;
            }
        }

        private void Clear()
        {
            for (int i = 0; i < 36; ++i)
            {
                this.Controls[i].BackColor = default(Color);
            }
        }

    }
}
