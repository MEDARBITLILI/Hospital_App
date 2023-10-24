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

namespace hospital
{
    public partial class RV : Form
    {
        public RV()
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
            Docteur form4 = new Docteur();
            form4.Show();
            this.Hide();
        }

        private void RV_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
            conn.Open();

            
            SqlCommand cmd = new SqlCommand("SELECT rv.id_rv, CONCAT(doctors.nom, ' ', doctors.prenom) AS doctor_name, CONCAT(patient.nom, ' ', patient.prenom) AS patient_name, rv.date, rv.reason, COUNT(rv.id_rv) AS num_rv FROM rv INNER JOIN doctors ON rv.id_doctor = doctors.ID_doctor INNER JOIN patient ON rv.id_patient = patient.ID_patient GROUP BY rv.id_rv, doctors.nom, doctors.prenom, patient.nom, patient.prenom, rv.date, rv.reason", conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvrv.DataSource = dt;

            // Charger les id des RV dans la combobox
            cmd = new SqlCommand("SELECT id_rv FROM rv", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            id_rv.Items.Clear();
            while (dr.Read())
            {
                id_rv.Items.Add(dr["id_rv"].ToString());
            }
            dr.Close();

            // Charger les noms des médecins dans la combobox
            cmd = new SqlCommand("SELECT nom, prenom FROM doctors", conn);
            SqlDataReader dr1 = cmd.ExecuteReader();
            doctor.Items.Clear();
            while (dr1.Read())
            {
                string nom = dr1["nom"].ToString();
                string prenom = dr1["prenom"].ToString();
                string nomComplet = nom + " " + prenom;
                doctor.Items.Add(nomComplet);
            }
            dr1.Close();

            // Charger les noms des patients dans la combobox
            cmd = new SqlCommand("SELECT nom, prenom FROM patient", conn);
            SqlDataReader dr2 = cmd.ExecuteReader();
            patient.Items.Clear();
            while (dr2.Read())
            {
                string nom = dr2["nom"].ToString();
                string prenom = dr2["prenom"].ToString();
                string nomComplet = nom + " " + prenom;
                patient.Items.Add(nomComplet);
            }
            dr2.Close();
            reason.Text = "";
            date.Text =  "";
            conn.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (doctor.SelectedItem == null || patient.SelectedItem == null || date.Text == "" || reason.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    // Récupérer l'ID du patient sélectionné
                    string selectedPatient = patient.SelectedItem.ToString();
                    int patientID;
                    SqlCommand pcmd = new SqlCommand("SELECT ID_patient FROM patient WHERE CONCAT(nom, ' ', prenom) = @nomComplet", conn);
                    pcmd.Parameters.AddWithValue("@nomComplet", selectedPatient);
                    object patientResult = pcmd.ExecuteScalar();
                    //le type object est utilisé pour représenter de manière générique n'importe quel type de données et permet la manipulation d'objets de différents types à l'aide d'une référence commune.
                    if (patientResult != null && int.TryParse(patientResult.ToString(), out patientID))
                    {
                    }
                    else
                    {
                        // Le patient n'a pas été trouvé, afficher un message d'erreur
                        MessageBox.Show("Patient sélectionné non valide");
                        conn.Close();
                        return;
                    }

                    string selectDoctor = doctor.SelectedItem.ToString();
                    int doctorID;
                    SqlCommand dcmd = new SqlCommand("SELECT ID_doctor FROM doctors WHERE CONCAT(nom, ' ', prenom) = @nomComplet", conn);
                    dcmd.Parameters.AddWithValue("@nomComplet", selectDoctor);
                    object doctorResultat = dcmd.ExecuteScalar();
                    if (doctorResultat != null && int.TryParse(doctorResultat.ToString(), out doctorID))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Médecin sélectionné non valide");
                        conn.Close();
                        return;
                    }

                    // Vérifier si un rendez-vous similaire existe déjà
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM rv WHERE id_patient = @patientId AND id_doctor = @doctorId AND date = @date", conn);
                    cmd.Parameters.AddWithValue("@patientId", patientID);
                    cmd.Parameters.AddWithValue("@doctorId", doctorID);
                    cmd.Parameters.AddWithValue("@date", date.Text);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Un rendez-vous similaire existe déjà");
                        conn.Close();
                        return;
                    }

                    // Insérer les données dans la table rv
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO rv (id_patient, id_doctor, date, reason) VALUES (@id_patient, @id_doctor, @date, @reason)", conn);
                    cmd1.Parameters.AddWithValue("@id_patient", patientID);
                    cmd1.Parameters.AddWithValue("@id_doctor", doctorID);
                    cmd1.Parameters.AddWithValue("@date", date.Text);
                    cmd1.Parameters.AddWithValue("@reason", reason.Text);
                    cmd1.ExecuteNonQuery();
                    

                    conn.Close();
                    RV_Load(sender, e);
                    MessageBox.Show("Rendez-vous ajouté avec succès");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            RV_Load(sender, e);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id_rv.SelectedItem == null)
            {
                MessageBox.Show("Aucun rendez-vous sélectionné");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
            try
            {
                int selectedRVID = int.Parse(id_rv.SelectedItem.ToString());

                
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM rv WHERE id_rv = @rvID", conn);
                    cmd.Parameters.AddWithValue("@rvID", selectedRVID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rendez-vous supprimé avec succès");
                        RV_Load(sender, e); // Recharger les rendez-vous après suppression
                    }
                    else
                    {
                        MessageBox.Show("Echec de la suppression du rendez-vous");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (id_rv.SelectedItem == null)
            {
                MessageBox.Show("Aucun rendez-vous sélectionné");
                
            }

            if (doctor.SelectedItem == null || patient.SelectedItem == null || date.Text == "" || reason.Text == "")
            {
                MessageBox.Show("Informations manquantes");
                
            }

            try
            {
                int selectedRVID = int.Parse(id_rv.SelectedItem.ToString());

                // Récupérer l'ID du patient sélectionné
                string selectedPatient = patient.SelectedItem.ToString();
                int patientID;
                SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                {
                    conn.Open();

                    SqlCommand patientCmd = new SqlCommand("SELECT ID_patient FROM patient WHERE CONCAT(nom, ' ', prenom) = @nomComplet", conn);
                    patientCmd.Parameters.AddWithValue("@nomComplet", selectedPatient);
                    object patientResult = patientCmd.ExecuteScalar();
                    if (patientResult != null && int.TryParse(patientResult.ToString(), out patientID))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Patient sélectionné non valide");
                        conn.Close();
                        return;
                    }

                    string selectedDoctor = doctor.SelectedItem.ToString();
                    int doctorID;
                    SqlCommand doctorCmd = new SqlCommand("SELECT ID_doctor FROM doctors WHERE CONCAT(nom, ' ', prenom) = @nomComplet", conn);
                    doctorCmd.Parameters.AddWithValue("@nomComplet", selectedDoctor);
                    object doctorResult = doctorCmd.ExecuteScalar();
                    if (doctorResult != null && int.TryParse(doctorResult.ToString(), out doctorID))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Médecin sélectionné non valide");
                        conn.Close();
                        return;
                    }

                    // Mettre à jour les données dans la table rv
                    SqlCommand updateCmd = new SqlCommand("UPDATE rv SET id_patient = @id_patient, id_doctor = @id_doctor, date = @date, reason = @reason WHERE id_rv = @rvID", conn);
                    updateCmd.Parameters.AddWithValue("@id_patient", patientID);
                    updateCmd.Parameters.AddWithValue("@id_doctor", doctorID);
                    updateCmd.Parameters.AddWithValue("@date", date.Text);
                    updateCmd.Parameters.AddWithValue("@reason", reason.Text);
                    updateCmd.Parameters.AddWithValue("@rvID", selectedRVID);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rendez-vous mis à jour avec succès");
                        RV_Load(sender, e); // Recharger les rendez-vous après modification
                    }
                    else
                    {
                        MessageBox.Show("Impossible de mettre à jour le rendez-vous");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (id_rv.Text == "")
            {
                MessageBox.Show("Select ID Rendez-Vous!");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=bdclinic;Integrated Security=True");
                    conn.Open();

                    SqlCommand selectCmd = new SqlCommand("SELECT COUNT(*) FROM rv WHERE id_rv = @id_rv", conn);
                    selectCmd.Parameters.AddWithValue("@id_rv", id_rv.Text);

                    int count = (int)selectCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT rv.date, rv.reason, CONCAT(doctors.nom, ' ', doctors.prenom) AS doctor_name, CONCAT(patient.nom, ' ', patient.prenom) AS patient_name FROM rv INNER JOIN doctors ON rv.id_doctor = doctors.ID_doctor INNER JOIN patient ON rv.id_patient = patient.ID_patient WHERE rv.id_rv = @id_rv", conn);
                        cmd.Parameters.AddWithValue("@id_rv", id_rv.Text);

                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        dgvrv.DataSource = dt;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            date.Text = reader["date"].ToString();
                            reason.Text = reader["reason"].ToString();
                            doctor.SelectedItem = reader["doctor_name"].ToString();
                            patient.SelectedItem = reader["patient_name"].ToString();
                        }

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le Rendez-Vous avec l'ID " + id_rv.Text + " n'existe pas !");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Clinic form6 = new Clinic();
            form6.Show();
            this.Hide();
        }
    }

}
