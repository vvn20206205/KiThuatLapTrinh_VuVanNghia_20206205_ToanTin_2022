using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_2_1
{

    internal class MyLinkedListQueue
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
        Node heapNode, tailNode;
        public MyLinkedListQueue()
        {
            heapNode = tailNode = null;
        }
        public MyLinkedListQueue(string value)
        {
            heapNode.value = value; 
            heapNode.next = tailNode;
        }
        // Hàm thêm
        // MyQueue4.Enqueue("Free");
        public Boolean Enqueue(string value)
        {
            if (!isFull())
            {
                return false;
            }
            //Thêm một phần tử vào đầu của Linked List
            Node newNode = new Node(value);
            if (isEmpty())
            {
                heapNode = tailNode = newNode;
            }
            else
            {
                tailNode.next = newNode;
                tailNode = newNode;
            }
            return true;
        }
        // Hàm lấy
        // MyQueue4.Dequeue());
        public string Dequeue()
        {
            if (isEmpty())
            {
                return "";
            }
            string value;
            value = heapNode.value;
      
                heapNode = heapNode.next;
            return value;
        }
        public Boolean isFull()
        {
            return true;
        }
        public Boolean isEmpty()
        {
            return (heapNode == null && tailNode == null);
        }
        // Hàm tổng
        // MyQueue4.Count);
        public int Count()
        {
            int tong = 0; 

            if (isEmpty())
            {
                return 0;
            }
            else
            {
                Node tam = heapNode;
                while (tam.next != tailNode)
                {
                    tong++;
                    tam = tam.next;
                }
                return tong + 2;
            }
        }
    }
}