using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YILDIZ_YAZDIRMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int satir = Convert.ToInt32(textBox1.Text);
            int sutun = Convert.ToInt32(textBox2.Text);
            string y = "";
            for (int i =0 ; i < satir; i++)
            {              
                for (int j = 0; j < sutun; j++)
                {
                      y = y + "" + "*"+"  ";
                }
                listBox1.Items.Add(y);
                y = "";
            }
        }
    }
}
