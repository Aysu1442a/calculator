using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kesr_eded_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double reqem1, reqem2, nisbet, hasil, toplama, ferq;
            reqem1 = double.Parse(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            nisbet = reqem1 / reqem2;
            label1.Text = "nisbet:  " + nisbet;
            toplama = reqem1 + reqem2;
            label2.Text = "cem:   " + toplama;
            ferq = reqem1 - reqem2;
            label3.Text = "ferq:  " + ferq;
            hasil = reqem1 * reqem2;
            label4.Text="hasil:  "+hasil;


        }
    }
}
