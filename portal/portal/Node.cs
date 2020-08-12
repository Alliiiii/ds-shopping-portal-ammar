using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal
{
    class Node
    {
        public int data;//koi data ayega //
        public string productname;//product name//
        public int price;
        public Node nextnode;
       

        public Node()
        {
            //yeh isliye takey agar parameters nhi den to yeh call hojaye//
        }
        public Node(int sn,string pn,int p)
        {
            data = sn;
            productname = pn;
            price = p;
        }
        public int getdata()
        {
            return data;
        }
        public int getprice()
        {
            return price;
        }

        public string getproductname()
        {
            return productname;
        }
        public void newnode(Node nextnewnode)
        {
            nextnode = nextnewnode;
        }
        public Node getnewnode()
        {
            return nextnode;
        }
    }
}
