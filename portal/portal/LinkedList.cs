using System;
using System.Data;
using System.Linq;

namespace portal
{
    class LinkedList
    {
        Node head, tail, current;
   
        public LinkedList()
        {
            head = null;
            tail = null;
          
        }
        public void insert(int d, string pn, int p)
        {
            Node obj = new Node(d, pn, p);

            if (tail == null)
            {
                tail = obj;
            }

            obj.newnode(head);
            head = obj;

            //if (head == null)
            //{
            //    Node obj = new Node(d, pn, p);
            //    head = obj;
            //    tail = obj
            //}
            //{
            //    Node obj = new Node(d, pn, p);
            //    tail.nextnode = obj;
            //    tail = obj;
            //}

        }
        public int count = 0;
        public void removenode(int c, int count)
        {
           
            Node current = head;
            //Node pre = head;
            if (count==4)
            {
                head = null;

            }

        //   Node pre = head;
        //    Node curr;
        // Node pre=null;
        //    curr = head;
        //    for (curr = head; curr.nextnode != null; curr = curr.nextnode)
        //    {
        //        pre = curr;
        //    }
        //    pre.nextnode = curr;
        //    //pre = pre.nextnode;
        }
        public void search(int idkey, int cprice)
        {
            current = head;

            while (current != null)
            {
                int check = current.getdata();
                if (check == idkey)
                {
                    current.price += cprice;
                }
                current = current.getnewnode();
            }

        }
    public DataTable print(int c)
        {
            current = head;
            int count = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Serial Number", typeof(string));
            dt.Columns.Add("Productname", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            
            while (current != null)
            {
                for (int j = 0; j < 1; j++)
                {
                    count += current.getprice();
                    dt.Rows.Add(Convert.ToString(current.getdata()), current.getproductname(), Convert.ToString(current.getprice()));
                }
                current = current.getnewnode();
                
            }
            dt.Rows.Add(Convert.ToString("-"), Convert.ToString("-"), Convert.ToString("-"), Convert.ToString(count));
            return dt;
        }
        public string[] printarray()
        {
            current = head;
            string[] arr = new string[3];
            int count = 0;
            DataTable dt = new DataTable();
            //  dt.Columns.Add("SerialNumber", typeof(string));
            dt.Columns.Add("Serial Number", typeof(string));
            dt.Columns.Add("Productname", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Total", typeof(string));

            while (current != null)
            {

                for (int j = 0; j < 1; j++)
                {
                arr[count] = Convert.ToString(current.getdata()) + " " + current.getproductname() + " " + Convert.ToString(current.getprice());

                }
                count++;
                current = current.getnewnode();
            }
            dt.Rows.Add(Convert.ToString("-"), Convert.ToString("-"), Convert.ToString("-"), Convert.ToString(count));

            return arr.ToArray();
        }
    }
}
