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

namespace hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(username.Text=="")
            {
                MessageBox.Show("Entrer username");
            }
            else if(password.Text=="")
            {
                MessageBox.Show("Entrer password");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from login where username =@username and password = @password",conn);
                    cmd.Parameters.AddWithValue("username", username.Text);
                    cmd.Parameters.AddWithValue ("password", password.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0) 
                    {   
                        Home form2= new Home();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("invalid login");
                    }
                }
                catch (Exception x)
                { 
                    MessageBox.Show("" + x);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
