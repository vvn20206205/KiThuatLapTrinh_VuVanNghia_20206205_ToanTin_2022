using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_1_2
{
    internal class MyLinkedListStackChar
    {

        private class Node
        {
            internal char value;
            internal Node next;
            public Node(char value)
            {
                this.value = value;
            }
        }
        Node topNode;
        public MyLinkedListStackChar()
        {
            topNode = null;
        }
        public Boolean Push(char value)
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
        public char Pop()
        {
            if (!isEmpty())
            {
                //Thêm một phần tử vào đầu của Linked List
                //thông báo.
            }
            char value = topNode.value;
            topNode = topNode.next;
            return value;
        }
        public char Peek()
        {
            if (!isEmpty())
            {
                //Thêm một phần tử vào đầu của Linked List
                //thông báo.
            }
            char value = topNode.value;
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