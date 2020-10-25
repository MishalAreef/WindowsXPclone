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
    public partial class AdministratorHome : Form
    {
        public AdministratorHome()
        {
            InitializeComponent();
        }

        private void AdministratorHome_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            panel7.Visible = true;
            panel5.Visible = true;
            pictureBox1.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"c:\Users\Mish\Desktop\logoff.wav");
            splayer.Play();
            this.Hide();
            MainScreen obj = new MainScreen();
            obj.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
