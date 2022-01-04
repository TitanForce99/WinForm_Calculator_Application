using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Calculator_Application
{
    public partial class Form1 : Form
    {
        public double ikinciSayi = 0;
        public double ilkSayi = 0;
        public double sonuc = 0;
        List<double> ilksayilist = new List<double>();
        List<double> ikincisayilist = new List<double>();
       
      
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";   
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void bnt_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btn_carpi_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = ilkSayi + "*";
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = ilkSayi + "/";
        }

        private void btn_cıkarma_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = ilkSayi + "-";
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = ilkSayi + "+";
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (textBox1.ToString().Contains("+"))
            {
                string[] subs = textBox1.Text.Split('+');
                ilkSayi = Convert.ToDouble(subs[0]);
                ikinciSayi = Convert.ToDouble(subs[1]);
                sonuc = ilkSayi + ikinciSayi;
                textBox1.Text = sonuc.ToString();
            }
            if (textBox1.ToString().Contains("-"))
            {
                string[] subs = textBox1.Text.Split('-');
                ilkSayi = Convert.ToDouble(subs[0]);
                ikinciSayi = Convert.ToDouble(subs[1]);
                sonuc = ilkSayi - ikinciSayi;
                textBox1.Text = sonuc.ToString();
            }
            if (textBox1.ToString().Contains("*"))
            {
                string[] subs = textBox1.Text.Split('*');
                ilkSayi = Convert.ToDouble(subs[0]);
                ikinciSayi = Convert.ToDouble(subs[1]);
                sonuc = ilkSayi * ikinciSayi;
                textBox1.Text = sonuc.ToString();
            }
            if (textBox1.ToString().Contains("/"))
            {
                string[] subs = textBox1.Text.Split('/');
                ilkSayi = Convert.ToDouble(subs[0]);
                ikinciSayi = Convert.ToDouble(subs[1]);
                sonuc = ilkSayi / ikinciSayi;
                textBox1.Text = sonuc.ToString();
            }
        }
        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";   
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
