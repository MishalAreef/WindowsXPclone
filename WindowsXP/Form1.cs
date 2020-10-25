using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsXP
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int bottom,
            int width,
            int height
            );

        int[] rainSpeeds = { 4 };
        int LoadingSpeed = 10;
        float initialPercentage = 0;

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
            this.ResumeLayout();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            initialPercentage += LoadingSpeed;
            float percentage = initialPercentage / pictureBox2.Height * 2;

            label1.Text = (int)percentage + " %";

            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + LoadingSpeed);
            if (panel2.Location.Y > pictureBox2.Location.Y + pictureBox2.Height)
            {
                label1.Text = "2 %";
                this.timer2.Stop();
                Hide();
                MainScreen win = new MainScreen();
                win.ShowDialog();
                Close();
            }
        }
    }
}
