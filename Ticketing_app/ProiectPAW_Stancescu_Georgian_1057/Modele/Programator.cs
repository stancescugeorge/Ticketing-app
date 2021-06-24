using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Stancescu_Georgian_1057.Clase
{
    [Serializable]
    public class Programator
    {
        public int Id { get; set; }
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public String Email { get; set; }
        public String Telefon { get; set; }
        public Functie Functie { get; set; }

        public List<Bug> Bugs { get; set; }

        public Programator(string nume,string prenume,string email,string telefon,Functie functie)
        {
            this.Nume=nume;
            this.Prenume=prenume;
            this.Email=email;
            this.Telefon=telefon;
            this.Functie = functie;
        }

        public Programator() { }

        public Programator(string nume)
        {
            this.Nume = nume;
        }
   
    }

    public enum Functie
    {
        Intern, 
        Junior_Dev,
        Developer,
        Senior_arch
        
    }
}
