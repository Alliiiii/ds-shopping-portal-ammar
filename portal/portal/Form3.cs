using System;
using System.Windows.Forms;

namespace portal
{

    public partial class Form3 : Form
    {
        public int ali = 0;
        int c = 0;
        //Stack obj = new Stack();
       // static int n = 5;
        //string[] stacks = new string[n];
       // int top=-1;
        string[] ar = new string[3];
        //static int n = 3;
        LinkedList obj = new LinkedList();
        
        public Form3()
        {
            InitializeComponent();
           // button3.Enabled = false;
        }
        int count1, count2, count3= 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            // dataGridView1.Columns.Add("items", "items");
            //dataGridView1.Rows.Add();
            LinkedList dis = new LinkedList();
            dis.insert(1,"Computer",200);
            dis.insert(2, "Laptop", 300);
            dis.insert(3,"Mouse",400);
        
            string[] show = dis.printarray();

            string[] c = show[0].Split(' ');
            label1.Text = c[1];
            label2.Text = c[2];

            string[] d = show[1].Split(' ');
            label3.Text = d[1];
            label4.Text = d[2];

            string[] f = show[2].Split(' ');
            label5.Text = f[1];
            label6.Text = f[2];

        }
        public int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            //if (count1 < - 1)
            //    button2.Enabled = true;
            try
            {
                if (count3 > -1 || count1 > -1 || count2 > -1 || c>-1)
                {
                    count++;
                    dataGridView1.Rows.RemoveAt(0);
                    obj.removenode(c,count);
                   count3--;
                    count2--;
                    count1--;

                    //c--;
                    // dataGridView1.Hide();
                }
                //  dataGridView1.DataSource = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Stack underflow");


                }
                //if (count1 == -1)
                //{
                //    // button3.Enabled = false;
                //    MessageBox.Show("Stack Underflow");
                //}

                //    if (top < n-1)
                //    {
                //        top++;
                //        stacks[top] = textBox1.Text;
                //        //dataGridView1.Rows.Count
                //        dataGridView1.Rows.Add();
                //          dataGridView1.Rows[top].Cells[0].Value = stacks[top];//.ToString();

                //        if (top == n-1)
                //           // button2.Enabled = false;
                //        MessageBox.Show("Stack Overflow");
                //    }
                //    if (top > -1)
                //    {
                //        button3.Enabled = true;
                //    }
                //    textBox1.Text =null;
            }
        private void button3_Click(object sender, EventArgs e)
        {

            ////if (top < n - 1)
            //    //button2.Enabled = true;
            ////if (top == -1)
            ////{
            //    //// button3.Enabled = false;
            //    //MessageBox.Show("Stack Underflow");
            ////}
            ////if (top > -1)
            ////{
            //    //dataGridView1.Rows.RemoveAt(top);
            //    //top--;
            ////}
            //Items.DataSource = obj.printarray();
            //try
            //{
            //    if (ali==3)
            //    {
                   
            //    }
           
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("list not show overflow");


            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ali++;
            count1 += 1;
            c++;
            if (count1 > 1)
            {
                obj.search(1, Convert.ToInt32(label7.Text));
            }
            else
            {
                obj.insert(1, label1.Text, Convert.ToInt32(label7.Text));
            }

            textBox1.Clear();
            count1 += 1;
            dataGridView1.DataSource = obj.print(c);
            //textBox4.Text = count3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ali++;
            count2 += 1;
            c++;
            if (count2 > 1)
            {
                obj.search(2, Convert.ToInt32(label8.Text));
            }
            else
            {
                obj.insert(2, label3.Text, Convert.ToInt32(label8.Text));
            }
            textBox2.Clear();
            dataGridView1.DataSource = obj.print(c);
            //textBox4.Text = count3.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {
                    //textBox1.Text = "";
                    label7.Text = "0";
                }
                else
                {
                    int value = Convert.ToInt32(textBox1.Text);
                    int a = Convert.ToInt32(label2.Text);
                    label7.Text = (value * a).ToString();

                }
            }

            catch (Exception)
            {

                MessageBox.Show("please enter only numbers");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    //textBox1.Text = "";
                    label8.Text = "0";
                }
                else
                {
                    int value = Convert.ToInt32(textBox2.Text);
                    int a = Convert.ToInt32(label4.Text);
                    label8.Text = (value * a).ToString();

                }
            }
            catch
            {
                MessageBox.Show("please enter only numbers");
                
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ali++;
            count3 += 1;
            c++;
            if (count3 > 1)
            {
                obj.search(3, Convert.ToInt32(label9.Text));
            }
            else
            {
                obj.insert(3, label5.Text, Convert.ToInt32(label9.Text));
            }
            textBox3.Clear();
           dataGridView1.DataSource = obj.print(c);
          //  textBox4.Text = count3.ToString();
    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "")
                {
                    //textBox1.Text = "";
                    label9.Text = "0";
                }
                else
                {
                    int value = Convert.ToInt32(textBox3.Text);
                    int a = Convert.ToInt32(label6.Text);
                    label9.Text = (value * a).ToString();

                }
            }
            catch
            {
                MessageBox.Show("please enter only numbers");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = obj.print();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.DataSource = obj.print();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = obj.print(c);
        }

        private void button8_Click(object sender, EventArgs e)
        {
        //    count4 += 1;
        //    c++;
        //    if (count4 > 1)
        //    {
        //        obj.search(3, Convert.ToInt32(label9.Text));
        //    }
        //    else
        //    {
        //        obj.insert(4, label13.Text, Convert.ToInt32(label9.Text));
        //    }
        //    textBox5.Clear();
        //    dataGridView1.DataSource = obj.print(c);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[0].Cells[1].Value.ToString());
            
            //if (top == -1)
            //{
            //    MessageBox.Show("stack under flow");
            //}
            //else
            //{
            //    MessageBox.Show(stacks[top]);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
