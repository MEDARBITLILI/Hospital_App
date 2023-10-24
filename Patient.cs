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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || nom.Text == "" || prenom.Text == "" || sexe.Text == "" || maladie.Text == "" || adress.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM patient WHERE ID_patient=@ID_patient", conn);
                    countCmd.Parameters.AddWithValue("@ID_patient", id.Text);
                    int count = (int)countCmd.ExecuteScalar();
                    if (count > 0)     // L'ID_patient existe dans la table
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE patient SET nom=@nom,prenom=@prenom,sexe=@sexe,maladie=@maladie,adresse=@adresse,phone=@phone WHERE ID_patient=@ID_patient ", conn);
                        cmd.Parameters.AddWithValue("ID_patient", id.Text);
                        cmd.Parameters.AddWithValue("nom", nom.Text);
                        cmd.Parameters.AddWithValue("prenom", prenom.Text);
                        cmd.Parameters.AddWithValue("sexe", sexe.Text);
                        cmd.Parameters.AddWithValue("maladie", maladie.Text);
                        cmd.Parameters.AddWithValue("adresse", adress.Text);
                        cmd.Parameters.AddWithValue("phone", phone.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        id.Text = "";
                        nom.Text = "";
                        prenom.Text = "";
                        sexe.Text = "";
                        maladie.Text = "";
                        adress.Text = "";
                        phone.Text = "";
                        Patient_Load_1(sender, e);
                        MessageBox.Show("Mise à jour effectuée avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Le patient avec le CIN " + id.Text + " n'existe pas !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Docteur form4 = new Docteur();
            form4.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            RV form5 = new RV();
            form5.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Clinic form6 = new Clinic();
            form6.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || nom.Text == "" || prenom.Text == "" || sexe.Text == "" || maladie.Text == "" || adress.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    // Vérifier si le patient existe déjà dans la base de données
                    SqlCommand selectCmd = new SqlCommand("SELECT COUNT(*) FROM patient WHERE ID_patient = @ID_patient", conn);
                    selectCmd.Parameters.AddWithValue("@ID_patient", id.Text);
                    int count = (int)selectCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Le patient avec le CIN " + id.Text + " existe déjà !");
                    }
                    else
                    {
                        // Insérer un nouveau patient dans la base de données
                        SqlCommand cmd = new SqlCommand("INSERT INTO patient (ID_patient, nom, prenom, sexe, maladie, adresse, phone) VALUES (@ID_patient, @nom, @prenom, @sexe, @maladie, @adresse, @phone)", conn);
                        cmd.Parameters.AddWithValue("@ID_patient", id.Text);
                        cmd.Parameters.AddWithValue("@nom", nom.Text);
                        cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                        cmd.Parameters.AddWithValue("@sexe", sexe.Text);
                        cmd.Parameters.AddWithValue("@maladie", maladie.Text);
                        cmd.Parameters.AddWithValue("@adresse", adress.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        id.Text = "";
                        nom.Text = "";
                        prenom.Text = "";
                        sexe.Text = "";
                        maladie.Text = "";
                        adress.Text = "";
                        phone.Text = "";
                        Patient_Load_1(sender, e);
                        MessageBox.Show("Patient ajouté avec succès");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Input ID");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM patient WHERE ID_patient=@ID_patient", conn);
                    countCmd.Parameters.AddWithValue("@ID_patient", id.Text);
                    int count = (int)countCmd.ExecuteScalar();
                    if (count > 0)     // L'ID_patient existe dans la table
                    {
                        // Supprimer les enregistrements associés dans la table "rv" pour le doctor
                        SqlCommand RVcmd = new SqlCommand("DELETE FROM rv WHERE id_patient = @id_patient", conn);
                        RVcmd.Parameters.AddWithValue("@id_patient", id.Text);
                        RVcmd.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand("DELETE FROM patient WHERE ID_patient=@ID_patient ", conn);
                        cmd.Parameters.AddWithValue("ID_patient", id.Text);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        id.Text = "";
                        nom.Text = "";
                        prenom.Text = "";
                        sexe.Text = "";
                        maladie.Text = "";
                        adress.Text = "";
                        phone.Text = "";
                        MessageBox.Show("Suppression effectuée avec succès");
                        Patient_Load_1(sender, e);
                    }
                    else        // L'ID_patient n'existe pas dans la table
                    {
                        MessageBox.Show("Le Patient with CIN " + id.Text + " n'exist pas !");
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Entrez l'ID");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM patient WHERE @ID_patient=ID_patient", conn);
                    cmd.Parameters.AddWithValue("@ID_patient", id.Text);

                    //problem methode load
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dgvpatient.DataSource = dt;

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.Read())
                    {
                        nom.Text = read["nom"].ToString();
                        prenom.Text = read["prenom"].ToString();
                        sexe.Text = read["sexe"].ToString();
                        maladie.Text = read["maladie"].ToString();
                        phone.Text = read["phone"].ToString();
                        adress.Text = read["adresse"].ToString();
                    }
                    read.Close();
                    conn.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }


        private void dgvpatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM patient", conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvpatient.DataSource = dt;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Patient_Load_1(sender, e);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
