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
    public partial class EditareProgramator : Form
    {
        Programator _instance;
        public EditareProgramator(Programator programator)
        {
            InitializeComponent();

            _instance = programator;
        }

        private void EditareProgramator_Load(object sender, EventArgs e)
        {
            tbNume.Text = _instance.Nume;
            tbPrenume.Text = _instance.Prenume;
            tbEmail.Text = _instance.Email;
            tbTelefon.Text = _instance.Telefon;
            cbFunctie.Text = _instance.Functie.ToString();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNume.Text) || tbNume.Text.Length<3|| String.IsNullOrEmpty(tbPrenume.Text) || tbPrenume.Text.Length < 3||
                String.IsNullOrEmpty(tbTelefon.Text)||tbTelefon.Text.Length!=10|| String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(cbFunctie.Text))
            {
                MessageBox.Show("Exista campuri completate gresit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _instance.Nume=tbNume.Text;
                _instance.Prenume=tbPrenume.Text;
                _instance.Telefon=tbTelefon.Text;
                _instance.Email=tbEmail.Text;
                Enum.TryParse(cbFunctie.Text, out Functie functie);
                _instance.Functie = functie;


                this.Close();
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
