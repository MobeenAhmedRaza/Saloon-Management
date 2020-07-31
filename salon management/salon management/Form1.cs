using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salon_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==textBox2.Text)
            {

                gender obj = new gender();
                this.Visible = false;
                obj.Visible = true;    
            }
            else
            {
                MessageBox.Show("Invalid Id/Password");
            }
        }
    }
}
