using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace f_x__maker
{
    public partial class Instrukcja : Form
    {
        public Instrukcja()
        {
            InitializeComponent();
            wymiarowanie();
            this.ActiveControl = obrazek1;
            obrazek1.Focus();
        }

        public void wymiarowanie()
        {
            float wysokoscGlowna = this.Height;
            float szerokoscGlowna = this.Width;
            //MessageBox.Show(wysokoscGlowna + "vs" + szerokoscGlowna);
            szerokoscGlowna = Screen.PrimaryScreen.WorkingArea.Size.Width;
            wysokoscGlowna = Screen.PrimaryScreen.WorkingArea.Size.Height;
            //MessageBox.Show(wysokoscGlowna + "vs" + szerokoscGlowna);
            panelGlowny.Width = (int)(0.8 * szerokoscGlowna);
            panelGlowny.Height = (int)(0.8 * wysokoscGlowna);
            int przerwa = (int)(0.01 * panelGlowny.Width);
            //MessageBox.Show(panelGlowny.Width.ToString() + "vs" + panelGlowny.Location.ToString());
            panel1.Width = (int)((panelGlowny.Width - (3 * przerwa)) / 2);
            panel2.Width = (int)((panelGlowny.Width - (3 * przerwa)) / 2);
            panel3.Width = (int)((panelGlowny.Width - (3 * przerwa)) / 2);
            panel4.Width = (int)((panelGlowny.Width - (3 * przerwa)) / 2);

            panel1.Height = (int)((panelGlowny.Height - (3 * przerwa)) / 2);
            panel2.Height = (int)((panelGlowny.Height - (3 * przerwa)) / 2);
            panel3.Height = (int)((panelGlowny.Height - (3 * przerwa)) / 2);
            panel4.Height = (int)((panelGlowny.Height - (3 * przerwa)) / 2);

            obrazek1.Width = (int)(0.5*panel1.Width);
            obrazek1.Height = (int)(0.6*obrazek1.Width);

            obrazek2.Width = (int)(0.3 * panel1.Width);
            obrazek2.Height = (int)(0.3 * panel1.Width);

            obrazek3.Width = (int)(0.6*panel2.Width);
            obrazek3.Height = (int)(0.8 * panel2.Height);

            obrazek4.Width = (int)(0.7*panel3.Width);
            obrazek5.Width = (int)(0.7 * panel3.Width);
            obrazek4.Height = (int)(0.2 * panel3.Height);
            obrazek5.Height = (int)(0.2 * panel3.Height);

            obrazek6.Width = (int)(0.9*panel4.Width);
            obrazek6.Height = (int)(0.5 * panel4.Height);

            tekstInstrukcja1.Width = obrazek1.Width;
            tekstInstrukcja2.Width = (int)(obrazek2.Width * 1.45);
            tekstInstrukcja3.Width = (int)(panel2.Width-obrazek3.Width-(3*(0.02 * panel2.Width)));
            tekstInstrukcja4.Width = tekstInstrukcja3.Width;
            tekstInstrukcja5.Width = obrazek3.Width;
            tekstInstrukcja6.Width = (int)(0.5*obrazek4.Width);
            tekstInstrukcja7.Width = (int)((obrazek6.Width / 2) - (0.02 * panel2.Width));
            tekstInstrukcja8.Width = tekstInstrukcja7.Width;

            tekstInstrukcja1.Height = panel1.Height - obrazek1.Location.Y-obrazek1.Height-(int)(0.02*panel1.Height);
            tekstInstrukcja2.Height = tekstInstrukcja1.Height;
            tekstInstrukcja3.Height = (int)(obrazek3.Height * 0.6-(0.02*panel2.Height));
            tekstInstrukcja4.Height = (int)(obrazek3.Height * 0.4);
            tekstInstrukcja5.Height = (int)(panel2.Height-obrazek3.Height-(3*(0.02*panel2.Height)));
            tekstInstrukcja6.Height = obrazek4.Height;
            tekstInstrukcja7.Height = panel4.Height - obrazek6.Height - obrazek6.Location.Y - (int)(4 * (0.02 * panel4.Height));
            tekstInstrukcja8.Height = tekstInstrukcja7.Height;

            int wielkoscCzcionki = (int)(0.03 * panel1.Height);
            tekstInstrukcja1.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja2.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja3.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja4.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja5.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja6.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja7.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);
            tekstInstrukcja8.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki);

            //instrukcjaCofnac.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki*3);
            //opisPowrot.Font = new Font("Microsoft Sans Serif", wielkoscCzcionki * 2);
            //opisPowrot.Location = new Point((int)((szerokoscGlowna / 2) - (opisPowrot.Width / 2)), (int)(wysokoscGlowna - opisPowrot.Height -(0.01 * wysokoscGlowna)));
            //instrukcjaCofnac.Location = new Point((int)((szerokoscGlowna/2)-(instrukcjaCofnac.Width/2)),(int)(0.1*wysokoscGlowna));

            //panelGlowny.Location = new Point((int)((szerokoscGlowna / 2) - (panelGlowny.Width / 2)), (int)((wysokoscGlowna / 2) - (panelGlowny.Height / 2)));
            panelGlowny.Location = new Point(0, 0);
            panel1.Location = new Point(przerwa, przerwa);
            panel2.Location = new Point((2 * przerwa) + panel1.Width, przerwa);
            panel3.Location = new Point(przerwa, panel1.Height + (przerwa * 2));
            panel4.Location = new Point((2 * przerwa) + panel3.Width, panel1.Height + (przerwa * 2));


            obrazek1.Location = new Point((int)(0.04*panel1.Width),(int)(0.04*panel1.Height));
            obrazek2.Location = new Point((int)(obrazek1.Location.X+obrazek1.Width+(0.1*panel1.Width)),obrazek1.Location.Y+(int)(0.1*panel1.Height));
            obrazek3.Location = new Point(panel2.Width - (int)(0.02 * panel2.Width) - obrazek3.Width, (int)(0.02 * panel2.Height));
            obrazek4.Location = new Point((int)(0.15*panel3.Width),(int)(0.2*panel3.Height));
            obrazek5.Location = new Point((int)(0.15 * panel3.Width), (int)(0.2 * panel3.Height)+obrazek4.Height);
            obrazek6.Location = new Point((int)((panel4.Width/2)-(obrazek6.Width/2)),(int)(0.05*panel4.Height));

            tekstInstrukcja1.Location = new Point(obrazek1.Location.X,obrazek1.Location.Y+obrazek1.Height+(int)(0.02*panel1.Height));
            tekstInstrukcja2.Location = new Point(obrazek2.Location.X-(int)(0.26*obrazek2.Width), obrazek2.Location.Y + obrazek2.Height);
            tekstInstrukcja3.Location = new Point((int)(0.02*panel2.Width),(int)(0.02*panel2.Height));
            tekstInstrukcja4.Location = new Point((int)(0.02 * panel2.Width), tekstInstrukcja3.Location.Y+tekstInstrukcja3.Height+(int)(0.02 * panel2.Height));
            tekstInstrukcja5.Location = new Point(obrazek3.Location.X, obrazek3.Location.Y+obrazek3.Height+(int)(0.02*panel2.Width));
            tekstInstrukcja6.Location = new Point(obrazek4.Location.X+(int)(obrazek4.Width*0.25), obrazek5.Location.Y+obrazek5.Height+(int)(0.02*panel3.Height));
            tekstInstrukcja7.Location = new Point(obrazek6.Location.X, obrazek6.Location.Y+obrazek6.Height+(int)(0.02*panel4.Height));
            tekstInstrukcja8.Location = new Point(obrazek6.Location.Y+obrazek6.Width-tekstInstrukcja8.Width, obrazek6.Location.Y + obrazek6.Height + (int)(0.02 * panel4.Height));
            //panelGlowny.Location = new Point((int)((szerokoscGlowna/2)-(panelGlowny.Width/2)), (int)((wysokoscGlowna/2)-(panelGlowny.Height/2)));
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Instrukcja_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
