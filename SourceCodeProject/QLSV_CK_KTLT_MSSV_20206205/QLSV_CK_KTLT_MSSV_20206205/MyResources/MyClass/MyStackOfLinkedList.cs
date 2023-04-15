//Vũ Văn Nghĩa_20206205
using System;
using System.Runtime.Serialization;
// Cài đặt Stack bằng Linked List
// (kĩ thuật con trỏ)
public class MyLinkedListStack
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
    // Phần tử trên cùng của Stack
    Node topNode;
    // Hàm khởi tạo 
    public MyLinkedListStack()
    {
        topNode = null;
    }
    // Hàm thêm phần tử vào Stack
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
    // Hàm lấy ra phần tử của Stack
    public char Pop()
    {
        if (isEmpty())
        {
            // Xảy ra lỗi đã có xử lí ngoại lệ bên hàm sử dụng
            // MessageBox.Show("Lỗi Satck Empty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new EmptyStackException();
        }
        char value = topNode.value;
        topNode = topNode.next;
        return value;
    }
    // Hàm kiểm tra Stack có bị đầy không
    public Boolean isFull()
    {
        return false;
    }
    // Hàm kiểm tra Stack có rỗng không
    public Boolean isEmpty()
    {
        return topNode == null;
    }
    [Serializable]
    private class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
        }
        public EmptyStackException(string message) : base(message)
        {
        }
        public EmptyStackException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected EmptyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
