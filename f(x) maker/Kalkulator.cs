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
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
            //wymiarowanie();
            //this.FormClosing += Kalkulator_Closing;
        }

        public void wymiarowanie()
        {
            panel1.Width = this.Width;
            panel1.Height = this.Height;

            double wysokoscPrzycisku = 0.15;
            double szerokoscPrzycisku = 1.1;

            double odstepG = 0.02 * this.Width;

            b1.Height = (int)(wysokoscPrzycisku * this.Height);
            b1.Width = (int)(szerokoscPrzycisku * b1.Height);

            b2.Height = (int)(wysokoscPrzycisku * this.Height);
            b2.Width = (int)(szerokoscPrzycisku * b1.Height);

            b3.Height = (int)(wysokoscPrzycisku * this.Height);
            b3.Width = (int)(szerokoscPrzycisku * b1.Height);

            b4.Height = (int)(wysokoscPrzycisku * this.Height);
            b4.Width = (int)(szerokoscPrzycisku * b1.Height);

            b5.Height = (int)(wysokoscPrzycisku * this.Height);
            b5.Width = (int)(szerokoscPrzycisku * b1.Height);

            b6.Height = (int)(wysokoscPrzycisku * this.Height);
            b6.Width = (int)(szerokoscPrzycisku * b1.Height);

            b7.Height = (int)(wysokoscPrzycisku * this.Height);
            b7.Width = (int)(szerokoscPrzycisku * b1.Height);

            b8.Height = (int)(wysokoscPrzycisku * this.Height);
            b8.Width = (int)(szerokoscPrzycisku * b1.Height);

            b9.Height = (int)(wysokoscPrzycisku * this.Height);
            b9.Width = (int)(szerokoscPrzycisku * b1.Height);

            b0.Height = (int)(wysokoscPrzycisku * this.Height);
            b0.Width = (int)(2 * szerokoscPrzycisku * b1.Height + odstepG);

            b10.Height = (int)(wysokoscPrzycisku * this.Height);
            b10.Width = (int)(szerokoscPrzycisku * b1.Height);

            b11.Height = (int)(wysokoscPrzycisku * this.Height);
            b11.Width = (int)(szerokoscPrzycisku * b1.Height);

            b12.Height = (int)(wysokoscPrzycisku * this.Height);
            b12.Width = (int)(szerokoscPrzycisku * b1.Height);

            b13.Height = (int)(wysokoscPrzycisku * this.Height);
            b13.Width = (int)(2 * szerokoscPrzycisku * b1.Height + odstepG);

            b14.Height = (int)(wysokoscPrzycisku * this.Height);
            b14.Width = (int)(szerokoscPrzycisku * b1.Height);

            b15.Height = (int)(wysokoscPrzycisku * this.Height);
            b15.Width = (int)(szerokoscPrzycisku * b1.Height);

            b16.Height = (int)(wysokoscPrzycisku * this.Height);
            b16.Width = (int)(szerokoscPrzycisku * b1.Height);

            b17.Height = (int)(wysokoscPrzycisku * this.Height);
            b17.Width = (int)(szerokoscPrzycisku * b1.Height);

            b18.Height = (int)(wysokoscPrzycisku * this.Height);
            b18.Width = (int)(szerokoscPrzycisku * b1.Height);

            b19.Height = (int)(wysokoscPrzycisku * this.Height);
            b19.Width = (int)(szerokoscPrzycisku * b1.Height);

            b20.Height = (int)(wysokoscPrzycisku * this.Height);
            b20.Width = (int)(szerokoscPrzycisku * b1.Height);

            b21.Height = (int)(wysokoscPrzycisku * this.Height);
            b21.Width = (int)(szerokoscPrzycisku * b1.Height);

            //b22.Height = (int)(0.15 * this.Height);
            //b22.Width = (int)(1.1 * b1.Height);

            b23.Height = (int)(wysokoscPrzycisku * this.Height);
            b23.Width = (int)(szerokoscPrzycisku * b1.Height);

            b24.Height = (int)(wysokoscPrzycisku * this.Height);
            b24.Width = (int)(szerokoscPrzycisku * b1.Height);

            b25.Height = (int)(wysokoscPrzycisku * this.Height);
            b25.Width = (int)(szerokoscPrzycisku * b1.Height);

            benter.Height = (int)(wysokoscPrzycisku * this.Height);
            benter.Width = (int)(3 * szerokoscPrzycisku * b1.Height + (odstepG*2));

            //b27.Height = (int)(0.15 * this.Height);
            //b27.Width = (int)(1.1 * b1.Height);

            

            b1.Location = new Point((int)(odstepG*2), (int)(odstepG*2));
            b2.Location = new Point((int)(b1.Location.X+b1.Width+odstepG), (int)odstepG*2);
            b3.Location = new Point((int)(b2.Location.X + b2.Width + odstepG), (int)odstepG*2);
            b19.Location = new Point((int)(b3.Location.X + b3.Width + odstepG), (int)odstepG*2);
            b13.Location = new Point((int)(b19.Location.X + b19.Width + odstepG), (int)odstepG*2);

            b4.Location = new Point((int)(odstepG * 2), (int)(b1.Location.Y + b1.Height + odstepG));
            b5.Location = new Point((int)(b4.Location.X + b4.Width + odstepG), (int)(b1.Location.Y + b1.Height + odstepG));
            b6.Location = new Point((int)(b5.Location.X + b5.Width + odstepG), (int)(b1.Location.Y + b1.Height + odstepG));
            b11.Location = new Point((int)(b6.Location.X + b6.Width + odstepG), (int)(b1.Location.Y + b1.Height + odstepG));
            b12.Location = new Point((int)(b11.Location.X + b11.Width + odstepG), (int)(b1.Location.Y + b1.Height + odstepG));
            b25.Location = new Point((int)(b12.Location.X + b12.Width + odstepG), (int)(b1.Location.Y + b1.Height + odstepG));

            b7.Location = new Point((int)(odstepG * 2), (int)(b4.Location.Y + b4.Height + odstepG));
            b8.Location = new Point((int)(b7.Location.X + b7.Width + odstepG), (int)(b4.Location.Y + b4.Height + odstepG));
            b9.Location = new Point((int)(b8.Location.X + b8.Width + odstepG), (int)(b4.Location.Y + b4.Height + odstepG));
            b14.Location = new Point((int)(b9.Location.X + b9.Width + odstepG), (int)(b4.Location.Y + b4.Height + odstepG));
            b15.Location = new Point((int)(b14.Location.X + b14.Width + odstepG), (int)(b4.Location.Y + b4.Height + odstepG));
            b16.Location = new Point((int)(b15.Location.X + b15.Width + odstepG), (int)(b4.Location.Y + b4.Height + odstepG));

            b0.Location = new Point((int)(odstepG * 2), (int)(b7.Location.Y + b7.Height + odstepG));
            b10.Location = new Point((int)(b0.Location.X + b0.Width + odstepG), (int)(b7.Location.Y + b7.Height + odstepG));
            b24.Location = new Point((int)(b10.Location.X + b10.Width + odstepG), (int)(b7.Location.Y + b7.Height + odstepG));
            b17.Location = new Point((int)(b24.Location.X + b24.Width + odstepG), (int)(b7.Location.Y + b7.Height + odstepG));
            b18.Location = new Point((int)(b17.Location.X + b17.Width + odstepG), (int)(b7.Location.Y + b7.Height + odstepG));

            benter.Location = new Point((int)(odstepG * 2), (int)(b0.Location.Y + b0.Height + odstepG));
            b20.Location = new Point((int)(benter.Location.X + benter.Width + odstepG), (int)(b0.Location.Y + b0.Height + odstepG));
            b21.Location = new Point((int)(b20.Location.X + b20.Width + odstepG), (int)(b0.Location.Y + b0.Height + odstepG));
            b23.Location = new Point((int)(b21.Location.X + b21.Width + odstepG), (int)(b0.Location.Y + b0.Height + odstepG));
            //b18.Location = new Point((int)(b17.Location.X + b17.Width + odstepG), (int)(b7.Location.Y + b7.Height + odstepG));
            //b16.Location = new Point((int)(b15.Location.X + b15.Width + odstepG), (int)(b4.Location.Y + b4.Height + odstepG));

            //MessageBox.Show(b1.Height.ToString());
            int wysokoscTekstu = b1.Height/4;
            b0.Font = new Font("Times New Roman", wysokoscTekstu);
            b1.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b2.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b3.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b4.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b5.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b6.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b7.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b8.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b9.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b10.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b11.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b12.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b13.Font = new Font("Microsoft Sans Serif", wysokoscTekstu * 2);
            b14.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b15.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b16.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b17.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b18.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b19.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b20.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b21.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b23.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b24.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            b25.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
            benter.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
               

            this.Height += (int)(odstepG*2);
        }
        //int temp = 2;
        public int czyWylaczona=0;
        private void Kalkulator_Resize(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
