using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* private int Count(int i)
        {
            int k = i + 1;
            return k;
        }
       */


        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string counter = i++.ToString();
            input1.ResetText();
            input1.AppendText(counter);
        }

        private void clicked(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {

            if (input1.TextLength == 0 || input2.TextLength == 0)
            {
                MessageBox.Show("input numbers, please");
            }

            int num1 = Convert.ToInt32(input1.Text);
            int num2 = Convert.ToInt32(input2.Text);
            int res = num1 + num2;

            result.Clear();
            result.AppendText(res.ToString());           
        }
    }
}
