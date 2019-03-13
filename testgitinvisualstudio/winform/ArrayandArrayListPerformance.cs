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
using System.Diagnostics;

namespace winform
{
    public partial class ArrayandArrayListPerformance : Form
    {
        int[] intarray = new int[10];
        ArrayList objArrayList = new ArrayList();
        int i;

        Stopwatch stopWatch = new Stopwatch();
        public ArrayandArrayListPerformance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            for (i = 0; i < 10; i++)
                intarray[i] = DateTime.Now.Second;


            foreach(int i in intarray)
             {
                
                    
            }
            stopWatch.Stop();
            label1.Text = stopWatch.ElapsedTicks.ToString();

            stopWatch.Start();
            for (i = 0; i < 10; i++)
                objArrayList.Add(DateTime.Now.Second);


            foreach (int i in objArrayList)
            {


            }
            stopWatch.Stop();
            label2.Text = stopWatch.ElapsedTicks.ToString();

        }
    }
}
