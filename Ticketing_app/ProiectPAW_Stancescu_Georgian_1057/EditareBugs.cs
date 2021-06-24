using ProiectPAW_Stancescu_Georgian_1057.Clase;
using ProiectPAW_Stancescu_Georgian_1057.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Stancescu_Georgian_1057
{
    public partial class EditareBugs : Form
    {
        List<Programator> listaProgramatori;
        EF_AppContext ctx;
        Bug bug;
        public EditareBugs(Bug bugAles, EF_AppContext context)
        {
            InitializeComponent();
            bug = bugAles;
            ctx = context;
            listaProgramatori = ctx.Programatori.ToList();
            listaProgramatori.RemoveAt(0);

        }

        private void EditareBugs_Load(object sender, EventArgs e)
        {
            tbTitluProblema.Text = bug.TitluProblema;
            tbClient.Text = bug.Client;
            tbDescriereProblema.Text = bug.DescriereProblema;
            cbGravitate.Text = bug.Gravitate.ToString();
            dtpDataRaportare.Value = bug.DataRaportare;

        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            bug.TitluProblema=tbTitluProblema.Text;
            bug.Client=tbClient.Text;
            bug.DescriereProblema = tbDescriereProblema.Text;

            Enum.TryParse(cbGravitate.Text, out Gravitate gravitate);
            bug.Gravitate = gravitate;

            bug.DataRaportare = dtpDataRaportare.Value;

            ctx.Bugs.Update(bug);
            ctx.SaveChanges();

            this.Close();
        }

        private void btnAsigneazaProg_Click(object sender, EventArgs e)
        {
           this.Hide();

            FormAsignareProgramator formularAsignare = new FormAsignareProgramator(bug,listaProgramatori);
            formularAsignare.ShowDialog();

            ctx.Bugs.Update(bug);
            ctx.SaveChanges();

            this.Close();
        }

        private void btnSolutie_Click(object sender, EventArgs e)
        {
            if(bug.ProgramatorId==1) //primul element din programatori e mereu cel fals
            {
                MessageBox.Show("Asignati mai intai un programator!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               this.Hide();
                
                FormSolutie formSolutie = new FormSolutie(bug);
                formSolutie.ShowDialog();

                //ctx.Bugs.Update(bug);
                //ctx.SaveChanges();

                this.Close();
                
            }
        }

        #region Error Providers
        private void tbTitluProblema_Validating(object sender, CancelEventArgs e)
        {
            String titlu = tbTitluProblema.Text;
            if (String.IsNullOrEmpty(titlu) || String.IsNullOrWhiteSpace(titlu) || titlu.Length < 3)
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
            if (String.IsNullOrEmpty(descriere) || String.IsNullOrWhiteSpace(descriere) || descriere.Length < 5 || descriere.Length > 250)
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
            if (cbGravitate.SelectedIndex == -1)
            {
                epGravitate.SetError(cbGravitate, "Selectati o optiune!");
                e.Cancel = true;
            }
        }

        private void cbGravitate_Validated(object sender, EventArgs e)
        {
            epGravitate.Clear();
        }

        private void dtpDataRaportare_Validating(object sender, CancelEventArgs e)
        {
            DateTime data = dtpDataRaportare.Value;
            if (DateTime.Compare(data, DateTime.Now) > 0)
            {
                epDataRaportare.SetError((Control)sender, "Data raportarii este cel mult data curenta!");
                e.Cancel = true;
            }
        }

        private void dtpDataRaportare_Validated(object sender, EventArgs e)
        {
            epDataRaportare.Clear();
        }


        #endregion

       
    }
}
