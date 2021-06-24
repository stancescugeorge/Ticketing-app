using ProiectPAW_Stancescu_Georgian_1057.Clase;
using ProiectPAW_Stancescu_Georgian_1057.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectPAW_Stancescu_Georgian_1057
{
    public partial class FormBugs : Form
    {
        EF_AppContext ctx = new EF_AppContext();

        List<Bug> listaBugs = new List<Bug>();
        public FormBugs()
        {
            InitializeComponent();
        }

        private void FormBugs_Load(object sender, EventArgs e)
        {
           
            listaBugs = ctx.Bugs.ToList();
            if (ctx.Programatori.ToList().Count == 0)
                ctx.Add(new Programator("necunoscut")); //nu am pus conditie de foreign key nullable la generare bd, asa ca voi folosi un programator fals
            ctx.SaveChanges();
            populeazaListView();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            String titluProb = tbTitluProblema.Text;
            String client = tbClient.Text;
            String descriereProb = tbDescriereProblema.Text;
            String gravitateSelectata = cbGravitate.Text;
            DateTime dataRaportare = dtpDataRaportare.Value.Date;

            Enum.TryParse(gravitateSelectata, out Gravitate gravitate);


            if (String.IsNullOrEmpty(titluProb) || String.IsNullOrEmpty(client) || String.IsNullOrEmpty(descriereProb) ||
             String.IsNullOrEmpty(gravitateSelectata))
            {
                MessageBox.Show("Exista campuri necompletate!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Bug bug = new Bug(titluProb, client, descriereProb, gravitate, dataRaportare);
                    bug.ProgramatorId = (ctx.Programatori.First() as Programator).Id; //sau =1
                    //orice bug adaugat este inca nerezolvat si in mod normal nu are programator asignat si nici solutie
                    //pentru a evita exceptia aruncata de fk nula, toate bug-urile nerezolvate vor fi asociate programatorului fictiv necunoscut

                    ctx.Bugs.Add(bug);
                    ctx.SaveChanges();

                    listaBugs.Add(bug);

                    populeazaListView();
                    curataCampuri();
                }
                catch (CustomExceptionDataRaportare ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvBugs.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doriti sa stergeti bug-ul?", "Sterge bug", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Bug bug = listaBugs.ElementAt(lvBugs.SelectedIndices[0]);
                    listaBugs.RemoveAt(lvBugs.SelectedIndices[0]);
                    ctx.Bugs.Remove(bug);
                    ctx.SaveChanges();
                    populeazaListView();
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvBugs.SelectedItems.Count != 0)
            {
                Bug bug = listaBugs.ElementAt(lvBugs.SelectedIndices[0]);

                EditareBugs editare = new EditareBugs(bug,ctx);
                editare.ShowDialog();

                populeazaListView();
            }
            else MessageBox.Show("Selectati un bug din lista!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDetaliiBug_Click(object sender, EventArgs e)
        {
            if(lvBugs.SelectedItems.Count!=0)
            {
                Bug bug = listaBugs.ElementAt(lvBugs.SelectedIndices[0]);

                FormDetaliiBug formDetalii = new FormDetaliiBug(bug);
                formDetalii.ShowDialog();
            }

        }

        private void curataCampuri()
        {
            tbTitluProblema.Clear();
            tbClient.Clear();
            tbDescriereProblema.Clear();

            cbGravitate.SelectedIndex = -1;

            dtpDataRaportare.Value = DateTime.Now;
        }

        private void populeazaListView()
        {
            lvBugs.Items.Clear();

            foreach (Bug each in listaBugs)
            {
                ListViewItem item = new ListViewItem(new String[] { each.Id.ToString(), each.TitluProblema, each.DataRaportare.ToString("dd/MM/yyyy"),
                    each.Gravitate.ToString(), each.Stadiu.ToString() });
                lvBugs.Items.Add(item);
            }

            stripLabelNrBugs.Text = "Nr. bugs: " + lvBugs.Items.Count;
        }


#region Error providers
        private void tbTitluProblema_Validating(object sender, CancelEventArgs e)
        {
            String titlu = tbTitluProblema.Text;
            if(String.IsNullOrEmpty(titlu)||String.IsNullOrWhiteSpace(titlu)||titlu.Length<3)
            {
                epContinutText.SetError(tbTitluProblema, "Introduceti minim 3 caractere!");
                e.Cancel = true;
            }
            
        }

        private void tbTitluProblema_Validated(object sender, EventArgs e)
        {
            epContinutText.Clear();
        }

        private void tbClient_Validating(object sender, CancelEventArgs e)
        {
            String client = tbClient.Text;
            if (String.IsNullOrEmpty(client) || String.IsNullOrWhiteSpace(client) || client.Length < 2)
            {
                epContinutText.SetError(tbClient, "Introduceti minim 2 caractere!");
                e.Cancel = true;
            }
        }

        private void tbClient_Validated(object sender, EventArgs e)
        {
            epContinutText.Clear();
        }

        private void tbDescriereProblema_Validating(object sender, CancelEventArgs e)
        {
            String descriere = tbDescriereProblema.Text;
            if (String.IsNullOrEmpty(descriere) || String.IsNullOrWhiteSpace(descriere) || descriere.Length < 5|| descriere.Length > 250)
            {
                epContinutText.SetError(tbDescriereProblema, "Introduceti un text de 5-250 caractere!");
                e.Cancel = true;
            }
        }

        private void tbDescriereProblema_Validated(object sender, EventArgs e)
        {
            epContinutText.Clear();
        }

        private void cbGravitate_Validating(object sender, CancelEventArgs e)
        {
            if(cbGravitate.SelectedIndex==-1)
            {
                epGravitate.SetError(cbGravitate, "Selectati o optiune!");
                e.Cancel = true;
            }
        }

        private void cbGravitate_Validated(object sender, EventArgs e)
        {
            epGravitate.Clear();
        }
        #endregion

        //Context Menu Strip 
        private void cmsEditeaza_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void cmsSterge_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void cmsDetalii_Click(object sender, EventArgs e)
        {
            btnDetaliiBug_Click(sender, e);
        }

        private void lvBugs_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        //alt shortcuts 
        private void lvBugs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && e.Control)
                btnSterge_Click(sender, e);
            else
                if (e.KeyCode == Keys.E && e.Control)
                btnEditeaza_Click(sender, e);
            else 
                if (e.KeyCode == Keys.I && e.Control)
                btnDetaliiBug_Click(sender, e);
            else
                 if (e.KeyCode == Keys.P && e.Control)
            {
                toolStripBtnPrint_Click(sender, e);
            }
        }


        //double click 
        private void lvBugs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
             lvBugs.FocusedItem.Bounds.Contains(e.Location.X, e.Location.Y))
            {
                btnDetaliiBug_Click(sender, e);
            }
        }


        //Menu Strip (Menu Bar)
        private void Despre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stancescu Georgian-Constantin, grupa 1057");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Programatori_Click(object sender, EventArgs e)
        {
            FormProgrammers formProg = new FormProgrammers();
            formProg.ShowDialog();
            listaBugs = ctx.Bugs.ToList(); //in cazul in care este sters un programator sunt sterse din bd si bug-urile asignate lui
            populeazaListView();
        }


        //Serializare/Deserializare
        private void serializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream stream = new FileStream("binary.dat", FileMode.Create);
            binaryFormatter.Serialize(stream, listaBugs);

            stream.Close();
            MessageBox.Show("Fisierul binary.dat salvat cu succes");
        }

        private void deserializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Selecteaza fisierul binar pentru deserializare";
            ofd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(ofd.FileName);
                List<Bug> listaExtrasa = binaryFormatter.Deserialize(fs) as List<Bug>;

                foreach(Bug bug in listaExtrasa)
                {
                    bug.Id = 0;
                    ctx.Bugs.Add(bug);
                    ctx.SaveChanges();
                }

                fs.Close();
                listaBugs = ctx.Bugs.ToList();
                populeazaListView();
            }
        }

        private void serializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bug>));

            FileStream fs = File.Create("lista.xml");
            serializer.Serialize(fs, listaBugs);

            fs.Close();
            MessageBox.Show("Fisierul lista.xml salvat cu succes");
        }

        private void deserializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bug>));

            try
            {
                FileStream fs = File.OpenRead("lista.xml");

                List<Bug> listaExtrasa = serializer.Deserialize(fs) as List<Bug>;
                foreach (Bug bug in listaExtrasa)
                {
                    bug.Id = 0;
                    ctx.Bugs.Add(bug);
                    ctx.SaveChanges();
                }
                fs.Close();

                listaBugs = ctx.Bugs.ToList();
                populeazaListView();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Export txt
        private void exportText_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Bug each in listaBugs)
                {
                    sw.Write(each.TitluProblema + ", " +each.Client+","+ each.DataRaportare.ToString() + ", " + each.Gravitate.ToString() +  "\n");
                }
                sw.Close();
            }
        }


        //printare
        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Calibri", 14);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }

            int cellWidth = totalDrawableW / 4;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("   Lista Bugs ", font, brush, totalDrawableW / 2, y);
            y += 100;

            //cap tabel 
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth*2, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth*3, y, cellWidth, cellHeight);

            graphics.DrawString("Nr. tichet", font, brush, x, y);
            graphics.DrawString("Titlu problema", font, brush, x + cellWidth, y);
            graphics.DrawString("Stadiu", font, brush, x + cellWidth*3, y);

            y += cellHeight;

            foreach(Bug b in listaBugs)
            {
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth*2, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth * 3, y, cellWidth, cellHeight);

                graphics.DrawString(b.Id.ToString(), font, brush, x, y);
                graphics.DrawString(b.TitluProblema, font, brush, x + cellWidth, y);
                graphics.DrawString(b.Stadiu.ToString(), font, brush, x + cellWidth * 3, y);

                y += cellHeight;
            }
        }


        //drag and drop
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            foreach(String path in filePaths)
            {
                string[] content = File.ReadAllLines(path);

                foreach (String line in content)
                {
                    Bug bug = new Bug();
                    string[] tokens = line.Split(',');

                    bug.TitluProblema = tokens[0];
                    bug.Client = tokens[1];

                    DateTime.TryParse(tokens[2], out DateTime data);
                    bug.DataRaportare = data;

                    Enum.TryParse(tokens[3], out Gravitate gr);
                    bug.Gravitate = gr;

                    bug.Stadiu = Stadiu.NEREZOLVAT;
                    bug.ProgramatorId = 1;                 
                    bug.DescriereProblema = " - ";

                    ctx.Bugs.Add(bug);
                    ctx.SaveChanges();
                    listaBugs.Add(bug);
                }
                populeazaListView();
            }
                
        }



        //desenare grafic (pie chart) + utilizare user control
        private void toolStripBtnStats_Click(object sender, EventArgs e)
        {
            BarChartForm chart = new BarChartForm(listaBugs);
            chart.ShowDialog();
        }
    }
}
