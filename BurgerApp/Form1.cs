using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel1.Height = button1.Height;
            firstCustomControl2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button1.Height;
            SidePanel1.Top = button1.Top;
            firstCustomControl2.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button16.Height;
            SidePanel1.Top = button16.Top;
            secondCustomControl2.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
