using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace salon_management

{
    public partial class f_details : Form
    {
        public f_details()
        {
            InitializeComponent();
        }

        private void massageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Massage m = new Massage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mdiform m = new mdiform();
            string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            
           
            con.Open();
            //int cid = int.Parse(ci);
            string q = "insert into customer values('" + txtid.Text + "','" + txtname.Text + "','" + txtcontact.Text + "','" + m.serve + "','" + m.bill + "')";
            SqlCommand com = new SqlCommand(q, con);
            com.ExecuteNonQuery();
            
            con.Close();


            
            this.Visible = false;
            m.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gender g = new gender();
            this.Visible = false;
            g.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void facialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facial f = new Facial();
            f.MdiParent = this;
            f.Show();
          
        }

        private void f_details_Load(object sender, EventArgs e)
        {

        }
    }
}
