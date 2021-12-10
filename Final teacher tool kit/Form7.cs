using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_teacher_tool_kit
{
    public partial class Form7 : Form
    {
        float timer1a = 5;
        float timer = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1a -= timer1.Interval * 0.001f;
            textBox1.Text = timer1a.ToString("00.00");
            if (timer1a < 0)
            {
                timer1.Enabled = false;
                textBox1.Text = "0.00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1a = float.Parse(textBox1.Text);
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
