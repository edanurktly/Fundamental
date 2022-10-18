using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeController
{
    public partial class Form2 : Form
    {
        int _X = 0;
        int _Y = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pcb.ImageLocation = "sag.jpeg";
            timer1.Interval = 10;
            pcb.Width = 100;
            pcb.Height = 50;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==37)
            {
                pcb.Width = 100;
                pcb.Height = 50;
                pcb.ImageLocation = "sol.jpeg";
                _X = -1;
                _Y = 0;
                timer1.Start();

            }
            else if(e.KeyValue==38)
            {
                pcb.Width = 100;
                pcb.Height = 52;
                pcb.ImageLocation = "yukari.jpeg";
                _X = 0;
                _Y = -1;
                timer1.Start();
            }
            else if(e.KeyValue==39)
            {
                pcb.Width = 100;
                pcb.Height = 50;
                pcb.ImageLocation = "sag.jpeg";
                _X = 1;
                _Y = 0;
                timer1.Start();
            }
            else if(e.KeyValue==40)
            {
                pcb.Width = 50;
                pcb.Height = 100;
                pcb.ImageLocation = "asagi.jpeg";
                _X = 0;
                _Y = 1;
                timer1.Start();
            }
            else if(e.KeyValue==32)
            {
                timer1.Stop();
            }

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();
            pcb.Left += _X;
            pcb.Top += _Y;
            label1.Text = "x:" +pcb.Location.X + "y:" +pcb.Location.Y;

        }
    }
}
