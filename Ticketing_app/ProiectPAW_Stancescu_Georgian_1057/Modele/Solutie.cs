using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Stancescu_Georgian_1057.Clase
{
    [Serializable]
    public class Solutie
    {
        public int Id { get; set;} //pk

        public String DescriereSol { get; set; }
        
        public String Cauza { get; set; }
       
        public DateTime DataSol { get; set; }
      
        public int BugId { get; set; } //fk

        public Solutie(string descriere, string cauza)
        {
            this.DescriereSol = descriere;
            this.Cauza = cauza;
            this.DataSol = DateTime.Now;
        }

        public Solutie() { this.DataSol = DateTime.Now; }



    }
}
