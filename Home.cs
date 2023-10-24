using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void PB_Click(object sender, EventArgs e)
        {
            Patient form3 = new Patient();
            form3.Show();
            this.Hide();
        }

        private void DB_Click(object sender, EventArgs e)
        {
            Docteur form4 = new Docteur();
            form4.Show();
            this.Hide();
        }

        private void HB_Click(object sender, EventArgs e)
        {
            Clinic form6 = new Clinic();
            form6.Show();
            this.Hide();
        }

        private void RB_Click_1(object sender, EventArgs e)
        {
            RV form5 = new RV();
            form5.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }

   
    
}
