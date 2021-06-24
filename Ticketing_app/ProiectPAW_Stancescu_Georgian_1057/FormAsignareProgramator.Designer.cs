namespace ProiectPAW_Stancescu_Georgian_1057
{
    partial class FormAsignareProgramator
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
            this.lvProgramatori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.labelIndicatii = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lvProgramatori.Location = new System.Drawing.Point(12, 73);
            this.lvProgramatori.MultiSelect = false;
            this.lvProgramatori.Name = "lvProgramatori";
            this.lvProgramatori.Size = new System.Drawing.Size(694, 267);
            this.lvProgramatori.TabIndex = 17;
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
            this.columnHeader5.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Functie";
            this.columnHeader6.Width = 116;
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnuleaza.Location = new System.Drawing.Point(406, 368);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(110, 50);
            this.btnAnuleaza.TabIndex = 35;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirma.Location = new System.Drawing.Point(144, 368);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(116, 50);
            this.btnConfirma.TabIndex = 34;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // labelIndicatii
            // 
            this.labelIndicatii.AutoSize = true;
            this.labelIndicatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIndicatii.Location = new System.Drawing.Point(12, 30);
            this.labelIndicatii.Name = "labelIndicatii";
            this.labelIndicatii.Size = new System.Drawing.Size(534, 20);
            this.labelIndicatii.TabIndex = 36;
            this.labelIndicatii.Text = "Alegeti din lista un programator care sa preia tichetul selectat anterior.";
            // 
            // FormAsignareProgramator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 434);
            this.Controls.Add(this.labelIndicatii);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lvProgramatori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAsignareProgramator";
            this.Text = "Asignare Programator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvProgramatori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label labelIndicatii;
    }
}