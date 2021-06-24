namespace ProiectPAW_Stancescu_Georgian_1057
{
    partial class EditareBugs
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
            this.epContinutText = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGravitate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDataRaportare = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEditareDetalii = new System.Windows.Forms.GroupBox();
            this.labelDataRaportare = new System.Windows.Forms.Label();
            this.dtpDataRaportare = new System.Windows.Forms.DateTimePicker();
            this.cbGravitate = new System.Windows.Forms.ComboBox();
            this.labelGravitate = new System.Windows.Forms.Label();
            this.tbDescriereProblema = new System.Windows.Forms.TextBox();
            this.labelDescriereProblema = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.tbTitluProblema = new System.Windows.Forms.TextBox();
            this.labelTitluProblema = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.groupBoxStadiu = new System.Windows.Forms.GroupBox();
            this.btnSolutie = new System.Windows.Forms.Button();
            this.btnAsigneazaProg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epContinutText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGravitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDataRaportare)).BeginInit();
            this.groupBoxEditareDetalii.SuspendLayout();
            this.groupBoxStadiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // epContinutText
            // 
            this.epContinutText.ContainerControl = this;
            // 
            // epGravitate
            // 
            this.epGravitate.ContainerControl = this;
            // 
            // epDataRaportare
            // 
            this.epDataRaportare.ContainerControl = this;
            // 
            // groupBoxEditareDetalii
            // 
            this.groupBoxEditareDetalii.Controls.Add(this.labelDataRaportare);
            this.groupBoxEditareDetalii.Controls.Add(this.dtpDataRaportare);
            this.groupBoxEditareDetalii.Controls.Add(this.cbGravitate);
            this.groupBoxEditareDetalii.Controls.Add(this.labelGravitate);
            this.groupBoxEditareDetalii.Controls.Add(this.tbDescriereProblema);
            this.groupBoxEditareDetalii.Controls.Add(this.labelDescriereProblema);
            this.groupBoxEditareDetalii.Controls.Add(this.tbClient);
            this.groupBoxEditareDetalii.Controls.Add(this.labelClient);
            this.groupBoxEditareDetalii.Controls.Add(this.tbTitluProblema);
            this.groupBoxEditareDetalii.Controls.Add(this.labelTitluProblema);
            this.groupBoxEditareDetalii.Controls.Add(this.btnAnuleaza);
            this.groupBoxEditareDetalii.Controls.Add(this.btnConfirma);
            this.groupBoxEditareDetalii.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEditareDetalii.Name = "groupBoxEditareDetalii";
            this.groupBoxEditareDetalii.Size = new System.Drawing.Size(329, 376);
            this.groupBoxEditareDetalii.TabIndex = 0;
            this.groupBoxEditareDetalii.TabStop = false;
            this.groupBoxEditareDetalii.Text = "Editare detalii";
            // 
            // labelDataRaportare
            // 
            this.labelDataRaportare.AutoSize = true;
            this.labelDataRaportare.Location = new System.Drawing.Point(46, 254);
            this.labelDataRaportare.Name = "labelDataRaportare";
            this.labelDataRaportare.Size = new System.Drawing.Size(101, 17);
            this.labelDataRaportare.TabIndex = 43;
            this.labelDataRaportare.Text = "Data raportare";
            // 
            // dtpDataRaportare
            // 
            this.dtpDataRaportare.Location = new System.Drawing.Point(46, 274);
            this.dtpDataRaportare.Name = "dtpDataRaportare";
            this.dtpDataRaportare.Size = new System.Drawing.Size(236, 22);
            this.dtpDataRaportare.TabIndex = 42;
            this.dtpDataRaportare.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataRaportare_Validating);
            this.dtpDataRaportare.Validated += new System.EventHandler(this.dtpDataRaportare_Validated);
            // 
            // cbGravitate
            // 
            this.cbGravitate.FormattingEnabled = true;
            this.cbGravitate.Items.AddRange(new object[] {
            "MEDIU",
            "URGENT",
            "CRITIC"});
            this.cbGravitate.Location = new System.Drawing.Point(46, 223);
            this.cbGravitate.Name = "cbGravitate";
            this.cbGravitate.Size = new System.Drawing.Size(236, 24);
            this.cbGravitate.TabIndex = 41;
            this.cbGravitate.Validating += new System.ComponentModel.CancelEventHandler(this.cbGravitate_Validating);
            this.cbGravitate.Validated += new System.EventHandler(this.cbGravitate_Validated);
            // 
            // labelGravitate
            // 
            this.labelGravitate.AutoSize = true;
            this.labelGravitate.Location = new System.Drawing.Point(43, 202);
            this.labelGravitate.Name = "labelGravitate";
            this.labelGravitate.Size = new System.Drawing.Size(66, 17);
            this.labelGravitate.TabIndex = 40;
            this.labelGravitate.Text = "Gravitate";
            // 
            // tbDescriereProblema
            // 
            this.tbDescriereProblema.Location = new System.Drawing.Point(46, 143);
            this.tbDescriereProblema.Multiline = true;
            this.tbDescriereProblema.Name = "tbDescriereProblema";
            this.tbDescriereProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescriereProblema.Size = new System.Drawing.Size(236, 56);
            this.tbDescriereProblema.TabIndex = 39;
            this.tbDescriereProblema.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescriereProblema_Validating);
            this.tbDescriereProblema.Validated += new System.EventHandler(this.tbDescriereProblema_Validated);
            // 
            // labelDescriereProblema
            // 
            this.labelDescriereProblema.AutoSize = true;
            this.labelDescriereProblema.Location = new System.Drawing.Point(43, 123);
            this.labelDescriereProblema.Name = "labelDescriereProblema";
            this.labelDescriereProblema.Size = new System.Drawing.Size(132, 17);
            this.labelDescriereProblema.TabIndex = 38;
            this.labelDescriereProblema.Text = "Descriere problema";
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(46, 98);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(236, 22);
            this.tbClient.TabIndex = 37;
            this.tbClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbClient_Validating);
            this.tbClient.Validated += new System.EventHandler(this.tbClient_Validated);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(43, 78);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(82, 17);
            this.labelClient.TabIndex = 36;
            this.labelClient.Text = "Nume client";
            // 
            // tbTitluProblema
            // 
            this.tbTitluProblema.Location = new System.Drawing.Point(46, 53);
            this.tbTitluProblema.Name = "tbTitluProblema";
            this.tbTitluProblema.Size = new System.Drawing.Size(236, 22);
            this.tbTitluProblema.TabIndex = 35;
            this.tbTitluProblema.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitluProblema_Validating);
            this.tbTitluProblema.Validated += new System.EventHandler(this.tbTitluProblema_Validated);
            // 
            // labelTitluProblema
            // 
            this.labelTitluProblema.AutoSize = true;
            this.labelTitluProblema.Location = new System.Drawing.Point(43, 30);
            this.labelTitluProblema.Name = "labelTitluProblema";
            this.labelTitluProblema.Size = new System.Drawing.Size(98, 17);
            this.labelTitluProblema.TabIndex = 34;
            this.labelTitluProblema.Text = "Titlu problema";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnuleaza.Location = new System.Drawing.Point(186, 312);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(112, 50);
            this.btnAnuleaza.TabIndex = 33;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirma.Location = new System.Drawing.Point(25, 312);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(116, 50);
            this.btnConfirma.TabIndex = 32;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // groupBoxStadiu
            // 
            this.groupBoxStadiu.Controls.Add(this.btnSolutie);
            this.groupBoxStadiu.Controls.Add(this.btnAsigneazaProg);
            this.groupBoxStadiu.Location = new System.Drawing.Point(363, 65);
            this.groupBoxStadiu.Name = "groupBoxStadiu";
            this.groupBoxStadiu.Size = new System.Drawing.Size(171, 243);
            this.groupBoxStadiu.TabIndex = 1;
            this.groupBoxStadiu.TabStop = false;
            this.groupBoxStadiu.Text = "Editare stadiu";
            // 
            // btnSolutie
            // 
            this.btnSolutie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSolutie.Location = new System.Drawing.Point(21, 149);
            this.btnSolutie.Name = "btnSolutie";
            this.btnSolutie.Size = new System.Drawing.Size(136, 69);
            this.btnSolutie.TabIndex = 34;
            this.btnSolutie.Text = "Adauga/Editeaza solutie";
            this.btnSolutie.UseVisualStyleBackColor = false;
            this.btnSolutie.Click += new System.EventHandler(this.btnSolutie_Click);
            // 
            // btnAsigneazaProg
            // 
            this.btnAsigneazaProg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAsigneazaProg.Location = new System.Drawing.Point(21, 45);
            this.btnAsigneazaProg.Name = "btnAsigneazaProg";
            this.btnAsigneazaProg.Size = new System.Drawing.Size(136, 61);
            this.btnAsigneazaProg.TabIndex = 33;
            this.btnAsigneazaProg.Text = "Asigneaza (alt) programator";
            this.btnAsigneazaProg.UseVisualStyleBackColor = false;
            this.btnAsigneazaProg.Click += new System.EventHandler(this.btnAsigneazaProg_Click);
            // 
            // EditareBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 401);
            this.Controls.Add(this.groupBoxStadiu);
            this.Controls.Add(this.groupBoxEditareDetalii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditareBugs";
            this.Text = "Editare Bug";
            this.Load += new System.EventHandler(this.EditareBugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epContinutText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGravitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDataRaportare)).EndInit();
            this.groupBoxEditareDetalii.ResumeLayout(false);
            this.groupBoxEditareDetalii.PerformLayout();
            this.groupBoxStadiu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epContinutText;
        private System.Windows.Forms.ErrorProvider epGravitate;
        private System.Windows.Forms.ErrorProvider epDataRaportare;
        private System.Windows.Forms.GroupBox groupBoxStadiu;
        private System.Windows.Forms.Button btnSolutie;
        private System.Windows.Forms.Button btnAsigneazaProg;
        private System.Windows.Forms.GroupBox groupBoxEditareDetalii;
        private System.Windows.Forms.Label labelDataRaportare;
        private System.Windows.Forms.DateTimePicker dtpDataRaportare;
        private System.Windows.Forms.ComboBox cbGravitate;
        private System.Windows.Forms.Label labelGravitate;
        private System.Windows.Forms.TextBox tbDescriereProblema;
        private System.Windows.Forms.Label labelDescriereProblema;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox tbTitluProblema;
        private System.Windows.Forms.Label labelTitluProblema;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
    }
}