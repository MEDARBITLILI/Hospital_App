using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital
{
    public partial class Docteur : Form
    {
        public Docteur()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Patient form3 = new Patient();
            form3.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            RV form5 = new RV();
            form5.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }
       

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || specialite.Text == "" || phone.Text == "" || nomcli.SelectedItem== null )
            {
                MessageBox.Show("informations manquantes");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();
                    SqlCommand selectCmd = new SqlCommand("SELECT COUNT(*) FROM doctors WHERE nom = @nom And prenom=@prenom", conn);
                    selectCmd.Parameters.AddWithValue("nom", nom.Text);
                    selectCmd.Parameters.AddWithValue("prenom", prenom.Text);
                    int count = (int)selectCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Le Docteur " + nom.Text + " " + prenom.Text + " existe déjà !");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO doctors (nom, prenom, specialite, phone, id_cli) VALUES (@nom, @prenom, @specialite, @phone, (SELECT id_cli FROM clinics WHERE nomcli = @nomcli))", conn);

                        cmd.Parameters.AddWithValue("@nom", nom.Text);
                        cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                        cmd.Parameters.AddWithValue("@specialite", specialite.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@nomcli", nomcli.Text);
                        // Récupérer la clé primaire de la ligne insérée
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Docteur_Load(sender, e);
                        
                        {
                            MessageBox.Show("Le doctor ajouter avec sucee !");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void Docteur_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT d.nom, d.prenom, d.specialite, d.phone, c.nomcli AS nom_clinic FROM doctors d INNER JOIN clinics c ON d.id_cli = c.id_cli", conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvdoctor.DataSource = dt; // problem de load !!!

            cmd = new SqlCommand("SELECT nomcli FROM clinics", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            nomcli.Items.Clear();
            while (dr.Read())
            {
                nomcli.Items.Add(dr["nomcli"].ToString());
            }
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("SELECT id_doctor FROM doctors", conn);
            SqlDataReader dtr = cmd.ExecuteReader();
            id_doctor.Items.Clear();
            while (dtr.Read())
            {
                id_doctor.Items.Add(dtr["id_doctor"].ToString());
            }
            conn.Close();
            id_doctor.Text = ""; 
            nom.Text = "";
            prenom.Text = "";
            specialite.Text = ""; 
            phone.Text = "";      
            nomcli.Text = "";     
        }
        private void Imgdoc_Click(object sender, EventArgs e)
        {
            Docteur_Load(sender, e);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (id_doctor.Text == "")
            {
                MessageBox.Show("Select ID Doctor!");
            }
            else
            {
                try
                {
                     SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                     conn.Open();
                    {
                        
                        SqlCommand selectCmd = new SqlCommand("SELECT COUNT(*) FROM doctors WHERE id_doctor=@id_doctor", conn);
                        selectCmd.Parameters.AddWithValue("@id_doctor", id_doctor.Text);

                        int count = (int)selectCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            SqlCommand cmd = new SqlCommand("SELECT d.nom, d.prenom, d.specialite, d.phone, c.nomcli AS nom_clinic FROM doctors d INNER JOIN clinics c ON d.id_cli = c.id_cli WHERE d.id_doctor = @id_doctor", conn);
                            cmd.Parameters.AddWithValue("@id_doctor", id_doctor.Text);

                            SqlDataAdapter data = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            data.Fill(dt);
                            dgvdoctor.DataSource = dt;

                            SqlDataReader read = cmd.ExecuteReader();

                            if (read.Read())
                            {
                                nom.Text = read["nom"].ToString();
                                prenom.Text = read["prenom"].ToString();
                                specialite.Text = read["specialite"].ToString();
                                phone.Text = read["phone"].ToString();
                                nomcli.Text = read["nom_clinic"].ToString();
                            }

                            read.Close();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Le Docteur with ID " + id_doctor.Text + " n'existe pas !");
                        }
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
            if (id_doctor.Text == "")
            {
                MessageBox.Show("Choisir L'ID de Docteur !");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    // Supprimer les enregistrements associés dans la table "rv" pour le doctor
                    SqlCommand RVcmd = new SqlCommand("DELETE FROM rv WHERE id_doctor = @id_doctor", conn);
                    RVcmd.Parameters.AddWithValue("@id_doctor", id_doctor.Text);
                    RVcmd.ExecuteNonQuery();

                    // Supprimer le médecin de la table "doctors"
                    SqlCommand doctorcmd = new SqlCommand("DELETE FROM doctors WHERE id_doctor = @id_doctor", conn);
                    doctorcmd.Parameters.AddWithValue("@id_doctor", id_doctor.Text);
                    doctorcmd.ExecuteNonQuery();

                    conn.Close();
                    Docteur_Load(sender, e);
                    MessageBox.Show("Suppression effectuée avec succès");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void edit_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || specialite.Text == "" || phone.Text == "" || nomcli.SelectedItem == null)
            {
                MessageBox.Show("informations manquantes");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                   
                    SqlCommand duplicateCmd = new SqlCommand("SELECT COUNT(*) FROM doctors WHERE nom = @nom AND prenom = @prenom AND id_doctor <> @id_doctor", conn);
                    duplicateCmd.Parameters.AddWithValue("@nom", nom.Text);
                    duplicateCmd.Parameters.AddWithValue("@prenom", prenom.Text);
                    duplicateCmd.Parameters.AddWithValue("@id_doctor", id_doctor.Text);
                    int duplicateCount = (int)duplicateCmd.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("Le nom et le prénom existent déjà pour un autre médecin. Veuillez choisir un nom et un prénom différents.");
                    }
                    else
                    {
                        
                        SqlCommand cmd = new SqlCommand("UPDATE doctors SET nom = @nom, prenom = @prenom, specialite = @specialite, phone = @phone, id_cli = (SELECT id_cli FROM clinics WHERE nomcli = @nomcli) WHERE id_doctor = @id_doctor", conn);
                        cmd.Parameters.AddWithValue("@id_doctor", id_doctor.Text);
                        cmd.Parameters.AddWithValue("@nom", nom.Text);
                        cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                        cmd.Parameters.AddWithValue("@specialite", specialite.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@nomcli", nomcli.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        Docteur_Load(sender, e);
                        MessageBox.Show("Mise à jour effectuée avec succès");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Clinic form6 = new Clinic();
            form6.Show();
            this.Hide();
        }

        private void nomcli_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
    
}
