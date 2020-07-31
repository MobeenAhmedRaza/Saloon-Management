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
    public partial class Makeup : Form
    {
        public Makeup()
        {
            InitializeComponent();
        }

       

       
        private void button2_Click(object sender, EventArgs e)
        {
            string serve = "";
            int bill = 0;
            if (checkBox1.Checked)
            {
                serve += " Engagement/Nikkah Makeup,";
                bill += 10000;
            }
            if (checkBox2.Checked)
            {
                serve += " Party Makeup,";
                bill += 8000;
            }
             if (checkBox4.Checked)
            {
                serve += " Mehandi/Mayun Makeup,";
                bill += 8000;
            } if (checkBox3.Checked)
            {
                serve += " Bridal Makeup,";
                bill += 23530;
            }
             string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
             SqlConnection con = new SqlConnection(constr);
             con.Open();

             string qry = "update Customer set Service='" + serve + "', bill = '" + bill + "' where ID=(select MAX(id) from customer)";
             SqlCommand cmdqry = new SqlCommand(qry, con);
             //SqlDataAdapter sdaqry = new SqlDataAdapter(cmdqry);
             cmdqry.ExecuteNonQuery();
             con.Close();

        }

        
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Makeup_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }
    }
}
