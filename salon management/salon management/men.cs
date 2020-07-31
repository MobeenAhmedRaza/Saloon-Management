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
    public partial class men : Form
    {
        public men()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string constr = "Data Source=(local);Initial Catalog=salon;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            try
            {
            string serve = "";
            int bill = 0;

            //Cutting checks
            if (radioButton1.Checked)
            {
                serve += "Standard Hair Cutting, ";
                bill += 150;
            }
            if (radioButton2.Checked)
            {
                serve += "Gold Hair Cutting, ";
                bill += 250;
            }
            if (radioButton3.Checked)
            {
                serve += "Premium Hair Cutting, ";
                bill += 350;
            }

            //Facial checks
            if (radioButton6.Checked)
            {
                serve += "Standard Facial, ";
                bill += 500;
            }
            if (radioButton5.Checked)
            {
                serve += "Gold Facial, ";
                bill += 1000;
            }
            if (radioButton4.Checked)
            {
                serve += "Premium Facial, ";
                bill += 1500;
            }

            //Shave checks
            if (radioButton9.Checked)
            {
                serve += "Standard Shave, ";
                bill += 100;
            }
            if (radioButton8.Checked)
            {
                serve += "Gold Shave, ";
                bill += 200;
            }
            if (radioButton7.Checked)
            {
                serve += "Premium Shave, ";
                bill += 300;
            }
            
            //Massage
            if (radioButton12.Checked)
            {
                serve += "Massage, ";
                bill += 100;
            }


            //Hair Color checks
            if (radioButton15.Checked)
            {
                serve += "Standard Hair Colour, ";
                bill += 300;
            }
            if (radioButton14.Checked)
            {
                serve += "Gold Hair Colour, ";
                bill += 750;
            }
            if (radioButton13.Checked)
            {
                serve += "Premium Hair Colour, ";
                bill += 1000;
            }

            //SPA checks
            if (radioButton18.Checked)
            {
                serve += "Standard SPA, ";
                bill += 150;
            }
            if (radioButton17.Checked)
            {
                serve += "Gold SPA, ";
                bill += 250;
            }
            if (radioButton16.Checked)
            {
                serve += "Premium SPA, ";
                bill += 350;
            }


            string q = "insert into customer values('" + txtid.Text + "','" + txtname.Text + "','" + txtcontact.Text + "','" + serve + "','" + bill + "')";
            SqlCommand com = new SqlCommand(q,con);
            com.ExecuteNonQuery();
            con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            summary s = new summary();
            this.Visible = false;
            s.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gender g = new gender();
            this.Visible = false;
            g.Visible = true;
        }
    }
}
