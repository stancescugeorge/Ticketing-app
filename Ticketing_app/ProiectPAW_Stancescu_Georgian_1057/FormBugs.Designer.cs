namespace ProiectPAW_Stancescu_Georgian_1057
{
    partial class FormBugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBugs));
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.lvBugs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.labelTitluListaBugs = new System.Windows.Forms.Label();
            this.epContinutText = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.epGravitate = new System.Windows.Forms.ErrorProvider(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditeaza = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDetalii = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Programatori = new System.Windows.Forms.ToolStripMenuItem();
            this.Despre = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiBinare = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiXML = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.exportText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetaliiBug = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLabelNrBugs = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnStats = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDragAndDrop = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epContinutText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGravitate)).BeginInit();
            this.cms.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(61, 343);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(151, 50);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga bug";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(61, 408);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(151, 50);
            this.btnCurata.TabIndex = 9;
            this.btnCurata.Text = "Curata formular";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // lvBugs
            // 
            this.lvBugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvBugs.FullRowSelect = true;
            this.lvBugs.HideSelection = false;
            this.lvBugs.Location = new System.Drawing.Point(311, 88);
            this.lvBugs.MultiSelect = false;
            this.lvBugs.Name = "lvBugs";
            this.lvBugs.Size = new System.Drawing.Size(694, 217);
            this.lvBugs.TabIndex = 10;
            this.lvBugs.UseCompatibleStateImageBehavior = false;
            this.lvBugs.View = System.Windows.Forms.View.Details;
            this.lvBugs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvBugs_KeyDown);
            this.lvBugs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvBugs_MouseClick);
            this.lvBugs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvBugs_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr. tichet";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titlu problema";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data raportare";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gravitate";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stadiu";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDataRaportare);
            this.groupBox1.Controls.Add(this.dtpDataRaportare);
            this.groupBox1.Controls.Add(this.cbGravitate);
            this.groupBox1.Controls.Add(this.labelGravitate);
            this.groupBox1.Controls.Add(this.tbDescriereProblema);
            this.groupBox1.Controls.Add(this.labelDescriereProblema);
            this.groupBox1.Controls.Add(this.tbClient);
            this.groupBox1.Controls.Add(this.labelClient);
            this.groupBox1.Controls.Add(this.tbTitluProblema);
            this.groupBox1.Controls.Add(this.labelTitluProblema);
            this.groupBox1.Controls.Add(this.btnCurata);
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 474);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug nou";
            // 
            // labelDataRaportare
            // 
            this.labelDataRaportare.AutoSize = true;
            this.labelDataRaportare.Location = new System.Drawing.Point(15, 279);
            this.labelDataRaportare.Name = "labelDataRaportare";
            this.labelDataRaportare.Size = new System.Drawing.Size(101, 17);
            this.labelDataRaportare.TabIndex = 19;
            this.labelDataRaportare.Text = "Data raportare";
            // 
            // dtpDataRaportare
            // 
            this.dtpDataRaportare.Location = new System.Drawing.Point(18, 299);
            this.dtpDataRaportare.Name = "dtpDataRaportare";
            this.dtpDataRaportare.Size = new System.Drawing.Size(236, 22);
            this.dtpDataRaportare.TabIndex = 18;
            // 
            // cbGravitate
            // 
            this.cbGravitate.FormattingEnabled = true;
            this.cbGravitate.Items.AddRange(new object[] {
            "MEDIU",
            "URGENT",
            "CRITIC"});
            this.cbGravitate.Location = new System.Drawing.Point(18, 252);
            this.cbGravitate.Name = "cbGravitate";
            this.cbGravitate.Size = new System.Drawing.Size(236, 24);
            this.cbGravitate.TabIndex = 17;
            this.cbGravitate.Validating += new System.ComponentModel.CancelEventHandler(this.cbGravitate_Validating);
            this.cbGravitate.Validated += new System.EventHandler(this.cbGravitate_Validated);
            // 
            // labelGravitate
            // 
            this.labelGravitate.AutoSize = true;
            this.labelGravitate.Location = new System.Drawing.Point(15, 232);
            this.labelGravitate.Name = "labelGravitate";
            this.labelGravitate.Size = new System.Drawing.Size(66, 17);
            this.labelGravitate.TabIndex = 16;
            this.labelGravitate.Text = "Gravitate";
            // 
            // tbDescriereProblema
            // 
            this.tbDescriereProblema.Location = new System.Drawing.Point(18, 145);
            this.tbDescriereProblema.Multiline = true;
            this.tbDescriereProblema.Name = "tbDescriereProblema";
            this.tbDescriereProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescriereProblema.Size = new System.Drawing.Size(236, 84);
            this.tbDescriereProblema.TabIndex = 15;
            this.tbDescriereProblema.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescriereProblema_Validating);
            this.tbDescriereProblema.Validated += new System.EventHandler(this.tbDescriereProblema_Validated);
            // 
            // labelDescriereProblema
            // 
            this.labelDescriereProblema.AutoSize = true;
            this.labelDescriereProblema.Location = new System.Drawing.Point(15, 125);
            this.labelDescriereProblema.Name = "labelDescriereProblema";
            this.labelDescriereProblema.Size = new System.Drawing.Size(132, 17);
            this.labelDescriereProblema.TabIndex = 14;
            this.labelDescriereProblema.Text = "Descriere problema";
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(18, 100);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(236, 22);
            this.tbClient.TabIndex = 13;
            this.tbClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbClient_Validating);
            this.tbClient.Validated += new System.EventHandler(this.tbClient_Validated);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(15, 80);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(82, 17);
            this.labelClient.TabIndex = 12;
            this.labelClient.Text = "Nume client";
            // 
            // tbTitluProblema
            // 
            this.tbTitluProblema.Location = new System.Drawing.Point(18, 55);
            this.tbTitluProblema.Name = "tbTitluProblema";
            this.tbTitluProblema.Size = new System.Drawing.Size(236, 22);
            this.tbTitluProblema.TabIndex = 11;
            this.tbTitluProblema.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitluProblema_Validating);
            this.tbTitluProblema.Validated += new System.EventHandler(this.tbTitluProblema_Validated);
            // 
            // labelTitluProblema
            // 
            this.labelTitluProblema.AutoSize = true;
            this.labelTitluProblema.Location = new System.Drawing.Point(15, 32);
            this.labelTitluProblema.Name = "labelTitluProblema";
            this.labelTitluProblema.Size = new System.Drawing.Size(98, 17);
            this.labelTitluProblema.TabIndex = 10;
            this.labelTitluProblema.Text = "Titlu problema";
            // 
            // labelTitluListaBugs
            // 
            this.labelTitluListaBugs.AutoSize = true;
            this.labelTitluListaBugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitluListaBugs.Location = new System.Drawing.Point(590, 56);
            this.labelTitluListaBugs.Name = "labelTitluListaBugs";
            this.labelTitluListaBugs.Size = new System.Drawing.Size(145, 29);
            this.labelTitluListaBugs.TabIndex = 12;
            this.labelTitluListaBugs.Text = "Lista bug-uri";
            // 
            // epContinutText
            // 
            this.epContinutText.ContainerControl = this;
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(342, 327);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(151, 50);
            this.btnEditeaza.TabIndex = 13;
            this.btnEditeaza.Text = "Editeaza bug";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(595, 327);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(151, 50);
            this.btnSterge.TabIndex = 14;
            this.btnSterge.Text = "Sterge bug";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // epGravitate
            // 
            this.epGravitate.ContainerControl = this;
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditeaza,
            this.cmsSterge,
            this.cmsDetalii});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(136, 76);
            // 
            // cmsEditeaza
            // 
            this.cmsEditeaza.Name = "cmsEditeaza";
            this.cmsEditeaza.Size = new System.Drawing.Size(135, 24);
            this.cmsEditeaza.Text = "Editeaza";
            this.cmsEditeaza.Click += new System.EventHandler(this.cmsEditeaza_Click);
            // 
            // cmsSterge
            // 
            this.cmsSterge.Name = "cmsSterge";
            this.cmsSterge.Size = new System.Drawing.Size(135, 24);
            this.cmsSterge.Text = "Sterge";
            this.cmsSterge.Click += new System.EventHandler(this.cmsSterge_Click);
            // 
            // cmsDetalii
            // 
            this.cmsDetalii.Name = "cmsDetalii";
            this.cmsDetalii.Size = new System.Drawing.Size(135, 24);
            this.cmsDetalii.Text = "Detalii";
            this.cmsDetalii.Click += new System.EventHandler(this.cmsDetalii_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Programatori,
            this.Despre,
            this.Exit,
            this.operatiiBinare,
            this.operatiiXML,
            this.exportText});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Programatori
            // 
            this.Programatori.Name = "Programatori";
            this.Programatori.Size = new System.Drawing.Size(109, 24);
            this.Programatori.Text = "Programatori";
            this.Programatori.Click += new System.EventHandler(this.Programatori_Click);
            // 
            // Despre
            // 
            this.Despre.Name = "Despre";
            this.Despre.Size = new System.Drawing.Size(68, 24);
            this.Despre.Text = "Despre";
            this.Despre.Click += new System.EventHandler(this.Despre_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 24);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // operatiiBinare
            // 
            this.operatiiBinare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinara,
            this.deserializareBinara});
            this.operatiiBinare.Name = "operatiiBinare";
            this.operatiiBinare.Size = new System.Drawing.Size(121, 24);
            this.operatiiBinare.Text = "Operatii binare";
            // 
            // serializareBinara
            // 
            this.serializareBinara.Name = "serializareBinara";
            this.serializareBinara.Size = new System.Drawing.Size(170, 26);
            this.serializareBinara.Text = "Serializare";
            this.serializareBinara.Click += new System.EventHandler(this.serializareBinara_Click);
            // 
            // deserializareBinara
            // 
            this.deserializareBinara.Name = "deserializareBinara";
            this.deserializareBinara.Size = new System.Drawing.Size(170, 26);
            this.deserializareBinara.Text = "Deserializare";
            this.deserializareBinara.Click += new System.EventHandler(this.deserializareBinara_Click);
            // 
            // operatiiXML
            // 
            this.operatiiXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareXML,
            this.deserializareXML});
            this.operatiiXML.Name = "operatiiXML";
            this.operatiiXML.Size = new System.Drawing.Size(108, 24);
            this.operatiiXML.Text = "Operatii XML";
            // 
            // serializareXML
            // 
            this.serializareXML.Name = "serializareXML";
            this.serializareXML.Size = new System.Drawing.Size(170, 26);
            this.serializareXML.Text = "Serializare";
            this.serializareXML.Click += new System.EventHandler(this.serializareXML_Click);
            // 
            // deserializareXML
            // 
            this.deserializareXML.Name = "deserializareXML";
            this.deserializareXML.Size = new System.Drawing.Size(170, 26);
            this.deserializareXML.Text = "Deserializare";
            this.deserializareXML.Click += new System.EventHandler(this.deserializareXML_Click);
            // 
            // exportText
            // 
            this.exportText.Name = "exportText";
            this.exportText.Size = new System.Drawing.Size(129, 24);
            this.exportText.Text = "Export fisier text";
            this.exportText.Click += new System.EventHandler(this.exportText_Click);
            // 
            // btnDetaliiBug
            // 
            this.btnDetaliiBug.Location = new System.Drawing.Point(821, 327);
            this.btnDetaliiBug.Name = "btnDetaliiBug";
            this.btnDetaliiBug.Size = new System.Drawing.Size(151, 50);
            this.btnDetaliiBug.TabIndex = 17;
            this.btnDetaliiBug.Text = "Afiseaza detalii bug";
            this.btnDetaliiBug.UseVisualStyleBackColor = true;
            this.btnDetaliiBug.Click += new System.EventHandler(this.btnDetaliiBug_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabelNrBugs});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1017, 25);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip";
            // 
            // stripLabelNrBugs
            // 
            this.stripLabelNrBugs.Name = "stripLabelNrBugs";
            this.stripLabelNrBugs.Size = new System.Drawing.Size(79, 20);
            this.stripLabelNrBugs.Text = "Nr. bugs: 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPrint,
            this.toolStripSeparator1,
            this.toolStripBtnStats,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 27);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnPrint
            // 
            this.toolStripBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrint.Image")));
            this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrint.Name = "toolStripBtnPrint";
            this.toolStripBtnPrint.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnPrint.Text = "Printare (Ctrl + P)";
            this.toolStripBtnPrint.Click += new System.EventHandler(this.toolStripBtnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnStats
            // 
            this.toolStripBtnStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnStats.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStats.Image")));
            this.toolStripBtnStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStats.Name = "toolStripBtnStats";
            this.toolStripBtnStats.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnStats.Text = "Statistici";
            this.toolStripBtnStats.Click += new System.EventHandler(this.toolStripBtnStats_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(595, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 115);
            this.panel1.TabIndex = 20;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelDragAndDrop
            // 
            this.labelDragAndDrop.AutoSize = true;
            this.labelDragAndDrop.Location = new System.Drawing.Point(304, 433);
            this.labelDragAndDrop.Name = "labelDragAndDrop";
            this.labelDragAndDrop.Size = new System.Drawing.Size(285, 34);
            this.labelDragAndDrop.TabIndex = 21;
            this.labelDragAndDrop.Text = "Dragheaza un fisier text ce contine instante \r\nde bug-uri pentru popularea listvi" +
    "ew-ului.";
            // 
            // FormBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 562);
            this.Controls.Add(this.labelDragAndDrop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnDetaliiBug);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.labelTitluListaBugs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvBugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBugs";
            this.Text = "Formular Bug-uri";
            this.Load += new System.EventHandler(this.FormBugs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epContinutText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGravitate)).EndInit();
            this.cms.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ListView lvBugs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGravitate;
        private System.Windows.Forms.Label labelGravitate;
        private System.Windows.Forms.TextBox tbDescriereProblema;
        private System.Windows.Forms.Label labelDescriereProblema;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox tbTitluProblema;
        private System.Windows.Forms.Label labelTitluProblema;
        private System.Windows.Forms.Label labelTitluListaBugs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelDataRaportare;
        private System.Windows.Forms.DateTimePicker dtpDataRaportare;
        private System.Windows.Forms.ErrorProvider epContinutText;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.ErrorProvider epGravitate;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsEditeaza;
        private System.Windows.Forms.ToolStripMenuItem cmsSterge;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Despre;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Programatori;
        private System.Windows.Forms.Button btnDetaliiBug;
        private System.Windows.Forms.ToolStripMenuItem cmsDetalii;
        private System.Windows.Forms.ToolStripMenuItem operatiiBinare;
        private System.Windows.Forms.ToolStripMenuItem serializareBinara;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinara;
        private System.Windows.Forms.ToolStripMenuItem operatiiXML;
        private System.Windows.Forms.ToolStripMenuItem serializareXML;
        private System.Windows.Forms.ToolStripMenuItem deserializareXML;
        private System.Windows.Forms.ToolStripMenuItem exportText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnStats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripLabelNrBugs;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Label labelDragAndDrop;
        private System.Windows.Forms.Panel panel1;
    }
}

