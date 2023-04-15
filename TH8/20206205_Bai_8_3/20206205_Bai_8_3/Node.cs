using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_3
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
        }
        public void Them(int value)
        {
            if (value >= data)
            {
                if (right == null)
                    right = new Node(value);
                else
                    right.Them(value);
            }
            else
            {
                if (left == null)
                    left = new Node(value);
                else
                    left.Them(value);
            }
        }
        private bool choPhepXoa;
        public bool ChoPhepXoa
        {
            get { return choPhepXoa; }
        }
        public Node Tim(int value)
        {
            Node newNode = this;
            while (newNode != null)
            {
                if (value == newNode.data && choPhepXoa == false)
                {
                    return newNode;
                }
                else if (value > newNode.data)
                {
                    newNode = newNode.right;
                }
                else
                {
                    newNode = newNode.left;
                }
            }
            return null;
        }  
      
    }
}