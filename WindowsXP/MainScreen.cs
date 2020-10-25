using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsXP
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnUser1_Click(object sender, EventArgs e)
        {
            txtpassword1.Visible = true;
            btnLogin1.Visible = true;
            label7.Visible = true;
        }

        private void btnUser2_Click(object sender, EventArgs e)
        {
            txtpassword2.Visible = true;
            btnLogin2.Visible = true;
            label8.Visible = true;
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"c:\Users\Mish\Desktop\WindowsXP.wav");
            splayer.Play();
            this.Hide();
            AdministratorHome obj = new AdministratorHome();
            obj.ShowDialog();
            this.Close();

            
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"c:\Users\Mish\Desktop\WindowsXP.wav");
            splayer.Play();
            this.Hide();
            AdministratorHome obj = new AdministratorHome();
            obj.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"c:\Users\Mish\Desktop\shutdown.wav");
            splayer.Play();
            this.Hide();

        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            SoundPlayer ssplayer = new SoundPlayer(@"c:\Users\Mish\Desktop\shutdown.wav");
            ssplayer.Play();
            this.Hide();
            Engine obj = new Engine();
            obj.ShowDialog();
            this.Close();
        }
    }
}
