using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20206205_Bai_8_1_1
{
    public partial class Form1 : Form
    {
        MyLinkedListStack MyStack1 = new MyLinkedListStack();
        MyLinkedListStack MyStack2 = new MyLinkedListStack();
        public Form1()
        {
            InitializeComponent();
            MyStack1.Push("");
            MyStack2.Push("");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
           
            string VanBan = richTextBox1.Text;
            if (VanBan != "" && VanBan != Convert.ToString(MyStack1.Peek()))
            {
                MyStack1.Push(VanBan);
            }
            if (MyStack1.Count() == 1)
            {
                btnUndo.Enabled = false;
            }
            else
            {
                MyStack2.Push(MyStack1.Pop());
                richTextBox1.Text = null;
                richTextBox1.Text = Convert.ToString(MyStack1.Peek());
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (MyStack2.Count() == 1)
            {
                btnRedo.Enabled = false;
            }
            else
            {
                MyStack1.Push(MyStack2.Peek());
                richTextBox1.Text = null;
                richTextBox1.Text = Convert.ToString(MyStack2.Pop());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string VanBan = richTextBox1.Text;
            if (VanBan != "" ||VanBan != Convert.ToString(MyStack1.Peek()) || VanBan != Convert.ToString(MyStack2.Peek()))
            {
                btnRedo.Enabled = true;
                btnUndo.Enabled = true;
            }
        }
    }
}
