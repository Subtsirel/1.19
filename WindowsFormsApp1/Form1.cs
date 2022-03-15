using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text ="мина!";
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "осталось 4 мины";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "осталось 4 мины";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "осталось 4 мины";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "мина!";
            BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "осталось 4 мины";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "мина!";
            BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "пусто,осталось 4 мины";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "мина!";
            BackColor = Color.Red;
        }
    }
}
