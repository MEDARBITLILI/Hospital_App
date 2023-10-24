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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace hospital
{
    public partial class Clinic : Form
    {
        

        public Clinic()
        {
            InitializeComponent();
        }



        private void Clinic_Load(object sender, EventArgs e)
        {
             
                SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                conn.Open();

                
                SqlCommand cmd = new SqlCommand("SELECT c.nomcli, c.adress, c.phone, COUNT(d.id_doctor) AS nombre_doctors FROM clinics c LEFT JOIN doctors d ON c.id_cli = d.id_cli GROUP BY c.nomcli, c.adress, c.phone", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvclinic.DataSource = dt;

                cmd = new SqlCommand("SELECT nomcli FROM clinics", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                listeclinic.Items.Clear();
                while (dr.Read())
                {
                    listeclinic.Items.Add(dr["nomcli"].ToString());
                }
                conn.Close();

                nomcli.Text = "";
                adress.Text = "";
                phone.Text = "";
           
        }


        private void imgclinic_Click(object sender, EventArgs e)
        {
            Clinic_Load(sender, e);
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            if (nomcli.Text == "" || adress.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();
                    SqlCommand selectCmd = new SqlCommand("SELECT COUNT(*) FROM clinics WHERE nomcli = @nomcli", conn);
                    selectCmd.Parameters.AddWithValue("nomcli", nomcli.Text);
                    int count = (int)selectCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("La clinique " + nomcli.Text + "  déjà existe !");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO clinics (nomcli,adress,phone) VALUES (@nomcli,@adress,@phone)", conn);
                        cmd.Parameters.AddWithValue("nomcli", nomcli.Text);
                        cmd.Parameters.AddWithValue("adress", adress.Text);
                        cmd.Parameters.AddWithValue("phone", phone.Text);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                
                        Clinic_Load(sender, e);
                        MessageBox.Show("La Clinique ajoutée avec succès");
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
            Docteur form4 = new Docteur();
            form4.Show();
            this.Hide();
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

        private void edit_Click(object sender, EventArgs e)
        {
            if (listeclinic.SelectedItem == null || nomcli.Text == "" || adress.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    string nomClinic = listeclinic.SelectedItem.ToString();

                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    //sna3t variable 7attit fih nom clinic
                    SqlCommand duplicateCmd = new SqlCommand("SELECT COUNT(*) FROM clinics WHERE nomcli = @nomcli AND id_cli <> (SELECT id_cli FROM clinics WHERE nomcli = @nomClinic)", conn);
                    duplicateCmd.Parameters.AddWithValue("@nomcli", nomcli.Text);
                    duplicateCmd.Parameters.AddWithValue("@nomClinic", nomClinic);
                    int duplicateCount = (int)duplicateCmd.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("Le nom de la clinique existe déjà. Veuillez choisir un nom différent.");
                    }
                    else
                    {
                        
                        SqlCommand cmd = new SqlCommand("UPDATE clinics SET nomcli = @nomcli, adress = @adress, phone = @phone WHERE nomcli = @nomClinic", conn);
                        cmd.Parameters.AddWithValue("@nomcli", nomcli.Text);
                        cmd.Parameters.AddWithValue("@adress", adress.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@nomClinic", nomClinic);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        Clinic_Load(sender, e);
                        MessageBox.Show("Mise à jour effectuée avec succès");
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
            if (listeclinic.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une clinique à supprimer.");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    // Vérifier si la clinique existe
                    SqlCommand count = new SqlCommand("SELECT COUNT(*) FROM clinics WHERE nomcli = @nomcli", conn);
                    count.Parameters.AddWithValue("@nomcli", listeclinic.SelectedItem.ToString());
                    int clinicount = (int)count.ExecuteScalar();

                    if (clinicount > 0)
                    {
                        // Supprimer les docteurs associés à la clinique
                        SqlCommand cmd = new SqlCommand("DELETE FROM doctors WHERE id_cli = (SELECT id_cli FROM clinics WHERE nomcli = @nomcli)", conn);
                        cmd.Parameters.AddWithValue("@nomcli", listeclinic.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();

                        // Supprimer la clinique
                        SqlCommand deleteClinicCmd = new SqlCommand("DELETE FROM clinics WHERE nomcli = @nomcli", conn);
                        deleteClinicCmd.Parameters.AddWithValue("@nomcli", listeclinic.SelectedItem.ToString());
                        deleteClinicCmd.ExecuteNonQuery();

                        conn.Close();

                        Clinic_Load(sender, e);
                        MessageBox.Show("La clinique et les médecins associés ont été supprimés avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("La clinique sélectionnée n'existe pas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        private void Search_Click(object sender, EventArgs e)
        {
            if (listeclinic.Text == "")
            {
                MessageBox.Show("Choisir le nom de clinique à chercher !");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    
                    SqlCommand clinicCmd = new SqlCommand("SELECT COUNT(*) FROM clinics WHERE nomcli=@nomcli", conn);
                    clinicCmd.Parameters.AddWithValue("@nomcli", listeclinic.Text);
                    int clinicCount = (int)clinicCmd.ExecuteScalar();

                    if (clinicCount > 0)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT c.nomcli, c.adress, c.phone, COUNT(d.id_doctor) AS nombre_doctors FROM clinics c LEFT JOIN doctors d ON c.id_cli = d.id_cli WHERE c.nomcli = @nomcli GROUP BY c.nomcli, c.adress, c.phone", conn);
                        cmd.Parameters.AddWithValue("@nomcli", listeclinic.Text);
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        dgvclinic.DataSource = dt;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            nomcli.Text = dr["nomcli"].ToString();
                            adress.Text = dr["adress"].ToString();
                            phone.Text = dr["phone"].ToString();
                        }
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aucun résultat trouvé.");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listeclinic_SelectedIndexChanged(object sender, EventArgs e)
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
