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
    public partial class FormProgrammers : Form
    {
        EF_AppContext ctx = new EF_AppContext();
        List<Programator> listaProgramatori;
        public FormProgrammers()
        {
            InitializeComponent();

            listaProgramatori = ctx.Programatori.ToList();
            listaProgramatori.RemoveAt(0); //primul programator din lista este intotdeauna cel fals, nu poate fi selectat
            populeazaListView();
        }
        
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNume.Text) || String.IsNullOrEmpty(tbPrenume.Text) || String.IsNullOrEmpty(tbTelefon.Text)
                || String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(cbFunctie.Text))
            {
                MessageBox.Show("Exista campuri necompletate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nume = tbNume.Text;
                String prenume = tbPrenume.Text;
                String email = tbEmail.Text;
                String telefon = tbTelefon.Text;
                String functieAleasa = cbFunctie.Text;

                Enum.TryParse(functieAleasa, out Functie functie);

                Programator programator = new Programator(nume, prenume, email, telefon, functie);
                listaProgramatori.Add(programator);

                ctx.Programatori.Add(programator);
                ctx.SaveChanges();

                populeazaListView();
                curataCampuri();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvProgramatori.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doriti sa stergeti programatorul? Vor fi sterse si bug-urile asignate lui!", "Sterge programator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Programator prog = listaProgramatori.ElementAt(lvProgramatori.SelectedIndices[0]);
                    listaProgramatori.RemoveAt(lvProgramatori.SelectedIndices[0]);
                    ctx.Programatori.Remove(prog);
                    ctx.SaveChanges();
                    populeazaListView();
                }
            }
        }


        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if(lvProgramatori.SelectedItems.Count!=0)
            {
                Programator programator = listaProgramatori.ElementAt(lvProgramatori.SelectedIndices[0]);

                EditareProgramator editare = new EditareProgramator(programator);
                editare.ShowDialog();

                ctx.Programatori.Update(programator);
                ctx.SaveChanges();

                populeazaListView();
            }
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void populeazaListView()
        {
            lvProgramatori.Items.Clear();
            foreach(Programator each in listaProgramatori)
            {
                ListViewItem item = new ListViewItem(new String[] {each.Id.ToString(), each.Nume, each.Prenume, each.Email,
                    each.Telefon, each.Functie.ToString() });
                lvProgramatori.Items.Add(item);
            }
        }
        public void curataCampuri()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbEmail.Clear();
            tbTelefon.Clear();
            cbFunctie.SelectedIndex = -1;
        }


        #region Error Providers
        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(tbNume.Text)||String.IsNullOrWhiteSpace(tbNume.Text)||tbNume.Text.Length<3)
            {
                epNumePrenume.SetError(tbNume, "Introduceti minim 3 caractere!");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNumePrenume.Clear();
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPrenume.Text) || String.IsNullOrWhiteSpace(tbPrenume.Text) || tbPrenume.Text.Length < 3)
            {
                epNumePrenume.SetError(tbPrenume, "Introduceti minim 3 caractere!");
                e.Cancel = true;
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epNumePrenume.Clear();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrWhiteSpace(tbEmail.Text) || tbEmail.Text.Length < 5)
            {
                epEmail.SetError(tbEmail, "Email-ul are minim 5 caractere si contine @!");
                e.Cancel = true;
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            epEmail.Clear();
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbTelefon.Text) || String.IsNullOrWhiteSpace(tbTelefon.Text) || tbTelefon.Text.Length != 10)
            {
                epTelefon.SetError(tbTelefon, "Telefonul este format din 10 cifre!");
                e.Cancel = true;
            }
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            epTelefon.Clear();
        }

        private void cbFunctie_Validating(object sender, CancelEventArgs e)
        {
            if(cbFunctie.SelectedIndex==-1)
            {
                epFunctie.SetError(cbFunctie, "Selectati o optiune!");
                e.Cancel = true;
            }
        }

        private void cbFunctie_Validated(object sender, EventArgs e)
        {
            epFunctie.Clear();
        }

        #endregion

       
    }
}
