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
    public partial class mdiform : Form
    {
        public mdiform()
        {
            InitializeComponent();
        }
        Facial f = new Facial();
        private void facialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            f.MdiParent = this;
            f.Show();
        }

        
        public string serve = "";
        public int bill = 0;
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
           
            string qry = "update Customer set Service='" + serve + "', bill = '" + bill + "' where ID=(select MAX(id) from customer)";
            //UPDATE SERVICES FEMALES
            SqlCommand cmdqry = new SqlCommand(qry, con);
            SqlDataAdapter sdaqry = new SqlDataAdapter(cmdqry);


            string qry2 = "update Customer set bill='" + bill + "' where ID=(select MAX(id) from customer)";
            //UPDATE BILL FEMALES
            SqlCommand cmdqry2 = new SqlCommand(qry2, con);
            SqlDataAdapter sdaqry2 = new SqlDataAdapter(cmdqry2);

            this.Hide();
            summary s = new summary();
            s.Show();
        }
        Massage msobj;
        private void massageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (msobj == null)
            {
                msobj = new Massage();
                msobj.MdiParent = this;
                msobj.FormClosed += obj_FormClosed;
                msobj.Show();


            }
            else
                msobj.Activate();
           

        }

        private void obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            msobj = null;
        }
        Nails nobj=null;
        private void nailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nobj==null)
            {
                nobj = new Nails();
                nobj.MdiParent = this;
                nobj.FormClosed += nobj_FormClosed;
                nobj.Show();
                
            }
            else
            {
                nobj.Activate();
            }
        }

        void nobj_FormClosed(object sender, FormClosedEventArgs e)
        {
            nobj = null;
        }
        Makeup mkobj=null;
        private void maekUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mkobj==null)
            {
                mkobj = new Makeup();
                mkobj.MdiParent = this;
                mkobj.FormClosed += mkobj_FormClosed;
                mkobj.Show();
                
            }
            else
            {
                mkobj.Activate();
            }
        }

        void mkobj_FormClosed(object sender, FormClosedEventArgs e)
        {
            mkobj = null;
        }

        private void hairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hair m = new Hair();
            m.MdiParent = this;
            m.Show();
        }

        private void mdiform_Load(object sender, EventArgs e)
        {

        }
    }
}
