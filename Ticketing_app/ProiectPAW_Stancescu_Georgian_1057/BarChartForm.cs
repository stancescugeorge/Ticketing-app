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
    public partial class BarChartForm : Form
    {
        public BarChartForm(List<Bug> lista)
        {
            InitializeComponent();

            List<String> listaPrelucrata = new List<string>();
            int rezolvate = 0, inCurs = 0, nerezolvate = 0;
            foreach (Bug bug in lista)
            {
                if (bug.Stadiu == Stadiu.IN_CURS) inCurs++;
                else if (bug.Stadiu == Stadiu.REZOLVAT) rezolvate++;
                else nerezolvate++;
            }

            listaPrelucrata.Add("Bug-uri rezolvate," + rezolvate);
            listaPrelucrata.Add("Bug-uri nerezolvate," + nerezolvate);
            listaPrelucrata.Add("Bug-uri in curs de rezolvare," + inCurs);

           
            ChartLibrary.ChartUserControl barchart1 = new ChartLibrary.ChartUserControl(listaPrelucrata);
            barchart1.Location = new System.Drawing.Point(12, 12);

            barchart1.Name = "barChart1";
            barchart1.Size = new System.Drawing.Size(794, 426);
            barchart1.TabIndex = 0;

            this.Controls.Add(barchart1);
        }
    }
}
