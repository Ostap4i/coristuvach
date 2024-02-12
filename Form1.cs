using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 500;
            timer2.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = listBox2.Text;
            listBox2.Items.Add(str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = listBox2.Text;
            listBox2.Items.Remove(str);
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Add("");
        }
    }
}
