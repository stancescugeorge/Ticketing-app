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
    public partial class FormDetaliiBug : Form
    {
       // EF_AppContext ctx = new EF_AppContext();
        Bug bug;
        public FormDetaliiBug(Bug bugAles)
        {
            InitializeComponent();
            bug=bugAles;
        }

        private void FormDetaliiBug_Load(object sender, EventArgs e)
        {
            tbDetalii.AppendText("Nr. tichet: " + bug.Id);
            tbDetalii.AppendText(Environment.NewLine+"Titlu problema: " + bug.TitluProblema);
            tbDetalii.AppendText(Environment.NewLine + "Data raportare: " + bug.DataRaportare.ToString("dd/MM/yyyy"));
            tbDetalii.AppendText(Environment.NewLine + "Nume client: " + bug.Client);
            tbDetalii.AppendText(Environment.NewLine + "Descriere problema: " + bug.DescriereProblema);
            tbDetalii.AppendText(Environment.NewLine + "Gravitate: " + bug.Gravitate.ToString());
            tbDetalii.AppendText(Environment.NewLine + "Stadiu: " + bug.Stadiu.ToString());
            if(bug.Stadiu==Stadiu.NEREZOLVAT)
            {
                tbDetalii.AppendText(Environment.NewLine + "Programator asignat: - ");
                tbDetalii.AppendText(Environment.NewLine + "Solutie: - ");
            }
            else
            {
                tbDetalii.AppendText(Environment.NewLine + "ID Programator asignat: "//+ nume + " " + bug.Programator.Prenume
                    + bug.ProgramatorId.ToString());
                if(bug.Stadiu==Stadiu.REZOLVAT && bug.Solutie!=null)
                {
                    tbDetalii.AppendText(Environment.NewLine+Environment.NewLine + "SOLUTIE - "+bug.Solutie.DataSol.ToString("dd/MM/yyyy HH:mm"));
                    tbDetalii.AppendText(Environment.NewLine + "Cauza problemei: "+bug.Solutie.Cauza);
                    tbDetalii.AppendText(Environment.NewLine + "Descriere solutie: " + bug.Solutie.DescriereSol);
                }
                else tbDetalii.AppendText(Environment.NewLine + "Solutie: - ");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
