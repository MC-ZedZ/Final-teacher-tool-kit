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
        int[] classList = new int[10];
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
            for (int i = 0; i < 10; i++)
            {
                classList[i] = i;
                textBox1.AppendText(classList[i].ToString() + "\r\n");
            }

            //shuffle list
            for (int i = 0; i < 10; i++)
            {
                int rnum = rnd.Next(0, 10);
                int temp = classList[i];
                classList[i] = classList[rnum];
                classList[rnum] = temp;
            }
            //output
            for (int i = 0; i < 10; i++)
            {
                textBox1.AppendText(classList[i].ToString() + "\r\n");
            }
        }
    }
}
