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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;




        private void timerTB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void timerTB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void timerTB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);

            }
            else
            {
                MessageBox.Show("Please add students!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox1.AppendText(textBox2.Text);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}

