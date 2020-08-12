using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 login = new Form2();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || textBox4.Text=="" || textBox5.Text=="")
            {
               

            }
            //Console.WriteLine("Successful");
            string FirstName = textBox1.Text;
            string Lastname = textBox2.Text;
            string Email = textBox3.Text;
            string pass = textBox4.Text;
            MessageBox.Show("please fill all boxses");
            MessageBox.Show(FirstName + "\n" + Lastname + "\n" + Email + "\n"  + "\n" + pass);
                       
            //Form2 login = new Form2();
            //login.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox5.Text)
            {
                button1.Enabled = true;
               // button1.Text = "Submit";
                //label11.Text = "Matched";
            }
            else
            {
                //label11.Text = "Password did'nt match,try again";
                button1.Enabled = false;
            }
        }
    }
}
