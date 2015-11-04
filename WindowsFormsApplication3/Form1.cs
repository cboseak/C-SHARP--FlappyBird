using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int speedOfLevel = 5;
        bool paused = true;

        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            trackBar1.Value = 5;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Hide();
            if (e.KeyChar == (char)Keys.Space && paused == false)
            {
                button1.Top -= 15;
            }   
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (paused == false)
                {
                    timer1.Stop();
                    paused = true;
                    label2.BringToFront();
                    label2.Show();
                    label3.Hide();
                }
                else if(paused == true)
                {
                    timer1.Start();
                    paused = false;
                    label2.Hide();
                    label3.Show();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left -= speedOfLevel;
            button1.Top += 3;
            button1.Left += speedOfLevel;
            if(button1.Top <= 10)
            {
                button1.Top = 10;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value == 1)
            {
                speedOfLevel = 1;
            }
            else if(trackBar1.Value == 2)
            {
                speedOfLevel = 2;
            }
            else if (trackBar1.Value == 3)
            {
                speedOfLevel = 3;
            }
            else if (trackBar1.Value == 4)
            {
                speedOfLevel = 4;
            }
            else if (trackBar1.Value == 5)
            {
                speedOfLevel = 5;
            }
            else if (trackBar1.Value == 6)
            {
                speedOfLevel = 6;
            }
            else if (trackBar1.Value == 7)
            {
                speedOfLevel = 7;
            }
        }
        private void detectCollision(PictureBox picObj)
        {  
            //TODO: Implement collision logic
        }

    }
}
