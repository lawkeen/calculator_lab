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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float c;
        int count;

        private void button14_Click(object sender, EventArgs e) //0
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 0;
        }

        private void button9_Click(object sender, EventArgs e) //1
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e) //2
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 2;
        }

        private void button11_Click(object sender, EventArgs e) //3
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e) //4
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e) //5
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e) //6
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e) //7
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e) //8
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e) //9
        {
            if (textBox1.Text != "0" && textBox1.Text.Length < 7)
                textBox1.Text = textBox1.Text + 9;
        }

        bool i = false;
        private void button4_Click(object sender, EventArgs e) //+
        {
            try
            {
                if (textBox1.Text != "")
                {
                    calculate();
                    count = 1;
                    if (!i)
                    {
                        c = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        t = false;
                        label1.Text = c.ToString();
                    }
                    else
                    {
                        textBox1.Text = "";
                        t = false;
                    }
                    i = true;
                }
            }
            catch (FormatException)
            {
                textBox1.Clear();
                label1.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e) //-
        {
            try
            {
                if (textBox1.Text != "")
                {
                    calculate();
                    count = 2;
                    if (!i)
                    {
                        c = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        t = false;
                        label1.Text = c.ToString();
                    }
                    else
                    {
                        textBox1.Text = "";
                        t = false;
                    }
                    i = true;
                }
            }
            catch (FormatException)
            {
                textBox1.Clear();
                label1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e) //*
        {
            try
            {
                if (textBox1.Text != "")
                {
                    calculate();
                    count = 3;
                    if (!i)
                    {
                        c = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        t = false;
                        label1.Text = c.ToString();
                    }
                    else
                    {
                        textBox1.Text = "";
                        t = false;
                    }
                    i = true;
                }
            }
            catch (FormatException)
            {
                textBox1.Clear();
                label1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e) // /
        {
            try
            {
                if (textBox1.Text != "")
                {
                    calculate();
                    count = 4;
                    if (!i)
                    {
                        c = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        t = false;
                        label1.Text = c.ToString();
                    }
                    else
                    {
                        textBox1.Text = "";
                        t = false;
                    }
                    i = true;
                }
            }
            catch (FormatException)
            {
                textBox1.Clear();
                label1.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e) //CE
        {
            textBox1.Text = "";
            t = false;
            label1.Text = "";
            c = 0;
            i = false;
        }

        bool t = false;
        private void button15_Click(object sender, EventArgs e) //.
        {
            if (textBox1.Text != "" && !t)
            {
                textBox1.Text = textBox1.Text + ",";
                t = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e) // =
        {
            if (textBox1.Text != "")
            {
                calculate();
                textBox1.Text = label1.Text;
                label1.Text = "";
                i = false;
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    c = c + float.Parse(textBox1.Text);
                    label1.Text = c.ToString();
                    break;
                case 2:
                    c = c - float.Parse(textBox1.Text);
                    label1.Text = c.ToString();
                    break;
                case 3:
                    c = c * float.Parse(textBox1.Text);
                    label1.Text = c.ToString();
                    break;
                case 4:
                    try
                    {
                        if (float.Parse(textBox1.Text) != 0)
                        {
                            c = c / float.Parse(textBox1.Text);
                            label1.Text = c.ToString();
                        }
                        else
                        {
                            label1.Text = "Не дели на 0";
                        }
                    }
                    catch(FormatException)
                    {
                        textBox1.Clear();
                        label1.Text = "";
                    }
                    break;

                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
