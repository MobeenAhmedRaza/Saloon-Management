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
    public partial class Nails : Form
    {
        public Nails()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string serve = "";
            int bill = 0;
            if (checkBox1.Checked)
            {
                serve += " Classic Manicure,";
                bill += 1050;
            }
            if (checkBox1.Checked)
            {
                serve += " Classic pedicure,";
                bill += 1150;
            } if (checkBox1.Checked)
            {
                serve += " Organic Manicure,";
                bill += 1150;
            } if (checkBox1.Checked)
            {
                serve += " Organic Pedicure,";
                bill += 1250;
            } if (checkBox1.Checked)
            {
                serve += " Classic Mani+Pedi,";
                bill += 2000;
            } if (checkBox1.Checked)
            {
                serve += " Organic Mani+Pedi,";
                bill += 2250;
            }
            string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string qry = "update Customer set Service='" + serve + "', bill = '" + bill + "' where ID=(select MAX(id) from customer)";
            SqlCommand cmdqry = new SqlCommand(qry, con);
            SqlDataAdapter sdaqry = new SqlDataAdapter(cmdqry);
            cmdqry.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("booked");
            
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

       
        private void Nails_Load(object sender, EventArgs e)
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
