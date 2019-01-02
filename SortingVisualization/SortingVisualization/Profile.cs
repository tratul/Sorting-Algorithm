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

namespace SortingVisualization
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != " ")
            {
                if (textBox1.Text != null && textBox2.Text != null)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PRPMMA8\HASANDB;Initial Catalog=sorting_algo;Integrated Security=True");
                    con.Open();
                    string s = "Update Admin set Name ='" + textBox1.Text + "', Password='" + textBox2.Text + "' where id='1'";
                    SqlCommand cmd = new SqlCommand(s, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.Read())
                    //{
                    MessageBox.Show("Your User Name and Password Update Succesfully.");
                    this.Hide();
                    Profile p = new Profile();
                    p.Show();
                    //}
                }
                else
                    MessageBox.Show("Please all the information!");
            }
            else
                label7.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}
