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
    public partial class summary : Form
    {
        public summary()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        mdiform n = new mdiform();
        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=salon_management;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string q = "delete from customer where id=(select MAX(id) from customer)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            //dataGridView1.Rows.Clear();
            MessageBox.Show("Data Deleted Successfully");

            gender m = new gender();
            this.Visible = false;
            m.Visible = true;
            
            n.bill = 0;
            n.serve = "";
        }
        DataSet ds = new DataSet();
        private void summary_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=salon;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string q = "select * from customer where id=(select MAX(id) from customer)";
     
            
           
            //SELECTING CUSTMER TO DISPL
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
     
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            con.Close();

            string t = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox3.Text = t;
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string t = dataGridView1.Rows[0].Cells[4].Value.ToString();
            int a = int.Parse(t);
            int b = int.Parse(textBox2.Text);
            int c = a - b;
            textBox1.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n.bill = 0;
            n.serve = "";
            MessageBox.Show("Thanks for your visit!");
            gender m = new gender();
            this.Visible = false;
            m.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
