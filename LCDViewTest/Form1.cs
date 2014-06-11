using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCDViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lcdView1.XPixels = Convert.ToInt32(txtX.Text);
            lcdView1.YPixels = Convert.ToInt32(txtY.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lcdView1.SetPixel(Convert.ToInt32(txtSetX.Text), Convert.ToInt32(txtSetY.Text),Color.Crimson);
        }
    }
}
