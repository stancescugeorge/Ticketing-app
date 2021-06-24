namespace ProiectPAW_Stancescu_Georgian_1057
{
    partial class FormSolutie
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
            this.labelCauza = new System.Windows.Forms.Label();
            this.tbCauza = new System.Windows.Forms.TextBox();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.epContinut = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epContinut)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCauza
            // 
            this.labelCauza.AutoSize = true;
            this.labelCauza.Location = new System.Drawing.Point(31, 30);
            this.labelCauza.Name = "labelCauza";
            this.labelCauza.Size = new System.Drawing.Size(114, 17);
            this.labelCauza.TabIndex = 0;
            this.labelCauza.Text = "Cauza problemei";
            // 
            // tbCauza
            // 
            this.tbCauza.Location = new System.Drawing.Point(34, 51);
            this.tbCauza.Name = "tbCauza";
            this.tbCauza.Size = new System.Drawing.Size(481, 22);
            this.tbCauza.TabIndex = 1;
            this.tbCauza.Text = "-";
            this.tbCauza.Validating += new System.ComponentModel.CancelEventHandler(this.tbCauza_Validating);
            this.tbCauza.Validated += new System.EventHandler(this.tbCauza_Validated);
            // 
            // tbDescriere
            // 
            this.tbDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDescriere.Location = new System.Drawing.Point(34, 97);
            this.tbDescriere.Multiline = true;
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(481, 164);
            this.tbDescriere.TabIndex = 3;
            this.tbDescriere.Text = "-";
            this.tbDescriere.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescriere_Validating);
            this.tbDescriere.Validated += new System.EventHandler(this.tbDescriere_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descriere solutie";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnuleaza.Location = new System.Drawing.Point(178, 281);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(112, 50);
            this.btnAnuleaza.TabIndex = 35;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirma.Location = new System.Drawing.Point(34, 281);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(116, 50);
            this.btnConfirma.TabIndex = 34;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSterge.Location = new System.Drawing.Point(399, 281);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(116, 50);
            this.btnSterge.TabIndex = 36;
            this.btnSterge.Text = "Sterge solutia";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // epContinut
            // 
            this.epContinut.ContainerControl = this;
            // 
            // FormSolutie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 343);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCauza);
            this.Controls.Add(this.labelCauza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSolutie";
            this.Text = "Adauga/Editeaza Solutie";
            this.Load += new System.EventHandler(this.FormSolutie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epContinut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCauza;
        private System.Windows.Forms.TextBox tbCauza;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ErrorProvider epContinut;
    }
}