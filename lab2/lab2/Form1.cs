using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm1 = new Form2();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm1 = new Form3();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm1 = new Form4();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm1 = new Form5();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm1 = new Form6();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm1 = new Form7();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm1 = new Form8();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }
    }
}
