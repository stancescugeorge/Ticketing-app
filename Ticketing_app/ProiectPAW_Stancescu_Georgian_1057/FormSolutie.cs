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
    public partial class FormSolutie : Form
    {
        Bug bug;
        public FormSolutie(Bug bugAles)
        {
            InitializeComponent();
            bug = bugAles;
        }

        private void FormSolutie_Load(object sender, EventArgs e)
        {
            if(bug.Solutie!=null)
            {
                tbCauza.Text = bug.Solutie.Cauza;
                tbDescriere.Text = bug.Solutie.DescriereSol;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (tbCauza.Text.Length < 3 || tbDescriere.Text.Length < 5)
            {
                MessageBox.Show("Exista campuri necompletate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bug.Solutie == null)
                {
                    bug.Solutie = new Solutie();
                    bug.Solutie.DescriereSol = tbDescriere.Text; 
                    bug.Solutie.Cauza = tbCauza.Text;
                    bug.Stadiu = Stadiu.REZOLVAT;
                }
                 else
                 {

                    bug.Solutie.DescriereSol = tbDescriere.Text;
                    bug.Solutie.Cauza = tbCauza.Text;
 
                 }
               
                this.Close();
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca stergeti solutia?", "Sterge solutia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bug.Solutie = null;
                bug.Stadiu = Stadiu.IN_CURS;
                this.Close();
            }
        }

        #region Error Providers
        private void tbCauza_Validating(object sender, CancelEventArgs e)
        {
            if(tbCauza.Text.Length<3)
            {
                epContinut.SetError(tbCauza, "Introduceti minim 3 caractere!");
                e.Cancel = true;
            }
        }

        private void tbCauza_Validated(object sender, EventArgs e)
        {
            epContinut.Clear();
        }

        private void tbDescriere_Validating(object sender, CancelEventArgs e)
        {
            if (tbDescriere.Text.Length < 5 || tbDescriere.Text.Length>250)
            {
                epContinut.SetError(tbDescriere, "Introduceti un text de 5 - 250 caractere!");
                e.Cancel = true;
            }
        }

        private void tbDescriere_Validated(object sender, EventArgs e)
        {
            epContinut.Clear();
        }
        #endregion

    }
}
