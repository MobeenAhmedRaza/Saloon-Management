using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace salon_management
{
    public partial class Hair : Form
    {
        public Hair()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string serve = "";
            int bill = 0;
            if (checkBox1.Checked)
            {
                serve += " Hair Blow Dry,";
                bill += 1200;
            }
            if (checkBox3.Checked)
            {
                serve += " Hot Oil Massage (15m),";
                bill += 1000;
            } if (checkBox3.Checked)
            {
                serve += " Hot Oil Massage (30m),";
                bill += 1350;
            } if (checkBox3.Checked)
            {
                serve += " Hair Dye,";
                bill += 1200;
            }
            string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string qry = "update Customer set Service+='" + serve + "', bill = '" + bill + "' where ID=(select MAX(id) from customer)";
            SqlCommand cmdqry = new SqlCommand(qry, con);
            SqlDataAdapter sdaqry = new SqlDataAdapter(cmdqry);
            cmdqry.ExecuteNonQuery();
            con.Close();

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void Hair_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }
    }
}
