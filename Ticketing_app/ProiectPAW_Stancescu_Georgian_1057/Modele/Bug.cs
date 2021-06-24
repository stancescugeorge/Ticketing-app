using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Stancescu_Georgian_1057.Clase
{
    [Serializable]
    public class Bug
    {
       
       public int Id { get; set; }

        public String TitluProblema { get; set; }

        public String Client { get; set; }
       
        public String DescriereProblema { get; set; }

        private DateTime _DataRaportare;
        public DateTime DataRaportare
        {
            get
            {
                return _DataRaportare;
            }
            set
            {
                if (DateTime.Compare(value, DateTime.Now) > 0|| value.Year<(DateTime.Now.Year-1))
                {
                    throw new CustomExceptionDataRaportare();
                }
                else _DataRaportare = value;
            }
        }

        public int ProgramatorId{ get; set; }
        public Solutie Solutie { get; set; }

        public Gravitate Gravitate { get; set; }
        public Stadiu Stadiu { get; set; }

        public Bug() { }

        public Bug(String titlu, String client, String descriere, Gravitate gravitate, DateTime dataRaportare)
        {
            this.TitluProblema = titlu;
            this.Client = client;
            this.DescriereProblema = descriere;
            this.DataRaportare = dataRaportare;
            this.Stadiu = Stadiu.NEREZOLVAT;
            this.ProgramatorId = 1;
            this.Solutie = null;
            this.Gravitate = gravitate;
        }
    }

    public enum Gravitate
    {
        MEDIU,
        URGENT,
        CRITIC
    }

    public enum Stadiu
    {
        REZOLVAT,
        NEREZOLVAT,
        IN_CURS
    }
}
