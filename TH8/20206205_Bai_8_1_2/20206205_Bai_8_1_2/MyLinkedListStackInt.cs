using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20206205_Bai_8_1_2
{
    internal class MyLinkedListStackInt
    {

        private class Node
        {
            internal int value;
            internal Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        Node topNode;
        public MyLinkedListStackInt()
        {
            topNode = null;
        }
        public Boolean Push(int value)
        {
            if (!isFull())
            {
                //Thêm một phần tử vào đầu của Linked List
                Node newNode = new Node(value);
                newNode.next = topNode;
                topNode = newNode;
                return true;
            }
            return false;
        }
        public int Pop()
        {
            if (!isEmpty())
            {
               // MessageBox.Show("Lỗi Satck Empty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int value = topNode.value;
            topNode = topNode.next;
            return value;
        }

        public Boolean isFull()
        {
            return false;
        }
        public Boolean isEmpty()
        {
            return topNode == null;
        }
        public int Count()
        {
            int tong = 0;
            if (isEmpty())
            {
                return 0;
            }
            else
            {
                Node tam = topNode;
                while (tam.next != null)
                {

                    tong++;
                    tam = tam.next;
                }
                return tong + 1;
            }
        }
    }
}