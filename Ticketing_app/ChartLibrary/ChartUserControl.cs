using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLibrary
{
    public partial class ChartUserControl : UserControl
    {
       List<String> listaLocala = new List<string>();

        public ChartUserControl(List<string> lista)
        {
            InitializeComponent();

            ResizeRedraw = true;

            listaLocala = lista;

        }

        private void ChartUserControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;

            var xCoord = rectangle.Width - 300;
            var yCoord = 0;

            int[] date = new int[listaLocala.Count];
            int total = 0;

            Color[] culori = new Color[listaLocala.Count];
            Random rnd = new Random();

            for (int i = 0; i < listaLocala.Count; i++)
            {
                culori[i] = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                string[] tokens = listaLocala.ElementAt(i).Split(',');

                graphics.FillRectangle(new SolidBrush(culori[i]), xCoord, yCoord, 20, 20);

                graphics.DrawString(tokens[0] + ": " + tokens[1], new Font("Calibri", 10),
                    new SolidBrush(culori[i]), xCoord + 25, yCoord);

                date[i] = int.Parse(tokens[1]);
                total += date[i];

                yCoord += 35;
            }

            float procent = (float)100.0 / total;
            float[] procente = new float[listaLocala.Count];
            for (int i = 0; i < listaLocala.Count; i++)
                procente[i] = date[i] * procent;

            Point myPieLocation = new Point(10, 10);
            Size myPieSize = new Size(250, 250);
            DrawPieChart(procente, culori, graphics, myPieLocation, myPieSize);

        }

        private void DrawPieChart(float[] procente, Color[] myPieColors, Graphics myPieGraphic, Point
      myPieLocation, Size myPieSize)
        { 
            float PiePercentTotal = 0;
            for (int PiePercents = 0; PiePercents < procente.Length; PiePercents++)
            {
                SolidBrush brush = new SolidBrush(myPieColors[PiePercents]);
                myPieGraphic.FillPie(brush, new Rectangle(new Point(10, 10), myPieSize), Convert.ToSingle(PiePercentTotal * 360 / 100), Convert.ToSingle(procente[PiePercents] * 360 / 100));
                
                PiePercentTotal += procente[PiePercents];
            }
            return;
        }
    }
}
