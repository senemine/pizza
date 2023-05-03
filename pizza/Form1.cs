using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {           
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplamtutar = 0;
            //buyutu hesaba eklme
            if (checkBox1.Checked == true) toplamtutar = toplamtutar + 15;
            else if (checkBox2.Checked == true) toplamtutar = toplamtutar + 25;
            else toplamtutar = toplamtutar + 35;

            //hamur ekleme
            if (checkBox9.Checked == true) toplamtutar = toplamtutar + 2;
            else if (checkBox11.Checked == true) toplamtutar = toplamtutar + 3;

            //malzeme
            if (checkBox4.Checked == true) toplamtutar += 1;
            if (checkBox5.Checked == true) toplamtutar += 1.5;
            if (checkBox6.Checked == true) toplamtutar += 0.5;
            if (checkBox7.Checked == true) toplamtutar += 1;
            if (checkBox8.Checked == true) toplamtutar += 0.75;

            int adet = Convert.ToInt32(numericUpDown1.Value);

            if (checkBox12.Checked == true) toplamtutar *= 0.75;
            if (checkBox13.Checked == true) toplamtutar = toplamtutar * 2 / 3;

            
            toplamtutar *= adet;
            label2.Text = toplamtutar.ToString();



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Enabled = true;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox2.Enabled = true;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox2.Enabled = true;
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) 
            {
                groupBox3.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                groupBox3.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                groupBox3.Enabled = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                groupBox3.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                groupBox3.Enabled = true;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox9.Checked== true)
            {
                groupBox4.Enabled = true;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                groupBox4.Enabled = true;
                checkBox9.Enabled = false;
                checkBox11.Enabled = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                groupBox4.Enabled = true;
                checkBox10.Enabled = false;
                checkBox9.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            numericUpDown1.Value = 0;
            label2.Text = " ";

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
