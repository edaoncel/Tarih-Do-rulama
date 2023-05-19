using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarih_dogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 1;
            for(int i=1920; i<= 2008; i++)
            {
                comboBox3.Items.Add(i);
                if(counter<13)
                {
                    comboBox2.Items.Add(counter);
                }
                if(counter<32)
                {
                    comboBox1.Items.Add(counter);
                }
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(comboBox1.Text + "." + comboBox2.Text + "." + comboBox3.Text);
                MessageBox.Show("gecerli tarih sectin.");
            }
            catch(Exception)
            {
                MessageBox.Show("gecerli tarih girin.");
            }
        }
    }
}
