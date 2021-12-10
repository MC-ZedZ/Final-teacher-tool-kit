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
    public partial class Form6 : Form
    {
        int[] classList = new int[0];
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //initialise
            for (int i = 0; i < 0; i++)
            {
                classList[i] = i;
                listBox1.Items.Add(classList[i].ToString() + "\r\n");
            }

            //shuffle list
            for (int i = 0; i < 0; i++)
            {
                int rnum = rnd.Next(0, 0);
                int temp = classList[i];
                classList[i] = classList[rnum];
                classList[rnum] = temp;
            }
            //output
            for (int i = 0; i < 0; i++)
            {
                listBox1.Items.Add(classList[i].ToString() + "\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i =0;i<listBox1.Items.Count;i++)
            {
                string temp = listBox1.Items[i].ToString();
                int rnum = rnd.Next(0, listBox1.Items.Count);
                listBox1.Items[i] = listBox1.Items[rnum];
                listBox1.Items[rnum] = temp;
            }
        }
    }
}
