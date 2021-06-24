namespace ProiectPAW_Stancescu_Georgian_1057
{
    partial class FormProgrammers
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
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.labelTitluListaProgramatori = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.cbFunctie = new System.Windows.Forms.ComboBox();
            this.labelFunctie = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lvProgramatori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epNumePrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFunctie = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumePrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFunctie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(413, 395);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(151, 50);
            this.btnEditeaza.TabIndex = 17;
            this.btnEditeaza.Text = "Editeaza detalii programator";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // labelTitluListaProgramatori
            // 
            this.labelTitluListaProgramatori.AutoSize = true;
            this.labelTitluListaProgramatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitluListaProgramatori.Location = new System.Drawing.Point(564, 52);
            this.labelTitluListaProgramatori.Name = "labelTitluListaProgramatori";
            this.labelTitluListaProgramatori.Size = new System.Drawing.Size(207, 29);
            this.labelTitluListaProgramatori.TabIndex = 16;
            this.labelTitluListaProgramatori.Text = "Lista programatori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.labelTelefon);
            this.groupBox1.Controls.Add(this.cbFunctie);
            this.groupBox1.Controls.Add(this.labelFunctie);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.tbPrenume);
            this.groupBox1.Controls.Add(this.labelPrenume);
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.labelNume);
            this.groupBox1.Controls.Add(this.btnCurata);
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 399);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programator nou";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(18, 190);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(236, 22);
            this.tbTelefon.TabIndex = 19;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(15, 170);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 17);
            this.labelTelefon.TabIndex = 18;
            this.labelTelefon.Text = "Telefon";
            // 
            // cbFunctie
            // 
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Items.AddRange(new object[] {
            "Intern",
            "Junior_dev",
            "Developer",
            "Senior_arch"});
            this.cbFunctie.Location = new System.Drawing.Point(18, 235);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(236, 24);
            this.cbFunctie.TabIndex = 17;
            this.cbFunctie.Validating += new System.ComponentModel.CancelEventHandler(this.cbFunctie_Validating);
            this.cbFunctie.Validated += new System.EventHandler(this.cbFunctie_Validated);
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.Location = new System.Drawing.Point(15, 215);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(54, 17);
            this.labelFunctie.TabIndex = 16;
            this.labelFunctie.Text = "Functie";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(18, 145);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(236, 22);
            this.tbEmail.TabIndex = 15;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 125);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(18, 100);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(236, 22);
            this.tbPrenume.TabIndex = 13;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(15, 80);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 12;
            this.labelPrenume.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(18, 55);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(236, 22);
            this.tbNume.TabIndex = 11;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(15, 32);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 10;
            this.labelNume.Text = "Nume";
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(61, 343);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(151, 50);
            this.btnCurata.TabIndex = 9;
            this.btnCurata.Text = "Curata formular";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(61, 272);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(151, 50);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga programator";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lvProgramatori
            // 
            this.lvProgramatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvProgramatori.FullRowSelect = true;
            this.lvProgramatori.HideSelection = false;
            this.lvProgramatori.Location = new System.Drawing.Point(325, 107);
            this.lvProgramatori.MultiSelect = false;
            this.lvProgramatori.Name = "lvProgramatori";
            this.lvProgramatori.Size = new System.Drawing.Size(694, 267);
            this.lvProgramatori.TabIndex = 14;
            this.lvProgramatori.UseCompatibleStateImageBehavior = false;
            this.lvProgramatori.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenume";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Functie";
            this.columnHeader6.Width = 89;
            // 
            // epNumePrenume
            // 
            this.epNumePrenume.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epTelefon
            // 
            this.epTelefon.ContainerControl = this;
            // 
            // epFunctie
            // 
            this.epFunctie.ContainerControl = this;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.Location = new System.Drawing.Point(908, 395);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 50);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(655, 395);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(151, 50);
            this.btnSterge.TabIndex = 19;
            this.btnSterge.Text = "Sterge programator";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // FormProgrammers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 464);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.labelTitluListaProgramatori);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvProgramatori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormProgrammers";
            this.Text = "Formular Programatori";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumePrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFunctie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Label labelTitluListaProgramatori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.Label labelFunctie;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListView lvProgramatori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.ErrorProvider epNumePrenume;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epTelefon;
        private System.Windows.Forms.ErrorProvider epFunctie;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSterge;
    }
}