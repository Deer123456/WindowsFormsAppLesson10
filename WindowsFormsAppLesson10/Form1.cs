using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "=^_^=";
            button1.BackColor = Color.Blue;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "НЕ НАЖИМАЙ";
            label1.Text = "Made by Makaron";
            textBox1.Text = "Сотри тут";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Orange;
        }
    }
}
