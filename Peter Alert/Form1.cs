using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peter_Alert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            MessageBox.Show(screenWidth + screenHeight);
            //Form1.Location = new Point(100, 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            Form c = new Form1();
            c.Show();

            this.Hide();
        }
    }
}
