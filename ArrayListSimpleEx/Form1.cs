using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        String msg = "";
        String insertString = "";
        ArrayList wordlist = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            for (int i = 0; i < wordlist.Count; i++)
            {
                lblMessage.Text = lblMessage.Text + " " + wordlist[i].ToString();
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            for (int i = wordlist.Count - 1; i > -1; i--)
            {
                lblMessage.Text = lblMessage.Text + " " + wordlist[i].ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertString = txtSecondPos.Text;
            wordlist.Insert(1, insertString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg = "I love programming so much";
            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                wordlist.Add(word);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordlist.RemoveAt(1);
        }
    }
}
