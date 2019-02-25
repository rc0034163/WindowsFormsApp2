using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
//            Double pi = 3.141592653589793;
            Double c = 299792458;
//          richTextBox1.AppendText(pi.ToString("N3")+"\n");
//          richTextBox1.AppendText(pi.ToString("0.00000") + "\n");
//          richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(c.ToString() + "\n");
            richTextBox1.AppendText(c.ToString("n0") + "\n");
            richTextBox1.AppendText(c.ToString("0.000000000000000") + "\n");
            richTextBox1.AppendText(c.ToString("0.00E00") + "\n");
            string s = "3";
            string pi = "3.14159265";
            int i = int.Parse(s);
            double d = double.Parse(pi);

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st = " is not an integer");
            }
                   
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
