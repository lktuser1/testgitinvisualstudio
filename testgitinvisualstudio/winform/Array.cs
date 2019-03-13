using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace winform
{
    public partial class Array : Form
    {
        string[] str = new string[10];
        int[] i;
        ArrayList objArray = new ArrayList();
        public Array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i < str.Length;i++)
            {
                if (str[i] == null)
                {
                    str[i] = textBox1.Text;
                    break;

                }
            }
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objArray.Add(textBox1.Text);
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = objArray;
        }

    }
}
