namespace ProiectPAW_Stancescu_Georgian_1057
{
    partial class EditareProgramator
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
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(50, 203);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(256, 22);
            this.tbTelefon.TabIndex = 31;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(47, 183);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 17);
            this.labelTelefon.TabIndex = 30;
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
            this.cbFunctie.Location = new System.Drawing.Point(50, 248);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(256, 24);
            this.cbFunctie.TabIndex = 29;
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.Location = new System.Drawing.Point(47, 228);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(54, 17);
            this.labelFunctie.TabIndex = 28;
            this.labelFunctie.Text = "Functie";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(50, 158);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(256, 22);
            this.tbEmail.TabIndex = 27;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(47, 138);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(50, 113);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(256, 22);
            this.tbPrenume.TabIndex = 25;
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(47, 93);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 24;
            this.labelPrenume.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(50, 68);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(256, 22);
            this.tbNume.TabIndex = 23;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(47, 45);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 22;
            this.labelNume.Text = "Nume";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnuleaza.Location = new System.Drawing.Point(209, 302);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(120, 50);
            this.btnAnuleaza.TabIndex = 21;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirma.Location = new System.Drawing.Point(26, 302);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(122, 50);
            this.btnConfirma.TabIndex = 20;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // EditareProgramator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 373);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.cbFunctie);
            this.Controls.Add(this.labelFunctie);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnConfirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditareProgramator";
            this.Text = "Editare Programator";
            this.Load += new System.EventHandler(this.EditareProgramator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.Label labelFunctie;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
    }
}