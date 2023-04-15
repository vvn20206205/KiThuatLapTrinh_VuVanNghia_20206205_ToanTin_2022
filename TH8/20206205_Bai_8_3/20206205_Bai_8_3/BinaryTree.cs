using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_3
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }
        // Hàm thêm một phần tử
        public void Them(int value)
        {
            if (root == null)
                root = new Node(value);
            else
                root.Them(value);
        }
        // Hàm xóa một phần tử
        public void Xoa(int data)
        {
            Node NodeTam = root;
            Node NodeCha = root;
            bool KiemTraConTrai = false;
            if (NodeTam == null)
            {
                return;
            }
            while (NodeTam != null && NodeTam.data != data)
            {
                NodeCha = NodeTam;
                if (data < NodeTam.data)
                {
                    NodeTam = NodeTam.left;
                    KiemTraConTrai = true;
                }
                else
                {
                    NodeTam = NodeTam.right;
                    KiemTraConTrai = false;
                }
            }
            if (NodeTam == null)
            {
                return;
            }
            if (NodeTam.right == null && NodeTam.left == null)
            {
                if (NodeTam == root)
                {
                    root = null;
                }
                else
                {
                    if (KiemTraConTrai)
                    {
                        NodeCha.left = null;
                    }
                    else
                    {
                        NodeCha.right = null;
                    }
                }
            }
            else if (NodeTam.right == null)
            {
                if (NodeTam == root)
                {
                    root = NodeTam.left;
                }
                else
                {
                    if (KiemTraConTrai)
                    {

                        NodeCha.left = NodeTam.left;
                    }
                    else
                    {
                        NodeCha.right = NodeTam.left;
                    }
                }
            }
            else if (NodeTam.left == null)
            {
                if (NodeTam == root)
                {
                    root = NodeTam.right;
                }
                else
                {
                    if (KiemTraConTrai)
                    {
                        NodeCha.left = NodeTam.right;
                    }
                    else
                    {
                        NodeCha.right = NodeTam.right;
                    }
                }
            }
            else
            {
                Node NodeCon = TimNodeCon(NodeTam);

                if (NodeTam == root)
                {
                    root = NodeCon;
                }
                else if (KiemTraConTrai)
                {
                    NodeCha.left = NodeCon;
                }
                else
                {
                    NodeCha.right = NodeCon;
                }

            }

        }

        private Node TimNodeCon(Node node)
        {
            Node ChaCon = node;
            Node NodeCon = node;
            Node NodeTam = node.right;


            while (NodeTam != null)
            {
                ChaCon = NodeCon;
                NodeCon = NodeTam;
                NodeTam = NodeTam.left;
            }

            if (NodeCon != node.right)
            {

                ChaCon.left = NodeCon.right;

                NodeCon.right = node.right;
            }

            NodeCon.left = node.left;

            return NodeCon;
        }
        // Hàm tìm một phần tử
        public Node Tim(int data)
        {

            if (root != null)
            {

                return root.Tim(data);
            }
            else
            {
                return null;
            }
        }
        // Hàm đếm số phần tử của cây
        public int TongSoPhanTuCuaCay()
        {
            return TongSoPhanTu(root);

        }
        // Hàm đếm số phần tử 
        public int TongSoPhanTu(Node a)
        {

            if (a != null)
            {
                return 1 + TongSoPhanTu(a.left) + TongSoPhanTu(a.right);
            }
            else
            {
                return 0;
            }
        }
    }
}
