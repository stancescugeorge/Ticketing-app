using ProiectPAW_Stancescu_Georgian_1057.Clase;
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
    public partial class FormAsignareProgramator : Form
    {
        List<Programator> listaProgramatori;
        Bug bug;
        public FormAsignareProgramator(Bug bugSelectat,List<Programator> lista)
        {
            InitializeComponent();

            listaProgramatori = lista;
            bug = bugSelectat;
            populeazaListView();
        }

        public void populeazaListView()
        {
            lvProgramatori.Items.Clear();
            foreach (Programator each in listaProgramatori)
            {
                ListViewItem item = new ListViewItem(new String[] {each.Id.ToString(), each.Nume, each.Prenume, each.Email,
                    each.Telefon, each.Functie.ToString() });
                lvProgramatori.Items.Add(item);
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (lvProgramatori.SelectedItems.Count != 0)
            {
                bug.ProgramatorId = listaProgramatori.ElementAt(lvProgramatori.SelectedIndices[0]).Id;
                bug.Stadiu = Stadiu.IN_CURS;

                this.Close();
            }
            else MessageBox.Show("Niciun programator selectat!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
