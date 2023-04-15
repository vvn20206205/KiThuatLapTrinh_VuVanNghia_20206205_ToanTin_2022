using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace _20206205_Bai_8_1_1
{
    internal class MyLinkedListStack
    {

        private class Node
        {
            internal string value;
            internal Node next;
            public Node(string value)
            {
                this.value = value;
            }
        }
        Node topNode;
        public MyLinkedListStack()
        {
            topNode = null;
        }
        public Boolean Push(string value)
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
        public string Pop()
        {
            if (!isEmpty())
            {
                   //            MessageBox.Show("Lỗi Satck Empty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string value = topNode.value;
            topNode = topNode.next;
            return value;
        }
        public string Peek()
        {
            if (!isEmpty())
            {
                //Thêm một phần tử vào đầu của Linked List
                //thông báo.
            }
            string value = topNode.value;
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