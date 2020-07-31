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
    public partial class gender : Form
    {
        public gender()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_details m = new f_details();
            this.Visible = false;
            m.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            men m = new men();
            this.Visible = false;
            m.Visible = true;
        }
    }
}
