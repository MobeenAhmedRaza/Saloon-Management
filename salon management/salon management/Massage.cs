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
    public partial class Massage : Form
    {
        string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
        SqlConnection con = null;
        public Massage()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            string serve = "";
            int bill = 0;
            if (checkBox1.Checked)
            {
                serve += " Full Massage(60m)";
                bill += 2250;
            }
            if (checkBox2.Checked)
            {
                serve += " Full Massage(90m)";
                bill += 3300;
            } if (checkBox3.Checked)
            {
                serve += " Hot Oiling";
                bill += 1000;
            } if (checkBox4.Checked)
            {
                serve += " Scrub + Massage";
                bill += 3100;
            }
            con = new SqlConnection(constr);
            con.Open();

           // MessageBox.Show("Booked");
            try
            {
                string qry = "update Customer set Service='" + serve + "', bill = '" + bill.ToString() + "' where ID=(select MAX(id) from customer)";
                SqlCommand cmdqry = new SqlCommand(qry, con);
                cmdqry.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

       

        private void Massage_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }
    }
}
