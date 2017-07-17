using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(button2.Text);
            button2.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(button3.Text);
            button3.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(button7.Text);
            button7.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(button4.Text);
            button4.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(button5.Text);
            button5.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(button6.Text);
            button6.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("KadıKöy");
            comboBox1.Items.Add("Beşiktaş");

            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("13:00");


        }
    }
}
