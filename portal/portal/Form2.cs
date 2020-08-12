using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portal
{
    public partial class Form2 : Form
    {
        //int counter = 0;
     
        public Form2()
        {
            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(1000);
            InitializeComponent();
            t.Abort();
        }
        public void startForm()
        {
            Application.Run(new Form1());
        }
        public void startForm(int c)
        {
            Application.Run(new Form1());
            c++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
     
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox2.Text=="")
            {
                MessageBox.Show("please enter name or password");
            }
            else if (textBox1.Text != "admin" || textBox2.Text != "123")
            {
                MessageBox.Show("incoorect name or password");
            }
            else if(textBox1.Text=="admin"  && textBox2.Text=="123")
            {
                Form3 obj = new Form3();
                obj.Show();
                this.Hide();

            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form4 signup = new Form4();
            //signup.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
