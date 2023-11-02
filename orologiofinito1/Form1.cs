using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orologiofinito1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime ora = DateTime.Now;
        double asspostato = 0;
        double amspostato = 0;
        double ahspostato = 0;
        float xsprecedente = 0;
        float ysprecedente = 0;
        float xmprecedente = 0;
        float ymprecedente = 0;
        float xhprecedente = 0;
        float yhprecedente = 0;
        int giro1s = 0;
        int giro1m = 0;
        int giro1h = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Graphics msh = this.CreateGraphics();

            int x = (ClientSize.Width - (ClientSize.Height * 3 / 4)) / 2;
            int y = (ClientSize.Height - (ClientSize.Height * 3 / 4)) / 2;

            for (int i = 0; i < 3; i++)
            {
                g.DrawEllipse(Pens.Black, x - i, y - i, ClientSize.Height * 3 / 4 + 2 * i, ClientSize.Height * 3 / 4 + 2 * i);
            }
            g.FillEllipse(Brushes.Black, ((ClientSize.Width - (20)) / 2), (ClientSize.Height - (20)) / 2, 20, 20);
            double raggio = ((ClientSize.Height * 3 / 4)) / 2;
            double lancettas = raggio * 4 / 5;
            double lancettam = raggio * 2 / 3;
            double lancettah = raggio * 1 / 2;
            p12.Left = ClientSize.Width / 2 - p12.Width / 2;
            p12.Top = ClientSize.Height / 2 - ((int)raggio);
            p6.Left = ClientSize.Width / 2 - p12.Width / 2;
            p6.Top = ClientSize.Height / 2 + ((int)raggio - p6.Height);
            p3.Left = ClientSize.Width / 2 + ((int)raggio - p6.Width);
            p3.Top = ClientSize.Height / 2 - p12.Width / 2;
            p9.Left = ClientSize.Width / 2 - ((int)raggio);
            p9.Top = ClientSize.Height / 2 - p12.Width / 2;

            float secondi = 0;


            if (giro1s == 0)
            {
                secondi = ora.Second;
            }


            double angolos = (((double)((-1 * ((secondi / 60) * 360)) + 90) - asspostato) * Math.PI) / 180;
            double cos = Math.Round(Math.Cos(angolos), 1);
            double sin = Math.Round(Math.Sin(angolos), 1);
            float xs = (float)((lancettas * cos));
            float ys = (float)(lancettas * sin);

            msh.DrawLine(Pens.White, ClientSize.Width / 2, ClientSize.Height / 2, xsprecedente + ClientSize.Width / 2, ClientSize.Height / 2 - ysprecedente);
            msh.DrawLine(Pens.IndianRed, ClientSize.Width / 2, ClientSize.Height / 2, xs + ClientSize.Width / 2, ClientSize.Height / 2 - ys);

            asspostato = 1 * 360 / 60 + asspostato;


            float minuti = 0;
            float minsectot = 0;
            if (giro1m == 0)
            {
                minuti = ora.Minute;
                minsectot = minuti * 60 + ora.Second;
            }
            double angolom = (((double)(-1 * ((minsectot / 3600) * 360) + 90) - amspostato) * Math.PI) / 180;
            double cosm = Math.Round(Math.Cos(angolom), 1);
            double sinm = Math.Round(Math.Sin(angolom), 1);
            float xm = (float)((lancettam * cosm));
            float ym = (float)(lancettam * sinm);
            for (int i = 0; i < 3; i++)
            {
                msh.DrawLine(Pens.White, ClientSize.Width / 2 + i, ClientSize.Height / 2 + i, xmprecedente + ClientSize.Width / 2 + i, ClientSize.Height / 2 - ymprecedente + i);
                msh.DrawLine(Pens.Black, ClientSize.Width / 2 + i, ClientSize.Height / 2 + i, xm + ClientSize.Width / 2 + i, ClientSize.Height / 2 - ym + i);
            }
            amspostato = 1 * 360 / 3600 + amspostato;


            float ore = 0;
            float oreminsectot = 0;
            if (giro1h == 0)
            {
                ore = ora.Hour;
                oreminsectot = ore * 60 * 60 + ora.Minute * 60 + ora.Second;
            }

            double angoloh = (((double)(-1 * ((oreminsectot / 43200) * 360) + 90) - ahspostato) * Math.PI) / 180;
            double cosh = Math.Round(Math.Cos(angoloh), 1);
            double sinh = Math.Round(Math.Sin(angoloh), 1);
            float xh = (float)((lancettah * cosh));
            float yh = (float)(lancettah * sinh);
            for (int i = 0; i < 5; i++)
            {
                msh.DrawLine(Pens.White, ClientSize.Width / 2 + i, ClientSize.Height / 2 + i, xhprecedente + ClientSize.Width / 2 + i, ClientSize.Height / 2 - yhprecedente + i);
                msh.DrawLine(Pens.Black, ClientSize.Width / 2 + i, ClientSize.Height / 2 + i, xh + ClientSize.Width / 2 + i, ClientSize.Height / 2 - yh + i);
            }
            ahspostato = 1 * 360 / 43200 + ahspostato;

            xsprecedente = xs;
            ysprecedente = ys;
            xmprecedente = xm;
            ymprecedente = ym;
            xhprecedente = xh;
            yhprecedente = yh;

            if (angolos == -(270 * Math.PI / 180))
            {
                giro1s = 1;
                asspostato = 1 * 360 / 60;
            }
            if (angolom == -(270 * Math.PI / 180))
            {
                giro1m = 1;
                amspostato = 1 * 360 / 3600;
            }
            if (angoloh == -(270 * Math.PI / 180))
            {
                giro1h = 1;
                ahspostato = 1 * 360 / 43200;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
