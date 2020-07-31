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
    public partial class Facial : Form
    {
        public Facial()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            string serve = "";
            int bill = 0;
            if (checkBox1.Checked)
            {
                serve += " Cleasnser,";
                bill += 1500;
            }
            if (checkBox2.Checked)
            {
                serve += " Face Polish,";
                bill += 1000;
            } if (checkBox3.Checked)
            {
                serve += " Dermaclear Facial,";
                bill += 2700;
            } if (checkBox3.Checked)
            {
                serve += " Thalgo Facial,";
                bill += 3700;
            } if (checkBox3.Checked)
            {
                serve += " Jenssen Whitenning Facial,";
                bill += 3000;
            }
            string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string qry = "update Customer set Service='" + serve + "', bill = '" + bill + "' where ID=(select MAX(id) from customer)";
            SqlCommand cmdqry = new SqlCommand(qry, con);
            SqlDataAdapter sdaqry = new SqlDataAdapter(cmdqry);
            cmdqry.ExecuteNonQuery();
            con.Close();
            }

        private void Facial_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

       
    }
}
