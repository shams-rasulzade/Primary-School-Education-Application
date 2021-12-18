using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary_School_Education_Application
{
    public partial class Animals_and_Names : Form
    {
        public Animals_and_Names()
        {
            InitializeComponent();
        }

        public void visible()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void Animals_and_Names_Load(object sender, EventArgs e)
        {
            visible();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            visible();
            MediaPlayer1.URL = @"C:\Users\HP\Downloads\dog.mp3";
            label1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            visible();
            MediaPlayer1.URL = @"C:\Users\HP\Downloads\cat.mp3";
            label2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            visible();
            MediaPlayer1.URL = @"C:\Users\HP\Downloads\cow.mp3";
            label3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            visible();
            MediaPlayer1.URL = @"C:\Users\HP\Downloads\duck.mp3";
            label4.Visible = true; 
        }
    }
}
