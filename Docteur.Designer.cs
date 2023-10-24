namespace hospital
{
    partial class Docteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.specialite = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvdoctor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.nomcli = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bdclinicDataSet = new hospital.bdclinicDataSet();
            this.bdclinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_doctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.imgdoc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.docteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docteurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdclinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docteurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // specialite
            // 
            this.specialite.Animated = true;
            this.specialite.BorderRadius = 8;
            this.specialite.BorderThickness = 3;
            this.specialite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specialite.DefaultText = "";
            this.specialite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.specialite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.specialite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.specialite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialite.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.specialite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialite.Location = new System.Drawing.Point(44, 284);
            this.specialite.Name = "specialite";
            this.specialite.PasswordChar = '\0';
            this.specialite.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.specialite.PlaceholderText = "Specialite";
            this.specialite.SelectedText = "";
            this.specialite.Size = new System.Drawing.Size(158, 39);
            this.specialite.TabIndex = 44;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.AutoRoundedCorners = true;
            this.guna2GradientButton3.BorderRadius = 18;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(672, 54);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(170, 38);
            this.guna2GradientButton3.TabIndex = 40;
            this.guna2GradientButton3.Text = "Clinic";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BorderRadius = 18;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(457, 54);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(170, 38);
            this.guna2GradientButton2.TabIndex = 39;
            this.guna2GradientButton2.Text = "Rendez-vous";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 18;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(233, 54);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(170, 38);
            this.guna2GradientButton1.TabIndex = 38;
            this.guna2GradientButton1.Text = "Patient";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // dgvdoctor
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvdoctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdoctor.ColumnHeadersHeight = 30;
            this.dgvdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdoctor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvdoctor.Location = new System.Drawing.Point(233, 116);
            this.dgvdoctor.Name = "dgvdoctor";
            this.dgvdoctor.RowHeadersVisible = false;
            this.dgvdoctor.RowHeadersWidth = 30;
            this.dgvdoctor.Size = new System.Drawing.Size(609, 308);
            this.dgvdoctor.TabIndex = 37;
            this.dgvdoctor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvdoctor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvdoctor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdoctor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdoctor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdoctor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdoctor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdoctor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvdoctor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvdoctor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdoctor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdoctor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdoctor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvdoctor.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvdoctor.ThemeStyle.ReadOnly = false;
            this.dgvdoctor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvdoctor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdoctor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdoctor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvdoctor.ThemeStyle.RowsStyle.Height = 22;
            this.dgvdoctor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvdoctor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nom
            // 
            this.nom.Animated = true;
            this.nom.BorderRadius = 8;
            this.nom.BorderThickness = 3;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.Location = new System.Drawing.Point(44, 194);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nom.PlaceholderText = "Nom";
            this.nom.SelectedText = "";
            this.nom.Size = new System.Drawing.Size(158, 39);
            this.nom.TabIndex = 35;
            // 
            // prenom
            // 
            this.prenom.Animated = true;
            this.prenom.BorderRadius = 8;
            this.prenom.BorderThickness = 3;
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.DefaultText = "";
            this.prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.Location = new System.Drawing.Point(44, 239);
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.prenom.PlaceholderText = "Prenom";
            this.prenom.SelectedText = "";
            this.prenom.Size = new System.Drawing.Size(158, 39);
            this.prenom.TabIndex = 34;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(532, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(343, 25);
            this.guna2Panel1.TabIndex = 47;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(295, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 17);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(244, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 17);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Animated = true;
            this.Search.AutoRoundedCorners = true;
            this.Search.BorderRadius = 19;
            this.Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Search.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Search.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(260, 438);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(148, 41);
            this.Search.TabIndex = 52;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // add
            // 
            this.add.Animated = true;
            this.add.AutoRoundedCorners = true;
            this.add.BorderRadius = 19;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.add.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(54, 438);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 41);
            this.add.TabIndex = 51;
            this.add.Text = "Add";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Animated = true;
            this.delete.AutoRoundedCorners = true;
            this.delete.BorderRadius = 19;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.delete.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(693, 438);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(153, 41);
            this.delete.TabIndex = 50;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Animated = true;
            this.edit.AutoRoundedCorners = true;
            this.edit.BorderRadius = 19;
            this.edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.edit.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(478, 438);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(147, 41);
            this.edit.TabIndex = 49;
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // phone
            // 
            this.phone.Animated = true;
            this.phone.BorderRadius = 8;
            this.phone.BorderThickness = 3;
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.DefaultText = "";
            this.phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.Location = new System.Drawing.Point(44, 329);
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phone.PlaceholderText = "Telephone";
            this.phone.SelectedText = "";
            this.phone.Size = new System.Drawing.Size(158, 39);
            this.phone.TabIndex = 53;
            this.phone.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // nomcli
            // 
            this.nomcli.BackColor = System.Drawing.Color.Transparent;
            this.nomcli.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.nomcli.BorderRadius = 8;
            this.nomcli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nomcli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomcli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nomcli.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomcli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomcli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nomcli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomcli.ItemHeight = 30;
            this.nomcli.Location = new System.Drawing.Point(44, 374);
            this.nomcli.Name = "nomcli";
            this.nomcli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomcli.Size = new System.Drawing.Size(158, 36);
            this.nomcli.TabIndex = 54;
            this.nomcli.SelectedIndexChanged += new System.EventHandler(this.nomcli_SelectedIndexChanged);
            // 
            // bdclinicDataSet
            // 
            this.bdclinicDataSet.DataSetName = "bdclinicDataSet";
            this.bdclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdclinicDataSetBindingSource
            // 
            this.bdclinicDataSetBindingSource.DataSource = this.bdclinicDataSet;
            this.bdclinicDataSetBindingSource.Position = 0;
            // 
            // id_doctor
            // 
            this.id_doctor.BackColor = System.Drawing.Color.Transparent;
            this.id_doctor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.id_doctor.BorderRadius = 8;
            this.id_doctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.id_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_doctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.id_doctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_doctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_doctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.id_doctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_doctor.ItemHeight = 30;
            this.id_doctor.Location = new System.Drawing.Point(44, 152);
            this.id_doctor.Name = "id_doctor";
            this.id_doctor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_doctor.Size = new System.Drawing.Size(158, 36);
            this.id_doctor.TabIndex = 55;
            // 
            // imgdoc
            // 
            this.imgdoc.BackColor = System.Drawing.Color.Transparent;
            this.imgdoc.Image = global::hospital.Properties.Resources.Doctors_bro;
            this.imgdoc.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.imgdoc.ImageRotate = 0F;
            this.imgdoc.Location = new System.Drawing.Point(24, 7);
            this.imgdoc.Name = "imgdoc";
            this.imgdoc.Size = new System.Drawing.Size(203, 127);
            this.imgdoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgdoc.TabIndex = 48;
            this.imgdoc.TabStop = false;
            this.imgdoc.Click += new System.EventHandler(this.Imgdoc_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::hospital.Properties.Resources.exit;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(4, 473);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 56;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // docteurBindingSource
            // 
            this.docteurBindingSource.DataSource = typeof(hospital.Docteur);
            // 
            // docteurBindingSource1
            // 
            this.docteurBindingSource1.DataSource = typeof(hospital.Docteur);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Docteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 507);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.id_doctor);
            this.Controls.Add(this.nomcli);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.imgdoc);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.dgvdoctor);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Docteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docteur";
            this.Load += new System.EventHandler(this.Docteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdclinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docteurBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox specialite;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvdoctor;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2PictureBox imgdoc;
        private Guna.UI2.WinForms.Guna2GradientButton Search;
        private Guna.UI2.WinForms.Guna2GradientButton add;
        private Guna.UI2.WinForms.Guna2GradientButton delete;
        private Guna.UI2.WinForms.Guna2GradientButton edit;
        private Guna.UI2.WinForms.Guna2TextBox phone;
        private Guna.UI2.WinForms.Guna2ComboBox nomcli;
        private System.Windows.Forms.BindingSource docteurBindingSource;
        private bdclinicDataSet bdclinicDataSet;
        private System.Windows.Forms.BindingSource bdclinicDataSetBindingSource;
        private System.Windows.Forms.BindingSource docteurBindingSource1;
        private Guna.UI2.WinForms.Guna2ComboBox id_doctor;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}