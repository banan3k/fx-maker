//wszelkie prawa autorskie należą do Szymona Filipowicza, data 2014-04-27

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace f_x__maker
{
    public partial class Form1 : Form
    {
        public FileStream plik;
        public StreamWriter zapisuj;
        public StreamReader wczytuj;

        

        public Form1()
        {
            InitializeComponent();
            wlaczanieKlawiszy();

           // zapisGranic("10","10");
            dopasowanieRozmiarow();

            RysowanieWykresu(0);
            wpisywanyWzor0.Click += new EventHandler(openKey_Click);
            wpisywanyWzor1.Click += new EventHandler(openKey_Click);
            wpisywanyWzor2.Click += new EventHandler(openKey_Click);
            wpisywanyWzor3.Click += new EventHandler(openKey_Click);
            wpisywanyWzor4.Click += new EventHandler(openKey_Click);
            wpisywanyWzor5.Click += new EventHandler(openKey_Click);
            granicaL.Click += new EventHandler(openKey_Click);
            granicaP.Click += new EventHandler(openKey_Click);
            PunktX.Click += new EventHandler(openKey_Click);
            PunktY.Click += new EventHandler(openKey_Click);
        }

        
        public void dopasowanieRozmiarow()
        {

            float wysokoscGlowna = Screen.PrimaryScreen.WorkingArea.Size.Height;
            float szerokoscGlowna = Screen.PrimaryScreen.WorkingArea.Size.Width;
            
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);


            



            panelWzory.Width = (int)(0.33 * szerokoscGlowna);
            panelWzory.Height = (int)(0.8 * wysokoscGlowna);
            panelWzory.Location = new Point((int)(0.1 * szerokoscGlowna), (int)(0.13 * wysokoscGlowna));


            panelWykresy.Height = (int)(0.75 * wysokoscGlowna);
            float wielkoscJednostki = panelWykresy.Height / (granicaPrawa + granicaLewa);

            przesuniecie1L.Width = (int)wielkoscJednostki;
            przesuniecie1L.Height = (int)wielkoscJednostki;
            przesuniecie1G.Width = (int)wielkoscJednostki;
            przesuniecie1G.Height = (int)wielkoscJednostki;
            przesuniecie1G.Location = new Point(przesuniecie1G.Location.X, panelWzory.Location.Y);

            przesuniecie2L.Width = (int)wielkoscJednostki;
            przesuniecie2L.Height = (int)wielkoscJednostki;
            przesuniecie2G.Width = (int)wielkoscJednostki;
            przesuniecie2G.Height = (int)wielkoscJednostki;
            przesuniecie2G.Location = new Point(przesuniecie2G.Location.X, panelWzory.Location.Y);

            przesuniecie3L.Width = (int)wielkoscJednostki;
            przesuniecie3L.Height = (int)wielkoscJednostki;
            przesuniecie3G.Width = (int)wielkoscJednostki;
            przesuniecie3G.Height = (int)wielkoscJednostki;
            przesuniecie3G.Location = new Point(przesuniecie3G.Location.X, panelWzory.Location.Y);

            przesuniecie4L.Width = (int)wielkoscJednostki;
            przesuniecie4L.Height = (int)wielkoscJednostki;
            przesuniecie4G.Width = (int)wielkoscJednostki;
            przesuniecie4G.Height = (int)wielkoscJednostki;
            przesuniecie4G.Location = new Point(przesuniecie4G.Location.X, panelWzory.Location.Y);

            przesuniecie5L.Width = (int)wielkoscJednostki;
            przesuniecie5L.Height = (int)wielkoscJednostki;
            przesuniecie5G.Width = (int)wielkoscJednostki;
            przesuniecie5G.Height = (int)wielkoscJednostki;
            przesuniecie5G.Location = new Point(przesuniecie5G.Location.X, panelWzory.Location.Y);

            przesuniecie6L.Width = (int)wielkoscJednostki;
            przesuniecie6L.Height = (int)wielkoscJednostki;
            przesuniecie6G.Width = (int)wielkoscJednostki;
            przesuniecie6G.Height = (int)wielkoscJednostki;
            przesuniecie6G.Location = new Point(przesuniecie6G.Location.X, panelWzory.Location.Y);

            
            panelWykresy.Width = panelWykresy.Height;
            panelWykresy.Location = new Point((int)(panelWzory.Location.X + panelWzory.Width * 1.1), panelWzory.Location.Y+przesuniecie1G.Height);

            int wysokoscTekstu = (int)(0.04*panelWzory.Width);
            int wysokoscNapisu = (int)(0.033 * panelWzory.Width);
            int malyTekst = (int)(0.013 * panelWykresy.Width);
            int duzyTekst = (int)(0.05 * panelWzory.Width);
            Tytul.Font = new Font("Microsoft Sans Serif", (int)(0.07 * panelWzory.Width));
            opisWzory.Font = new Font("Microsoft Sans Serif", (int)(0.75 * duzyTekst));
                wpisywanyWzor0.Width = (int)(0.7 * panelWzory.Width);
                wpisywanyWzor1.Width = (int)(0.7 * panelWzory.Width);
                wpisywanyWzor2.Width = (int)(0.7 * panelWzory.Width);
                wpisywanyWzor3.Width = (int)(0.7 * panelWzory.Width);
                wpisywanyWzor4.Width = (int)(0.7 * panelWzory.Width);
                wpisywanyWzor5.Width = (int)(0.7 * panelWzory.Width);
                wpisywanyWzor0.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                wpisywanyWzor1.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                wpisywanyWzor2.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                wpisywanyWzor3.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                wpisywanyWzor4.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                wpisywanyWzor5.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                clear1.Height = wpisywanyWzor0.Height;
                clear1.Width = clear1.Height;
                clear2.Height = wpisywanyWzor0.Height;
                clear2.Width = clear1.Height;
                clear3.Height = wpisywanyWzor0.Height;
                clear3.Width = clear1.Height;
                clear4.Height = wpisywanyWzor0.Height;
                clear4.Width = clear1.Height;
                clear5.Height = wpisywanyWzor0.Height;
                clear5.Width = clear1.Height;
                clear6.Height = wpisywanyWzor0.Height;
                clear6.Width = clear1.Height;
                fx1.Font = new Font("Microsoft Sans Serif", (int)(wysokoscNapisu*1.1));
                fx2.Font = new Font("Microsoft Sans Serif", (int)(wysokoscNapisu * 1.1));
                fx3.Font = new Font("Microsoft Sans Serif", (int)(wysokoscNapisu * 1.1));
                fx4.Font = new Font("Microsoft Sans Serif", (int)(wysokoscNapisu * 1.1));
                fx5.Font = new Font("Microsoft Sans Serif", (int)(wysokoscNapisu * 1.1));
                fx6.Font = new Font("Microsoft Sans Serif", (int)(wysokoscNapisu * 1.1));
                OpisDziedzina.Font = new Font("Microsoft Sans Serif", wysokoscNapisu);
                
                OpisGranica.Font = new Font("Microsoft Sans Serif", wysokoscNapisu);
                
                ZnakMinus.Font = new Font("Microsoft Sans Serif", wysokoscNapisu);
                
                ZnakPlus.Font = new Font("Microsoft Sans Serif", wysokoscNapisu);
                znakPrzecinek.Font = new Font("Microsoft Sans Serif", (int)(duzyTekst * (1.2 / 2)));
                ZnakStrzalkaL.Font = new Font("Microsoft Sans Serif", duzyTekst);
                ZnakStrzalkaP.Font = new Font("Microsoft Sans Serif", duzyTekst);
                
                linia1.Width = panelWzory.Width;
                linia2.Width = panelWzory.Width;
                granicaL.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                granicaP.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);
                Dziedzina.Font = new Font("Microsoft Sans Serif", wysokoscTekstu);

                
                opisEmail.Font = new Font("Microsoft Sans Serif", (int)(malyTekst));
                opisKontakt.Font = new Font("Microsoft Sans Serif", (int)(malyTekst));
                opisTworcy.Font = new Font("Microsoft Sans Serif", (int)(malyTekst));

                int poziomY = (int)(opisWzory.Height * 1.01);
                opisWzory.Location = new Point(0, 0);
                linia1.Location = new Point(linia1.Location.X, poziomY);
                poziomY += (int)(0.03 * panelWzory.Height);
                fx1.Location = new Point((int)(panelWykresy.Width * 0.01), (int)(poziomY*1.02));
                wpisywanyWzor0.Location = new Point(fx1.Location.X+fx1.Width, poziomY);
                clear1.Location = new Point((int)(wpisywanyWzor0.Location.X + (wpisywanyWzor0.Width*1.01)), poziomY);
                poziomY += (int)(wpisywanyWzor0.Height*1.2);
                fx2.Location = new Point(fx1.Location.X, poziomY);
                wpisywanyWzor1.Location = new Point(wpisywanyWzor0.Location.X, poziomY);
                clear2.Location = new Point(clear1.Location.X, poziomY);
                poziomY += (int)(wpisywanyWzor0.Height * 1.2);
                fx3.Location = new Point(fx1.Location.X, poziomY);
                wpisywanyWzor2.Location = new Point(wpisywanyWzor0.Location.X, poziomY);
                clear3.Location = new Point(clear1.Location.X, poziomY);
                poziomY += (int)(wpisywanyWzor0.Height * 1.2);
                fx4.Location = new Point(fx1.Location.X, poziomY);
                wpisywanyWzor3.Location = new Point(wpisywanyWzor0.Location.X, poziomY);
                clear4.Location = new Point(clear1.Location.X, poziomY);
                poziomY += (int)(wpisywanyWzor0.Height * 1.2);
                fx5.Location = new Point(fx1.Location.X, poziomY);
                wpisywanyWzor4.Location = new Point(wpisywanyWzor0.Location.X, poziomY);
                clear5.Location = new Point(clear1.Location.X, poziomY);
                poziomY += (int)(wpisywanyWzor0.Height * 1.2);
                fx6.Location = new Point(fx1.Location.X, poziomY);
                wpisywanyWzor5.Location = new Point(wpisywanyWzor0.Location.X, poziomY);
                clear6.Location = new Point(clear1.Location.X, poziomY);
                poziomY += (int)(wpisywanyWzor0.Height * 1.5);
                linia2.Location = new Point(0, poziomY);
            
                poziomY += (int)(wpisywanyWzor0.Height * 0.1);
                granicaL.Location = new Point((int)(panelWzory.Width * 0.08), poziomY);
                granicaP.Location = new Point((int)(panelWzory.Width-granicaP.Width-(panelWzory.Width * 0.08)), poziomY);
                ZnakMinus.Location = new Point((int)(0.03 * panelWzory.Width), (int)(poziomY * 1.01));
                ZnakPlus.Location = new Point((int)(panelWzory.Width - ZnakPlus.Width - (0.03 * panelWzory.Width)), (int)(poziomY*1.01));
                ZnakStrzalkaL.Location = new Point(granicaL.Location.X+granicaL.Width, poziomY);
                ZnakStrzalkaP.Location = new Point(granicaP.Location.X - ZnakStrzalkaP.Width, poziomY);
                OpisGranica.Location = new Point((int)((panelWzory.Width/2)-(OpisGranica.Width/2)),poziomY);
                poziomY += (int)(wpisywanyWzor0.Height * 1.3);
                OpisDziedzina.Location = new Point(granicaL.Location.X,poziomY);
                Dziedzina.Location = new Point(OpisDziedzina.Location.X + OpisDziedzina.Width, (int)(0.99*poziomY));
                poziomY += (int)(wpisywanyWzor0.Height * 1.5);



                //PANEL PUNKT
                PanelSprPunkt.Width = (int)(0.95 * panelWzory.Width);
                PanelSprPunkt.Height = (int)(0.2 * panelWzory.Height);
                PanelSprPunkt.Location = new Point((int)(0.02 * panelWzory.Width), (int)(panelWzory.Height - (PanelSprPunkt.Height * 1.1)));

                int wielkoscTekstuSprawdzanie = (int)(0.1 * PanelSprPunkt.Height);

                znakNalezy.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie*2);
                OpisNalezec.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie/2);
                OpisPunkt.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);
                OpisWynik.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie / 2);
                oznaczenieY.Font = new Font("Microsoft Sans Serif", (int)wielkoscTekstuSprawdzanie / 2);
                oznaczenieX.Font = new Font("Microsoft Sans Serif", (int)wielkoscTekstuSprawdzanie / 2);

                znakNawias1.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);
                znakNawias2.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);

                PunktX.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);
                PunktY.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);
                PunktX.Width = (int)(0.05 * PanelSprPunkt.Width);
                PunktY.Width = (int)(0.05 * PanelSprPunkt.Width);
                wzorDoKtoregoPunkt.Width = (int)(0.1 * PanelSprPunkt.Width);
                

                OpisFx.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);

                WynikPunkt.Font = new Font("Microsoft Sans Serif", (int)(wielkoscTekstuSprawdzanie*1.1));
                WynikPunkt.Width = (int)(0.5 * PanelSprPunkt.Width);
                sprawdzPunktPrzycisk.Height = (int)(OpisPunkt.Height*1.5);
                sprawdzPunktPrzycisk.Font = new Font("Microsoft Sans Serif", (int)(wielkoscTekstuSprawdzanie/1.5));
                sprawdzPunktPrzycisk.Width = (int)(100);

                wzorDoKtoregoPunkt.Font = new Font("Microsoft Sans Serif", wielkoscTekstuSprawdzanie);

                
                OpisPunkt.Location = new Point((int)(PanelSprPunkt.Width * 0.04), (int)(PanelSprPunkt.Height * 0.2));
                znakNawias1.Location = new Point(OpisPunkt.Location.X + OpisPunkt.Width, OpisPunkt.Location.Y);
                PunktX.Location = new Point(znakNawias1.Location.X + znakNawias1.Width, OpisPunkt.Location.Y);
                oznaczenieX.Location = new Point(PunktX.Location.X + (int)((PunktX.Width / 2)-(oznaczenieX.Width/2)), PunktX.Location.Y - oznaczenieX.Height); 
                znakPrzecinek.Location = new Point(PunktX.Location.X + PunktX.Width, OpisPunkt.Location.Y);
                PunktY.Location = new Point(znakPrzecinek.Location.X + znakPrzecinek.Width, OpisPunkt.Location.Y);
                oznaczenieY.Location = new Point(PunktY.Location.X + (int)((PunktY.Width / 2) - (oznaczenieY.Width / 2)), PunktY.Location.Y - oznaczenieY.Height);
                znakNawias2.Location = new Point(PunktY.Location.X + PunktY.Width, OpisPunkt.Location.Y);
                znakNalezy.Location = new Point(znakNawias2.Location.X + znakNawias2.Width, (int)(OpisPunkt.Location.Y*0.7));
                OpisFx.Location = new Point(znakNalezy.Location.X + znakNalezy.Width, (int)(OpisPunkt.Location.Y*1.1));
                wzorDoKtoregoPunkt.Location = new Point(OpisFx.Location.X + OpisFx.Width, OpisPunkt.Location.Y);
                OpisNalezec.Location = new Point(znakNalezy.Location.X, znakNalezy.Location.Y - OpisNalezec.Height);

                sprawdzPunktPrzycisk.Location = new Point(OpisPunkt.Location.X, (int)(PanelSprPunkt.Height - (sprawdzPunktPrzycisk.Height * 1.5)));
                WynikPunkt.Location = new Point((int)(sprawdzPunktPrzycisk.Location.X+(sprawdzPunktPrzycisk.Width*1.5)), (int)(PanelSprPunkt.Height - (sprawdzPunktPrzycisk.Height * 1.5)));
                OpisWynik.Location = new Point((int)(WynikPunkt.Location.X + ((WynikPunkt.Width / 2) - (OpisWynik.Width / 2))), WynikPunkt.Location.Y - OpisWynik.Height);
                


            pictureWykres.Width = panelWykresy.Height;
            pictureWykres.Height = panelWykresy.Height;

            wlaczenieInstrukcji.Width = (int)(0.06 * szerokoscGlowna);
            wlaczenieInstrukcji.Height = wlaczenieInstrukcji.Width;
            wlaczenieInstrukcji.Location = new Point((int)(panelWykresy.Location.X * 1.1), panelWykresy.Location.Y);

            openKey.Width = (int)(0.06 * szerokoscGlowna);
            openKey.Height = openKey.Width;
            openKey.Location = new Point((int)(panelWykresy.Location.X * 1.1), panelWzory.Location.Y+wlaczenieInstrukcji.Height);

            wlaczenieInstrukcji.Location = new Point((int)(panelWykresy.Location.X+panelWykresy.Width*1.01), panelWykresy.Location.Y-1);
            openKey.Location = new Point(wlaczenieInstrukcji.Location.X, panelWykresy.Location.Y+wlaczenieInstrukcji.Height);

            

            opisTworcy.Font = new Font("Microsoft Sans Serif", (int)(0.7*malyTekst));
            opisTworcy.Location = new Point((int)(szerokoscGlowna-(opisTworcy.Width*1.2)), (int)(0.92*wysokoscGlowna));
            opisKontakt.Font = new Font("Microsoft Sans Serif", (int)(0.7 * malyTekst));
            opisKontakt.Location = new Point((int)(szerokoscGlowna - (opisTworcy.Width * 1.2)), (int)(opisTworcy.Location.Y+(opisKontakt.Height*1.1)));
            opisEmail.Font = new Font("Microsoft Sans Serif", (int)(0.7 * malyTekst));
            opisEmail.Location = new Point((int)(opisKontakt.Location.X + opisKontakt.Width), (int)(opisTworcy.Location.Y + (opisKontakt.Height * 1.1)));

            
        }

        public Kalkulator kalkulator = new Kalkulator();

        /*
        private void zapisGranic(string granicaDoZapisuL, string granicaDoZapisuP)
        {
            plik = new FileStream("granice.txt", FileMode.Create, FileAccess.Write);
            zapisuj = new StreamWriter(plik);
            string granicaDoZapisuLMinus = "-" + granicaDoZapisuL;
            zapisuj.Write(granicaDoZapisuLMinus + "," + granicaDoZapisuP);
            zapisuj.Close();
            plik.Close();
        }
        */
        public void wlaczanieKlawiszy()
        {
            if (zamknietaKlawiatura==1)
            {
                kalkulator = new Kalkulator();
                zamknietaKlawiatura = 0;
            }

            float wysokoscGlowna = Screen.PrimaryScreen.WorkingArea.Size.Height;
            float szerokoscGlowna = Screen.PrimaryScreen.WorkingArea.Size.Width;

            kalkulator.Height = (int)(0.45*wysokoscGlowna);
            kalkulator.Width = (int)(0.3*szerokoscGlowna);
            kalkulator.wymiarowanie();
            kalkulator.Show();
            kalkulator.Location = new Point((int)(0.25*szerokoscGlowna), (int)(0.25*wysokoscGlowna));
                
            kalkulator.TopMost = true;
            

            //plik = new FileStream("wzory.txt", FileMode.Create, FileAccess.Write);
            //zapisuj = new StreamWriter(plik);
            //zapisuj.Write("");
            //zapisuj.Close();
            //plik.Close();

            kalkulator.FormClosed += new FormClosedEventHandler(zamykanie);
            kalkulator.Resize += new EventHandler(zamykanie);

            kalkulator.b1.Click += new EventHandler(klawiatura);
            kalkulator.b2.Click += new EventHandler(klawiatura);
            kalkulator.b3.Click += new EventHandler(klawiatura);
            kalkulator.b4.Click += new EventHandler(klawiatura);
            kalkulator.b5.Click += new EventHandler(klawiatura);
            kalkulator.b6.Click += new EventHandler(klawiatura);
            kalkulator.b7.Click += new EventHandler(klawiatura);
            kalkulator.b8.Click += new EventHandler(klawiatura);
            kalkulator.b9.Click += new EventHandler(klawiatura);
            kalkulator.b0.Click += new EventHandler(klawiatura);
            kalkulator.b10.Click += new EventHandler(klawiatura);
            kalkulator.b11.Click += new EventHandler(klawiatura);
            kalkulator.b12.Click += new EventHandler(klawiatura);
            kalkulator.b13.Click += new EventHandler(klawiatura);
            kalkulator.b14.Click += new EventHandler(klawiatura);
            kalkulator.b15.Click += new EventHandler(klawiatura);
            kalkulator.b16.Click += new EventHandler(klawiatura);
            kalkulator.b17.Click += new EventHandler(klawiatura);
            kalkulator.b18.Click += new EventHandler(klawiatura);
            kalkulator.b19.Click += new EventHandler(klawiatura);
            kalkulator.b20.Click += new EventHandler(klawiatura);
            kalkulator.b21.Click += new EventHandler(klawiatura);
            kalkulator.b23.Click += new EventHandler(klawiatura);
            kalkulator.b24.Click += new EventHandler(klawiatura);
            kalkulator.b25.Click += new EventHandler(klawiatura);
            kalkulator.benter.Click += new EventHandler(klawiatura);

            /*wpisywanyWzor0.TextChanged += new EventHandler(zapisDoPliku);
            wpisywanyWzor1.TextChanged += new EventHandler(zapisDoPliku);
            wpisywanyWzor2.TextChanged += new EventHandler(zapisDoPliku);
            wpisywanyWzor3.TextChanged += new EventHandler(zapisDoPliku);
            wpisywanyWzor4.TextChanged += new EventHandler(zapisDoPliku);
            wpisywanyWzor5.TextChanged += new EventHandler(zapisDoPliku);*/

        }



        int zamknietaKlawiatura = 0;
        public void zamykanie(object sender, EventArgs e)
        {
            openKey.Visible = true;
            zamknietaKlawiatura = 1;
        }

        Graphics g;
        Pen pen;
        public void RysowanieWykresu(int ktoraWersja)
        {
            int i;
            double przeskok = 0;
            double oIlePrzeskokow = 0.005;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            pictureWykres.Image = new Bitmap(pictureWykres.Width, pictureWykres.Height);
            g = Graphics.FromImage(pictureWykres.Image);
        

            pen = new Pen(Brushes.Black);
            
            pen.Width = 4.0F;

            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;

            pen.Color = System.Drawing.Color.Black;
            Point liniaPoziomaS = new Point(0, pictureWykres.Height / 2);
            Point liniaPoziomaK = new Point(pictureWykres.Width, pictureWykres.Height / 2);
            g.DrawLine(pen, liniaPoziomaS, liniaPoziomaK);
            Point liniaPionowaS = new Point(pictureWykres.Width/2, 0);
            Point liniaPionowaK = new Point(pictureWykres.Width/2, pictureWykres.Height);
            
            g.DrawLine(pen, liniaPionowaS, liniaPionowaK);

            


            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            float wielkoscJednostki2 = pictureWykres.Width / (granicaPrawa + granicaLewa);

            Point strzalkaPozG = new Point((int)(pictureWykres.Width-(wielkoscJednostki/2)),(int)((pictureWykres.Height/2)-(wielkoscJednostki/2)));
            Point strzalkaPozS = new Point(pictureWykres.Width, pictureWykres.Height/2);
            g.DrawLine(pen, strzalkaPozG, strzalkaPozS);
            Point strzalkaPozD = new Point((int)(pictureWykres.Width - (wielkoscJednostki / 2)), (int)((pictureWykres.Height / 2) + (wielkoscJednostki / 2)));
            g.DrawLine(pen, strzalkaPozD, strzalkaPozS);

            Point strzalkaPioG = new Point((int)((pictureWykres.Width/2) - (wielkoscJednostki / 2)), (int)(wielkoscJednostki/2));
            Point strzalkaPioS = new Point((int)(pictureWykres.Width/2), 0);
            g.DrawLine(pen, strzalkaPioG, strzalkaPioS);
            Point strzalkaPioD = new Point((int)((pictureWykres.Width / 2) + (wielkoscJednostki / 2)), (int)(wielkoscJednostki / 2));
            g.DrawLine(pen, strzalkaPioD, strzalkaPioS);

            pen.Width = 1.0F;
            for (i = 0; i < (granicaLewa +granicaPrawa); i++)
            {
                g.DrawLine(pen, wielkoscJednostki2 * i, 0, wielkoscJednostki2*i, pictureWykres.Height);
                g.DrawLine(pen, 0, wielkoscJednostki * i, pictureWykres.Width, wielkoscJednostki * i);
            }
            i=0;

            Point Od = new Point(0, pictureWykres.Height);
            Point Do = new Point(pictureWykres.Width, 0);

            pen.Width = 5.0F;

            int ktoraWersja0 = 0;
            int ktoraWersja1 = 0;
            int ktoraWersja2 = 0;
            int ktoraWersja3 = 0;
            int ktoraWersja4 = 0;
            int ktoraWersja5 = 0;
            if (wpisywanyWzor0.Text.IndexOf("^") > 0 || wpisywanyWzor0.Text.IndexOf("sin") > -1 || wpisywanyWzor0.Text.IndexOf("cos") > -1 || wpisywanyWzor0.Text.IndexOf("tg") > -1 || wpisywanyWzor0.Text.IndexOf("÷") > 0)
            {
                ktoraWersja0 = 1;
            }
            if (wpisywanyWzor1.Text.IndexOf("^") > 0 || wpisywanyWzor1.Text.IndexOf("sin") > -1 || wpisywanyWzor1.Text.IndexOf("cos") > -1 || wpisywanyWzor1.Text.IndexOf("tg") > -1 || wpisywanyWzor1.Text.IndexOf("÷") > 0)
            {
                ktoraWersja1 = 1;
            }
            if (wpisywanyWzor2.Text.IndexOf("^") > 0 || wpisywanyWzor2.Text.IndexOf("sin") > -1 || wpisywanyWzor2.Text.IndexOf("cos") > -1 || wpisywanyWzor2.Text.IndexOf("tg") > -1 || wpisywanyWzor2.Text.IndexOf("÷") > 0)
            {
                ktoraWersja2 = 1;
            }
            if (wpisywanyWzor3.Text.IndexOf("^") > 0 || wpisywanyWzor3.Text.IndexOf("sin") > -1 || wpisywanyWzor3.Text.IndexOf("cos") > -1 || wpisywanyWzor3.Text.IndexOf("tg") > -1 || wpisywanyWzor3.Text.IndexOf("÷") > 0)
            {
                ktoraWersja3 = 1;
            }
            if (wpisywanyWzor4.Text.IndexOf("^") > 0 || wpisywanyWzor4.Text.IndexOf("sin") > -1 || wpisywanyWzor4.Text.IndexOf("cos") > -1 || wpisywanyWzor4.Text.IndexOf("tg") > -1 || wpisywanyWzor4.Text.IndexOf("÷") > 0)
            {
                ktoraWersja4 = 1;
            }
            if (wpisywanyWzor5.Text.IndexOf("^") > 0 || wpisywanyWzor5.Text.IndexOf("sin") > -1 || wpisywanyWzor5.Text.IndexOf("cos") > -1 || wpisywanyWzor5.Text.IndexOf("tg") > -1 || wpisywanyWzor5.Text.IndexOf("÷") > 0)
            {
                ktoraWersja5 = 1;
            }

            if (ktoraWersja0 != 1)
            {
                if (wpisywanyWzor0.Text != "")
                {
                    pen.Color = System.Drawing.Color.Green;
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (-1)* granicaLewa) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), granicaPrawa) * wielkoscJednostki));
                    g.DrawLine(pen, Od, Do);
                    przesuniecie1L.Visible = true;

                    if (Od.Y != Do.Y)
                    {
                        przesuniecie1G.Visible = true;
                        przesuniecie1G.Location = new Point((panelWykresy.Location.X + (panelWykresy.Width / 2) - (przesuniecie1G.Width / 2)) - (int)((Parser(Konwersja(wpisywanyWzor0.Text, 0), 0) * wielkoscJednostki) / 2), przesuniecie1G.Location.Y);
                    }
                    else
                    {
                        przesuniecie1G.Visible = false;
                    }

                    przesuniecie1L.Location = new Point(panelWykresy.Location.X - przesuniecie1L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie1L.Height/2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                    if (przesuniecie1L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    {
                        
                        przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie1L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor0.Text, 0), 0) * wielkoscJednostki));

                        if (przesuniecie1L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - (przesuniecie1L.Height/2))
                        {
                            przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie1L.Height/2));
                        }
                    }
                    if (przesuniecie1L.Location.Y < panelWykresy.Location.Y)
                    {
                        przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y);
                    }
                    if (przesuniecie1G.Location.X < panelWykresy.Location.X - (przesuniecie1G.Height / 2) || przesuniecie1G.Location.X > panelWykresy.Location.X+panelWykresy.Width-(przesuniecie1G.Width/2))
                    {
                        przesuniecie1G.Visible = false;
                    }
                }
            }
            if (ktoraWersja1 != 1 && wpisywanyWzor1.Text != "")
            {
                pen.Color = System.Drawing.Color.Red;
                Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (-1) * granicaLewa) * wielkoscJednostki));
                Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), granicaPrawa) * wielkoscJednostki));
                g.DrawLine(pen, Od, Do);

                przesuniecie2L.Visible = true;

                if (Od.Y != Do.Y)
                {
                    przesuniecie2G.Visible = true;
                    przesuniecie2G.Location = new Point((panelWykresy.Location.X + (panelWykresy.Width / 2) - (przesuniecie2G.Width / 2)) - (int)((Parser(Konwersja(wpisywanyWzor1.Text, 0), 0) * wielkoscJednostki) / 2), przesuniecie2G.Location.Y);
                }
                else
                {
                    przesuniecie2G.Visible = false;
                }

                przesuniecie2L.Location = new Point(panelWykresy.Location.X - przesuniecie2L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie2L.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie2L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                {
                    przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie2L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor1.Text, 0), 0) * wielkoscJednostki));

                    if (przesuniecie2L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - (przesuniecie2L.Height / 2))
                    {
                        przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie2L.Height / 2));
                    }
                }
                if (przesuniecie2L.Location.Y < panelWykresy.Location.Y)
                {
                    przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, panelWykresy.Location.Y);
                }
                if (przesuniecie2G.Location.X < panelWykresy.Location.X - (przesuniecie2G.Height / 2) || przesuniecie2G.Location.X > panelWykresy.Location.X + panelWykresy.Width - (przesuniecie2G.Width / 2))
                {
                    przesuniecie2G.Visible = false;
                }

            }
            if (ktoraWersja2 != 1 && wpisywanyWzor2.Text != "")
            {

                pen.Color = System.Drawing.Color.Purple;
                Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (-1) * granicaLewa) * wielkoscJednostki));
                Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), granicaPrawa) * wielkoscJednostki));
                g.DrawLine(pen, Od, Do);

                przesuniecie3L.Visible = true;

                if (Od.Y != Do.Y)
                {
                    przesuniecie3G.Visible = true;
                    przesuniecie3G.Location = new Point((panelWykresy.Location.X + (panelWykresy.Width / 2) - (przesuniecie3G.Width / 2)) - (int)((Parser(Konwersja(wpisywanyWzor2.Text, 0), 0) * wielkoscJednostki) / 2), przesuniecie3G.Location.Y);
                }
                else
                {
                    przesuniecie3G.Visible = false;
                }

                przesuniecie3L.Location = new Point(panelWykresy.Location.X - przesuniecie3L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie3L.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie3L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                {
                    przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie3L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor2.Text, 0), 0) * wielkoscJednostki));
                    if (przesuniecie3L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - (przesuniecie3L.Height / 2))
                    {
                        przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie3L.Height / 2));
                    }
                }
                if (przesuniecie3L.Location.Y < panelWykresy.Location.Y)
                {
                    przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, panelWykresy.Location.Y);
                }
                if (przesuniecie3G.Location.X < panelWykresy.Location.X - (przesuniecie3G.Height / 2) || przesuniecie3G.Location.X > panelWykresy.Location.X + panelWykresy.Width - (przesuniecie3G.Width / 2))
                {
                    przesuniecie3G.Visible = false;
                }
            }
            if (ktoraWersja3 != 1 && wpisywanyWzor3.Text != "")
            {
                pen.Color = System.Drawing.Color.DarkOrange;
                Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (-1) * granicaLewa) * wielkoscJednostki));
                Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), granicaPrawa) * wielkoscJednostki));
                g.DrawLine(pen, Od, Do);

                przesuniecie4L.Visible = true;

                if (Od.Y != Do.Y)
                {
                    przesuniecie4G.Visible = true;
                    przesuniecie4G.Location = new Point((panelWykresy.Location.X + (panelWykresy.Width / 2) - (przesuniecie4G.Width / 2)) - (int)((Parser(Konwersja(wpisywanyWzor3.Text, 0), 0) * wielkoscJednostki) / 2), przesuniecie4G.Location.Y);
                }
                else
                {
                    przesuniecie4G.Visible = false;
                }

                przesuniecie4L.Location = new Point(panelWykresy.Location.X - przesuniecie4L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie4L.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie4L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                {
                    przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie4L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor3.Text, 0), 0) * wielkoscJednostki));
                    if (przesuniecie4L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - (przesuniecie4L.Height / 2))
                    {
                        przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie4L.Height / 2));
                    }
                }
                if (przesuniecie4L.Location.Y < panelWykresy.Location.Y)
                {
                    przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, panelWykresy.Location.Y);
                }
                if (przesuniecie4G.Location.X < panelWykresy.Location.X - (przesuniecie4G.Height / 2) || przesuniecie4G.Location.X > panelWykresy.Location.X+panelWykresy.Width-(przesuniecie4G.Width/2))
                {
                    przesuniecie4G.Visible = false;
                }
            }
            if (ktoraWersja4 != 1 && wpisywanyWzor4.Text != "")
            {
                pen.Color = System.Drawing.Color.Blue;
                Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (-1) * granicaLewa) * wielkoscJednostki));
                Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), granicaPrawa) * wielkoscJednostki));
                g.DrawLine(pen, Od, Do);

                przesuniecie5L.Visible = true;

                if (Od.Y != Do.Y)
                {
                    przesuniecie5G.Visible = true;
                    przesuniecie5G.Location = new Point((panelWykresy.Location.X + (panelWykresy.Width / 2) - (przesuniecie5G.Width / 2)) - (int)((Parser(Konwersja(wpisywanyWzor4.Text, 0), 0) * wielkoscJednostki) / 2), przesuniecie5G.Location.Y);
                }
                else
                {
                    przesuniecie5G.Visible = false;
                }

                przesuniecie5L.Location = new Point(panelWykresy.Location.X - przesuniecie5L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie5L.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie5L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                {
                    przesuniecie5L.Location = new Point(przesuniecie5L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie5L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor4.Text, 0), 0) * wielkoscJednostki));
                    if (przesuniecie5L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - (przesuniecie5L.Height / 2))
                    {
                        przesuniecie5L.Location = new Point(przesuniecie5L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie5L.Height / 2));
                    }
                }
                if (przesuniecie5L.Location.Y < panelWykresy.Location.Y)
                {
                    przesuniecie5L.Location = new Point(przesuniecie5L.Location.X, panelWykresy.Location.Y);
                }
                if (przesuniecie5G.Location.X < panelWykresy.Location.X - (przesuniecie5G.Height / 2) || przesuniecie5G.Location.X > panelWykresy.Location.X + panelWykresy.Width - (przesuniecie5G.Width / 2))
                {
                    przesuniecie5G.Visible = false;
                }
            }
            if (ktoraWersja5 != 1 && wpisywanyWzor5.Text != "")
            {
                pen.Color = System.Drawing.Color.DeepPink;
                Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (-1) * granicaLewa) * wielkoscJednostki));
                Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), granicaPrawa) * wielkoscJednostki));
                g.DrawLine(pen, Od, Do);

                przesuniecie6L.Visible = true;

                if (Od.Y != Do.Y)
                {
                    przesuniecie6G.Visible = true;
                    przesuniecie6G.Location = new Point((panelWykresy.Location.X + (panelWykresy.Width / 2) - (przesuniecie6G.Width / 2)) - (int)((Parser(Konwersja(wpisywanyWzor5.Text, 0), 0) * wielkoscJednostki) / 2), przesuniecie6G.Location.Y);
                }
                else
                {
                    przesuniecie6G.Visible = false;
                }

                przesuniecie6L.Location = new Point(panelWykresy.Location.X - przesuniecie6L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie6L.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie6L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                {
                    przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie6L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor5.Text, 0), 0) * wielkoscJednostki));
                    if (przesuniecie6L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - (przesuniecie6L.Height / 2))
                    {
                        przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie6L.Height / 2));
                    }
                }
                if (przesuniecie6L.Location.Y < panelWykresy.Location.Y)
                {
                    przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, panelWykresy.Location.Y);
                }
                if (przesuniecie6G.Location.X < panelWykresy.Location.X - (przesuniecie6G.Height / 2) || przesuniecie6G.Location.X > panelWykresy.Location.X + panelWykresy.Width - (przesuniecie6G.Width / 2))
                {
                    przesuniecie6G.Visible = false;
                }
            }

            pen.Width = 5.0F;
            double i2 = 0;
            int gruboscKrzychych = 5;
            double przesuniecie = wielkoscJednostki / (1 / oIlePrzeskokow);

            if (ktoraWersja0 == 1 && wpisywanyWzor0.Text != "")
            {
                //MessageBox.Show("A");
                pen.Color = System.Drawing.Color.Green;
                i2 = 0;
                for (przeskok = 0.0; przeskok < 10.0; przeskok = przeskok + oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) + i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) + i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                    
                }
                i2 = 0;
                for (przeskok = 0.0; przeskok > -10.01; przeskok = przeskok - oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) - i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) - i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if(Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki2 * 2));
                    i2 = i2 + przesuniecie;
                }
                przesuniecie1L.Location = new Point(panelWykresy.Location.X - przesuniecie1L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie1L.Height / 2) - (Parser(Konwersja(wpisywanyWzor0.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie1L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie1L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor0.Text, 0), 0) * wielkoscJednostki));
                przesuniecie1L.Visible = true;
                przesuniecie1G.Visible = true;
                if (przesuniecie1L.Location.Y < -1000)
                    przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie1L.Height / 2));
            }

            if (ktoraWersja1 == 1 && wpisywanyWzor1.Text != "")
            {
                pen.Color = System.Drawing.Color.Red;
                i2 = 0;
                for (przeskok = 0.0; przeskok < 10.0; przeskok = przeskok + oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) + i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) + i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                i2 = 0;
                for (przeskok = 0.0; przeskok > -10.01; przeskok = przeskok - oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) - i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) - i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                przesuniecie2L.Location = new Point(panelWykresy.Location.X - przesuniecie2L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie2L.Height / 2) - (Parser(Konwersja(wpisywanyWzor1.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie2L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie2L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor1.Text, 0), 0) * wielkoscJednostki));
                przesuniecie2L.Visible = true;
                przesuniecie2G.Visible = true;
            }

            if (ktoraWersja2 == 1 && wpisywanyWzor2.Text != "")
            {
                pen.Color = System.Drawing.Color.Purple;
                i2 = 0;
                for (przeskok = 0.0; przeskok < 10.0; przeskok = przeskok + oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) + i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) + i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                i2 = 0;
                for (przeskok = 0.0; przeskok > -10.01; przeskok = przeskok - oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) - i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) - i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                przesuniecie3L.Location = new Point(panelWykresy.Location.X - przesuniecie3L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie3L.Height / 2) - (Parser(Konwersja(wpisywanyWzor2.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie3L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie3L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor2.Text, 0), 0) * wielkoscJednostki));
                przesuniecie3L.Visible = true;
                przesuniecie3G.Visible = true;

            }

            if (ktoraWersja3 == 1 && wpisywanyWzor3.Text != "")
            {
                pen.Color = System.Drawing.Color.DarkOrange;
                i2 = 0;
                for (przeskok = 0.0; przeskok < 10.0; przeskok = przeskok + oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) + i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) + i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                i2 = 0;
                for (przeskok = 0.0; przeskok > -10.01; przeskok = przeskok - oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) - i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) - i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                przesuniecie4L.Location = new Point(panelWykresy.Location.X - przesuniecie4L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie2L.Height / 2) - (Parser(Konwersja(wpisywanyWzor3.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie4L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie3L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor4.Text, 0), 0) * wielkoscJednostki));
                przesuniecie4L.Visible = true;
                przesuniecie4G.Visible = true;
            }

            if (ktoraWersja4 == 1 && wpisywanyWzor4.Text != "")
            {
                pen.Color = System.Drawing.Color.Blue;
                i2 = 0;
                for (przeskok = 0.0; przeskok < 10.0; przeskok = przeskok + oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) + i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) + i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                i2 = 0;
                for (przeskok = 0.0; przeskok > -10.01; przeskok = przeskok - oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) - i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) - i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                przesuniecie5L.Location = new Point(panelWykresy.Location.X - przesuniecie5L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie5L.Height / 2) - (Parser(Konwersja(wpisywanyWzor4.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie5L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    przesuniecie2L.Location = new Point(przesuniecie5L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie5L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor4.Text, 0), 0) * wielkoscJednostki));
                przesuniecie5L.Visible = true;
                przesuniecie5G.Visible = true;

            }
            if (ktoraWersja5 == 1 && wpisywanyWzor5.Text != "")
            {
                pen.Color = System.Drawing.Color.DeepPink;
                i2 = 0;
                for (przeskok = 0.0; przeskok < 10.0; przeskok = przeskok + oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) + i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) + i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                i2 = 0;
                for (przeskok = 0.0; przeskok > -10.01; przeskok = przeskok - oIlePrzeskokow)
                {
                    Od.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Do.Y = (int)((pictureWykres.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (float)przeskok) * wielkoscJednostki));
                    Od.X = (int)((pictureWykres.Width / 2) - i2);
                    Do.X = gruboscKrzychych + (int)((pictureWykres.Width / 2) - i2);
                    if (Od.Y > -2147483648)
                        g.DrawLine(pen, Od, Do);
                    else
                    {
                        if (Dziedzina.Text.IndexOf(przeskok.ToString()) < 0)
                        {
                            if (Dziedzina.Text == "R")
                                Dziedzina.Text += "/{";
                            else
                                Dziedzina.Text = Dziedzina.Text.Replace('}', ',');
                            Dziedzina.Text += przeskok;
                        }

                    }
                    i = i + (int)(oIlePrzeskokow * (wielkoscJednostki * 2));
                    i2 = i2 + przesuniecie;
                }
                przesuniecie6L.Location = new Point(panelWykresy.Location.X - przesuniecie6L.Width, panelWykresy.Location.Y + (int)((pictureWykres.Height / 2) - (przesuniecie6L.Height / 2) - (Parser(Konwersja(wpisywanyWzor5.Text, 0), (-1) * granicaLewa) * wielkoscJednostki)));
                if (przesuniecie6L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height)
                    przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, panelWykresy.Location.Y + (panelWykresy.Height / 2) - (przesuniecie6L.Height / 2) - (int)(Parser(Konwersja(wpisywanyWzor5.Text, 0), 0) * wielkoscJednostki));
                przesuniecie6L.Visible = true;
                przesuniecie6L.Visible = true;

            }

           
            if(Dziedzina.Text!="R" && Dziedzina.Text[Dziedzina.TextLength-1]!='}')
                Dziedzina.Text += "}";
            pen.Dispose();
        }

        int ktoryTextBox = 0;
        int ktoreJuzBylo = 0;

        
        string[] liczbaText, dzialanieText;
        string dzialanieNawias = "", dzialanieNawias2 = "", dzialanieNawias3 = "", dzialanieNawias4 = "", dzialanieNawias5 = "", dzialanieNawias6 = "";
        string dzialanieNawiasWewnetrzny = "", dzialanieNawiasWewnetrzny2 = "", dzialanieNawiasWewnetrzny3 = "", dzialanieNawiasWewnetrzny4="";
        string text2;
        double[] liczba;
        int czyWyswietlicBlad = 0;  
        public double Parser(string text, float wartoscX)
        {           
            int i = 0, i2 = 0, i3 = 0, i4 = 0, i5 = 0, i6 = 0, i7=0, i8=0 ;
            liczbaText = new string[20];
            dzialanieNawias = "";
            dzialanieNawiasWewnetrzny = "";
            dzialanieNawiasWewnetrzny2 = "";
            dzialanieNawiasWewnetrzny3 = "";
            dzialanieNawiasWewnetrzny4 = "";
            dzialanieText = new string[5];
            liczba = new double[20];
            i2 = 0;
            i = 0;
            i5 = 0;
            int[] iloscNawiasow={0,0};
            for (i = 0; i < text.Length; i++)
            {
                if (text[i] == ')')
                    iloscNawiasow[0]++;
                if(text[i] == '(')
                    iloscNawiasow[1]++;
            }
            if (iloscNawiasow[0] != iloscNawiasow[1])
            {
                czyWyswietlicBlad = 1;
                return 0;
            }
            i = 0;

            text2 = text.Replace("x", wartoscX.ToString());

            text2 = text2.Replace("π", "3.14");
            text2 = text2.Replace(".",",");
            
            for (i = 0; i2 < text2.Length; i++)
            {
                if (i2 < text2.Length && text2[i2] == '(')
                {
                    i3 = i2 + 1;
                    while (i3 < text2.Length && text2[i3] != ')')
                    {
                        if (text2[i3] == '(')
                        {
                            i5=i3+1;
                            while(i5 < text2.Length && text2[i5] != ')')
                            {
                                if (text2[i5] == '(')
                                {
                                    i6 = i5 + 1;
                                    while (i6 < text2.Length && text2[i6] != ')')
                                    {
                                        if (text2[i6] == '(')
                                        {
                                            i7 = i6 + 1;
                                            while (i7 < text2.Length && text2[i7] != ')')
                                            {
                                                if (text2[i7] == '(')
                                                {
                                                    i8 = i7 + 1;
                                                    while (i8 < text2.Length && text2[i8] != ')')
                                                    {

                                                        dzialanieNawiasWewnetrzny4 += text2[i8];
                                                        i8++;
                                                    }

                                                    string nawiasyTemp5 = "(" + dzialanieNawiasWewnetrzny4 + ")";
                                                    text2 = text2.Replace(nawiasyTemp5, Parser(dzialanieNawiasWewnetrzny4, wartoscX).ToString());

                                                    return Parser(text2, wartoscX);
                                                }
                                                dzialanieNawiasWewnetrzny3 += text2[i7];
                                                i7++;
                                            }

                                            string nawiasyTemp4 = "(" + dzialanieNawiasWewnetrzny3 + ")";
                                            text2 = text2.Replace(nawiasyTemp4, Parser(dzialanieNawiasWewnetrzny3, wartoscX).ToString());

                                            return Parser(text2, wartoscX);
                                        }
                                        dzialanieNawiasWewnetrzny2 += text2[i6];
                                        i6++;
                                    }

                                    string nawiasyTemp3 = "(" + dzialanieNawiasWewnetrzny2 + ")";
                                    text2 = text2.Replace(nawiasyTemp3, Parser(dzialanieNawiasWewnetrzny2, wartoscX).ToString());

                                    return Parser(text2, wartoscX);
                                }
                                dzialanieNawiasWewnetrzny += text2[i5];
                                i5++;
                                
                            }
                            string nawiasyTemp2 = "(" + dzialanieNawiasWewnetrzny + ")";
                            text2 = text2.Replace(nawiasyTemp2, Parser(dzialanieNawiasWewnetrzny, wartoscX).ToString());
                            
                            return Parser(text2, wartoscX);
                        }
                        
                        dzialanieNawias += text2[i3];
                        i3++;
                        i4++;
                    }
                    string nawiasyTemp="";
                    int ileRoznicy = i2 - i4;
                    
                    nawiasyTemp = "(" + dzialanieNawias + ")";                                           
                    text2 = text2.Replace(nawiasyTemp, Parser(dzialanieNawias, wartoscX).ToString());
                    return Parser(text2, wartoscX);
                }

                if (text2[i2] == 's' && text2[i2 + 1] == 'q' && dzialanieNawias2 == "")
                {
                    i3 = i2;
                    while (i3 < text2.Length && text2[i3] != ')')
                    {
                        dzialanieNawias2 += text2[i3];
                        i3++;
                    }
                    dzialanieNawias2 += ')';
                    text2 = text2.Replace(dzialanieNawias2, Parser(dzialanieNawias2, wartoscX).ToString());
                    return Parser(text2, wartoscX);
                }
                if (text2[i2] == 's' && text2[i2 + 1] == 'i' && dzialanieNawias3 == "")
                {
                    i3 = i2;
                    while (i3 < text2.Length && text2[i3] != ')')
                    {
                        dzialanieNawias3 += text2[i3];
                        i3++;
                    }
                    dzialanieNawias3 += ')';
                    text2 = text2.Replace(dzialanieNawias3, Parser(dzialanieNawias3, wartoscX).ToString());
                    return Parser(text2, wartoscX);
                }
                if (text2[i2] == 'c' && text2[i2 + 1] == 'o' && dzialanieNawias4 == "")
                {
                    i3 = i2;
                    while (i3 < text2.Length && text2[i3] != ')')
                    {
                        dzialanieNawias4 += text2[i3];
                        i3++;
                    }
                    dzialanieNawias4 += ')';
                    text2 = text2.Replace(dzialanieNawias4, Parser(dzialanieNawias4, wartoscX).ToString());
                    return Parser(text2, wartoscX);
                }
                if (text2[i2] == 't' && text2[i2 + 1] == 'g' && dzialanieNawias5 == "")
                {
                    i3 = i2;
                    while (i3 < text2.Length && text2[i3] != ')')
                    {
                        dzialanieNawias5 += text2[i3];
                        i3++;
                    }
                    dzialanieNawias5 += ')';
                    text2 = text2.Replace(dzialanieNawias5, Parser(dzialanieNawias5, wartoscX).ToString());
                    return Parser(text2, wartoscX);
                }
               

                while (i2 < text2.Length && text2[i2] != '*' && text2[i2] != '+' && text2[i2] != '#' && text2[i2] != '/' && text2[i2] != 's' && text2[i2] != '^' && text2[i2] != 'c' && text2[i2] != 't')
                {
                    liczbaText[i] += text2[i2];
                    i2++;
                }
                if (i<text2.Length && i2 < text2.Length && i<dzialanieText.Length)
                {
                   //blad
                    //MessageBox.Show(text2.Length + "vs" + i2 + "vs" + i);
                    dzialanieText[i] = text2[i2].ToString();
                    if (text2[i2] == 's' && text2[i2+1] == 'q')
                    {
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                    }
                    if (text2[i2] == 's' && text2[i2 + 1] == 'i')
                    {
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                    }
                    if (text2[i2] == 'c')
                    {
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                    }
                    if (text2[i2] == 't' && text2[i2+1] == 'g')
                    {
                        i2++;
                        dzialanieText[i] += text2[i2].ToString();
                    }
                }
                i2++;

                
            }

            double.TryParse(liczbaText[0], out liczba[0]);
            double.TryParse(liczbaText[1], out liczba[1]);
            double.TryParse(liczbaText[2], out liczba[2]);
            double.TryParse(liczbaText[3], out liczba[3]);
            double.TryParse(liczbaText[4], out liczba[4]);
            double.TryParse(liczbaText[5], out liczba[5]);


            double suma = 0;
            if (dzialanieText[0] == "*")
            {
                suma = liczba[0] * liczba[1];
            }
            if (dzialanieText[0] == "+")
            {
                suma = liczba[0] + liczba[1];
            }
            if (dzialanieText[0] == "#")
            {
                suma = liczba[0] - liczba[1];
            }
            if (dzialanieText[0] == "/")
            {
                suma = liczba[0] / liczba[1];
            }
            if (dzialanieText[0] == "^")
            {
                suma = Math.Pow(liczba[0], liczba[1]);
            }
            if (dzialanieText[0] == "sqrt")
            {
                suma = Math.Sqrt(liczba[1]);
                dzialanieNawias2 = "";
            }
            if (dzialanieText[0] == "sin")
            {
                suma = Math.Sin(liczba[1]);
                dzialanieNawias3 = "";
            }
            if (dzialanieText[0] == "cos")
            {
                suma = Math.Cos(liczba[1]);
                dzialanieNawias4 = "";
            }
            if (dzialanieText[0] == "tg")
            {
                suma = Math.Tan(liczba[1]);
                dzialanieNawias5 = "";
            }
            if (liczbaText[1] == null)
            {
                suma = liczba[0];
            }

            if (dzialanieText[1] == "*")
            {
                suma = suma * liczba[2];
            }
            if (dzialanieText[1] == "+")
            {
                suma = suma + liczba[2];
            }
            if (dzialanieText[1] == "#")
            {
                suma = suma - liczba[2];
            }
            if (dzialanieText[1] == "/")
            {
                suma = suma / liczba[2];
            }
            if (dzialanieText[1] == "^")
            {
                suma = Math.Pow(suma, liczba[2]);
            }
            /*
            if (liczbaText[2] == null)
            {
                suma = liczba[0];
            }

            */
            //MessageBox.Show(dzialanieText[2] + "vs" + liczba[3]);
            if (dzialanieText[2] == "*")
            {
                suma = suma * liczba[3];
            }
            if (dzialanieText[2] == "+")
            {
                suma = suma + liczba[3];
            }
            if (dzialanieText[2] == "#")
            {
                suma = suma - liczba[3];
            }
            if (dzialanieText[2] == "/")
            {
                suma = suma / liczba[3];
            }
            if (dzialanieText[2] == "^")
            {
                suma = Math.Pow(suma, liczba[3]);
            }

            if (dzialanieText[3] == "*")
            {
                suma = suma * liczba[4];
            }
            if (dzialanieText[3] == "+")
            {
                suma = suma + liczba[4];
            }
            if (dzialanieText[3] == "#")
            {
                suma = suma - liczba[4];
            }
            if (dzialanieText[3] == "/")
            {
                suma = suma / liczba[4];
            }
            if (dzialanieText[3] == "^")
            {
                suma = Math.Pow(suma, liczba[4]);
            }

            if (dzialanieText[4] == "*")
            {
                suma = suma * liczba[5];
            }
            if (dzialanieText[4] == "+")
            {
                suma = suma + liczba[5];
            }
            if (dzialanieText[4] == "#")
            {
                suma = suma - liczba[5];
            }
            if (dzialanieText[4] == "/")
            {
                suma = suma / liczba[5];
            }
            if (dzialanieText[4] == "^")
            {
                suma = Math.Pow(suma, liczba[5]);
            }

            return suma;
            
        }


        string Konwersja(string konwertowanyTekst, int ktoraWersja)
        {
            int i = 0, i2 = 0;
            string konwersjaWzoru;
            konwersjaWzoru = konwertowanyTekst;
            konwersjaWzoru = konwersjaWzoru.Replace("√", "sqrt");
            konwersjaWzoru = konwersjaWzoru.Replace("÷", "/");
            konwersjaWzoru = konwersjaWzoru.Replace("-", "#");

            int gdzieDoPotegi = konwersjaWzoru.IndexOf("^");

            gdzieDoPotegi = 0;
            while (ktoreJuzBylo <= konwersjaWzoru.Length && gdzieDoPotegi >= 0)
            {
                gdzieDoPotegi = konwersjaWzoru.IndexOf("(", ktoreJuzBylo);
                ktoreJuzBylo = gdzieDoPotegi + 1;



                if (gdzieDoPotegi >= 1 && gdzieDoPotegi < konwersjaWzoru.Length - 1 && (konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "1" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "0" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "x" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == ")"))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, "*(");
                }

            }

            gdzieDoPotegi = 0;
            while (ktoreJuzBylo <= konwersjaWzoru.Length && gdzieDoPotegi >= 0)
            {
                gdzieDoPotegi = konwersjaWzoru.IndexOf(")", ktoreJuzBylo);
                ktoreJuzBylo = gdzieDoPotegi + 1;

                if (gdzieDoPotegi >= 0 && gdzieDoPotegi < konwersjaWzoru.Length - 1 && (konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "1" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "0" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "x" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "("))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, ")*");
                }
            }

            gdzieDoPotegi = 0;
            while (ktoreJuzBylo <= konwersjaWzoru.Length && gdzieDoPotegi >= 0)
            {
                gdzieDoPotegi = konwersjaWzoru.IndexOf("s", ktoreJuzBylo);
                ktoreJuzBylo = gdzieDoPotegi + 1;
                if (gdzieDoPotegi >= 1 && (gdzieDoPotegi < konwersjaWzoru.Length - 1 && (konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "1" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "0" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "x" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "(") ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == ")"))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, "*s");
                }
            }

            gdzieDoPotegi = 0;
            while (ktoreJuzBylo <= konwersjaWzoru.Length && gdzieDoPotegi >= 0)
            {
                gdzieDoPotegi = konwersjaWzoru.IndexOf("x", ktoreJuzBylo);
                ktoreJuzBylo = gdzieDoPotegi + 1;

                if (gdzieDoPotegi >= 0 && gdzieDoPotegi < konwersjaWzoru.Length - 1 && (konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "1" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "0"))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, "x*");
                }
                if (gdzieDoPotegi >= 0 && gdzieDoPotegi > 0 && (konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "1" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "0"))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, "*x");
                }
            }

            gdzieDoPotegi = 0;
            while (ktoreJuzBylo <= konwersjaWzoru.Length && gdzieDoPotegi >= 0)
            {
                gdzieDoPotegi = konwersjaWzoru.IndexOf("π", ktoreJuzBylo);
                ktoreJuzBylo = gdzieDoPotegi + 1;

                if (gdzieDoPotegi >= 0 && gdzieDoPotegi < konwersjaWzoru.Length - 1 && (konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "1" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi + 1].ToString() == "0"))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, "π*");
                }
                if (gdzieDoPotegi >= 0 && gdzieDoPotegi > 0 && (konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "1" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "2" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "3" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "4" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "5" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "6" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "7" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "8" ||
                    konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "9" || konwersjaWzoru[gdzieDoPotegi - 1].ToString() == "0"))
                {
                    konwersjaWzoru = konwersjaWzoru.Remove(gdzieDoPotegi, 1).Insert(gdzieDoPotegi, "*π");
                }
            }


            
            i = 0;
            i2 = 0;
            if (gdzieDoPotegi > 0)
            {
                while ((gdzieDoPotegi - i > 0) && (konwersjaWzoru[gdzieDoPotegi - i] != '+' && konwersjaWzoru[gdzieDoPotegi - i] != '#' && konwersjaWzoru[gdzieDoPotegi - i] != '*' && konwersjaWzoru[gdzieDoPotegi - i] != '/' && konwersjaWzoru[gdzieDoPotegi - i] != '('))
                {
                    i++;
                }
                if (gdzieDoPotegi - i == 0)
                    konwersjaWzoru = konwersjaWzoru.Insert(gdzieDoPotegi - i, "(");
                if (gdzieDoPotegi - i > 0)
                    konwersjaWzoru = konwersjaWzoru.Insert(gdzieDoPotegi - i + 1, "(");
                while ((gdzieDoPotegi + i2 < konwersjaWzoru.Length) && konwersjaWzoru[gdzieDoPotegi + i2] != '+' && konwersjaWzoru[gdzieDoPotegi + i2] != '*' && konwersjaWzoru[gdzieDoPotegi + i2] != '#' && konwersjaWzoru[gdzieDoPotegi + i2] != '/' && konwersjaWzoru[gdzieDoPotegi + i2] != ')')
                {
                    i2++;
                }
                konwersjaWzoru = konwersjaWzoru.Insert(gdzieDoPotegi + i2, ")");
            }
            int gdzieMnozenie = konwersjaWzoru.IndexOf("*");
            i = 0;
            i2 = 0;
            if (gdzieMnozenie > 0)
            {
                while ((gdzieMnozenie - i > 0) && (konwersjaWzoru[gdzieMnozenie - i] != '+' && konwersjaWzoru[gdzieMnozenie - i] != '#' && konwersjaWzoru[gdzieMnozenie - i] != '/' && konwersjaWzoru[gdzieMnozenie - i] != '^' && konwersjaWzoru[gdzieMnozenie - i] != '(' ))
                {
                    i++;
                }
                if(gdzieMnozenie-i==0)
                    konwersjaWzoru = konwersjaWzoru.Insert(gdzieMnozenie-i, "(");
                if (gdzieMnozenie - i > 0)
                    konwersjaWzoru = konwersjaWzoru.Insert(gdzieMnozenie - i + 1, "(");
                while ((gdzieMnozenie + i2 < konwersjaWzoru.Length) && konwersjaWzoru[gdzieMnozenie + i2] != '+' && konwersjaWzoru[gdzieMnozenie + i2] != '#' && konwersjaWzoru[gdzieMnozenie + i2] != '^' && konwersjaWzoru[gdzieMnozenie + i2] != '/' && konwersjaWzoru[gdzieMnozenie + i2] != ')' && konwersjaWzoru[gdzieMnozenie + i2] != '(')
                {
                    i2++;
                }
                if (gdzieMnozenie+i2<konwersjaWzoru.Length && konwersjaWzoru[gdzieMnozenie + i2] == '(')
                    i2 = konwersjaWzoru.IndexOf(")", i2);
                konwersjaWzoru = konwersjaWzoru.Insert(gdzieMnozenie+i2, ")");
            }


            if(ktoraWersja==0)
                Parser(konwersjaWzoru, 1);

            return konwersjaWzoru;
        }

        /*
        public void zapisDoPliku(object sender, EventArgs e)
        {

            int i = 0;
            if ((this.ActiveControl.Name.ToString() == "wpisywanyWzor" && ktoryTextBox > 0) || (this.ActiveControl.Name.ToString() == "wpisywanyWzor1" && ktoryTextBox > 1)
                || (this.ActiveControl.Name.ToString() == "wpisywanyWzor2" && ktoryTextBox > 2) || (this.ActiveControl.Name.ToString() == "wpisywanyWzor3" && ktoryTextBox > 3)
                || (this.ActiveControl.Name.ToString() == "wpisywanyWzor4" && ktoryTextBox > 4) || (this.ActiveControl.Name.ToString() == "wpisywanyWzor5" && ktoryTextBox > 5)
                || (this.ActiveControl.Name.ToString() == "wpisywanyWzor6" && ktoryTextBox > 6))
            {
                string[] wczytanyWzorDoZmiany;
                wczytanyWzorDoZmiany = new string[10];
                if (wpisywanyWzor0.Text != "")
                    wczytanyWzorDoZmiany[0] = Konwersja(wpisywanyWzor0.Text, 0);
                if (wpisywanyWzor1.Text != "")
                    wczytanyWzorDoZmiany[1] = Konwersja(wpisywanyWzor1.Text, 0);
                if (wpisywanyWzor2.Text != "")
                    wczytanyWzorDoZmiany[2] = Konwersja(wpisywanyWzor2.Text, 0);
                if (wpisywanyWzor3.Text != "")
                    wczytanyWzorDoZmiany[3] = Konwersja(wpisywanyWzor3.Text, 0);
                if (wpisywanyWzor4.Text != "")
                    wczytanyWzorDoZmiany[4] = Konwersja(wpisywanyWzor4.Text, 0);
                if (wpisywanyWzor5.Text != "")
                    wczytanyWzorDoZmiany[5] = Konwersja(wpisywanyWzor5.Text, 0);

                plik = new FileStream("wzory.txt", FileMode.Create, FileAccess.Write);
                zapisuj = new StreamWriter(plik);
                while (wczytanyWzorDoZmiany[i] != null)
                {
                    zapisuj.WriteLine(wczytanyWzorDoZmiany[i]);
                    
                    i++;
                }
                zapisuj.Close();
                plik.Close();
            }
            
            
        }
        */
        public void zapisywanie(TextBox textBox, Label napisFx, Button ktoryClear, TextBox doZapisuText)
        {
            textBox.Visible = true;
            textBox.Focus();
            napisFx.Visible = true;
            ktoryClear.Visible = true;

            gotowyWzor = Konwersja(doZapisuText.Text, 1);
            

            string[] wczytanyWzorDoZmiany;
            wczytanyWzorDoZmiany = new string[10];
            if (wpisywanyWzor0.Text != "")
                wczytanyWzorDoZmiany[0] = Konwersja(wpisywanyWzor0.Text, 0);
            if (wpisywanyWzor1.Text != "")
                wczytanyWzorDoZmiany[1] = Konwersja(wpisywanyWzor1.Text, 0);
            if (wpisywanyWzor2.Text != "")
                wczytanyWzorDoZmiany[2] = Konwersja(wpisywanyWzor2.Text, 0);
            if (wpisywanyWzor3.Text != "")
                wczytanyWzorDoZmiany[3] = Konwersja(wpisywanyWzor3.Text, 0);
            if (wpisywanyWzor4.Text != "")
                wczytanyWzorDoZmiany[4] = Konwersja(wpisywanyWzor4.Text, 0);
            if (wpisywanyWzor5.Text != "")
                wczytanyWzorDoZmiany[5] = Konwersja(wpisywanyWzor5.Text, 0);


            /*
            int i = 0;
            plik = new FileStream("wzory.txt", FileMode.Create, FileAccess.Write);
            zapisuj = new StreamWriter(plik);
            while (wczytanyWzorDoZmiany[i] != null)
            {
                zapisuj.WriteLine(wczytanyWzorDoZmiany[i]);
                i++;
            }
            zapisuj.Close();
            plik.Close();*/
        }
        


        string gotowyWzor;
        public void klawiatura(object sender, EventArgs e)
        {
            StringBuilder tekst = new StringBuilder();
            tekst.Insert(0, this.ActiveControl.Text);
            //int i;
            string calyWzor;
            string tekstPrzycisku = sender.ToString();
            int dlugoscTekstu = tekstPrzycisku.Length;
            char idPrzycisku = tekstPrzycisku[dlugoscTekstu-1];
            string wpisanyTekst = this.ActiveControl.Text;
            int dlugoscWpisanegoTekstu = wpisanyTekst.Length;
            //double obliczanieDziedziny;
            if (idPrzycisku.ToString() == "R")
            {
                czyWyswietlicBlad = 0;
                
                ktoraPozycja = 0;
                calyWzor = wpisanyTekst;
                ktoryTextBox++;
                if (wpisywanyWzor1.Text != "" && ktoryTextBox == 1)
                    ktoryTextBox++;
                if (wpisywanyWzor2.Text != "" && ktoryTextBox == 2)
                    ktoryTextBox++;
                if (wpisywanyWzor3.Text != "" && ktoryTextBox == 3)
                    ktoryTextBox++;
                if (wpisywanyWzor4.Text != "" && ktoryTextBox == 4)
                    ktoryTextBox++;
                if (wpisywanyWzor5.Text != "" && ktoryTextBox == 5)
                    ktoryTextBox++;

                wzorDoKtoregoPunkt.Maximum = ktoryTextBox;

                if (wpisywanyWzor1.Text == "" && ktoryTextBox > 1)
                    ktoryTextBox = 1;
                if (wpisywanyWzor2.Text == "" && ktoryTextBox > 2)
                    ktoryTextBox = 2;
                if (wpisywanyWzor3.Text == "" && ktoryTextBox > 3)
                    ktoryTextBox = 3;
                if (wpisywanyWzor4.Text == "" && ktoryTextBox > 4)
                    ktoryTextBox = 4;
                if (wpisywanyWzor5.Text == "" && ktoryTextBox > 5)
                    ktoryTextBox = 5;

                
                if (ktoryTextBox == 1)
                    zapisywanie(wpisywanyWzor1, fx2, clear2, wpisywanyWzor0);
                if (ktoryTextBox == 2)
                    zapisywanie(wpisywanyWzor2, fx3, clear3, wpisywanyWzor1);
                if (ktoryTextBox == 3)
                    zapisywanie(wpisywanyWzor3, fx4, clear4, wpisywanyWzor2);
                if (ktoryTextBox == 4)
                    zapisywanie(wpisywanyWzor4, fx5, clear5, wpisywanyWzor3);
                if (ktoryTextBox == 5)
                    zapisywanie(wpisywanyWzor5, fx6, clear6, wpisywanyWzor4);
                if (ktoryTextBox == 6)
                {
                    gotowyWzor = Konwersja(wpisywanyWzor5.Text, 1);

                    /*plik = new FileStream("wzory.txt", FileMode.Append, FileAccess.Write);
                    zapisuj = new StreamWriter(plik);
                    zapisuj.WriteLine(gotowyWzor);
                    zapisuj.Close();
                    plik.Close();*/
                }
                if (gotowyWzor.IndexOf("^") >= 0)
                    RysowanieWykresu(1);
                else
                    RysowanieWykresu(0);



            }
            else if (idPrzycisku.ToString() == "←")
            {
                if (this.ActiveControl.Text != "" && ktoraPozycja!=0)
                {
                    if (this.ActiveControl.Name != "granicaL" && this.ActiveControl.Name != "granicaP")
                    {
                        tekst.Remove(ktoraPozycja - 1, 1);
                        ktoraPozycja--;
                        this.ActiveControl.Text = tekst.ToString();
                    }
                    

                }

            }
            else if (idPrzycisku.ToString() == "n")
            {
                tekst.Insert(ktoraPozycja, "sin(");
                ktoraPozycja=ktoraPozycja+4;
                this.ActiveControl.Text = tekst.ToString();
            }
            else if (idPrzycisku.ToString() == "s")
            {
                tekst.Insert(ktoraPozycja, "cos(");
                ktoraPozycja = ktoraPozycja + 4; 
                this.ActiveControl.Text = tekst.ToString();
            }
            else if (idPrzycisku.ToString() == "g")
            {
                tekst.Insert(ktoraPozycja, "tg(");
                ktoraPozycja=ktoraPozycja + 3; 
                this.ActiveControl.Text = tekst.ToString();
            }
            else if (idPrzycisku.ToString() == "π")
            {
                tekst.Insert(ktoraPozycja, "π");
                ktoraPozycja = ktoraPozycja + 4;
                this.ActiveControl.Text = tekst.ToString();
            }
            else if (idPrzycisku.ToString() == "√")
            {
                tekst.Insert(ktoraPozycja, idPrzycisku+"(");
                ktoraPozycja = ktoraPozycja+2;
                this.ActiveControl.Text = tekst.ToString();
            }
            else
            {
                if (tekst.Length < ktoraPozycja)
                    ktoraPozycja = tekst.Length;
                tekst.Insert(ktoraPozycja, idPrzycisku);
                ktoraPozycja++;
                this.ActiveControl.Text = tekst.ToString();
            }

        }
        public int ktoraPozycja = 0;
        
        private void openKey_Click(object sender, EventArgs e)
        {
            int czyZmienicFocus = 0;
            if (this.ActiveControl.Name == "granicaP" || this.ActiveControl.Name == "granicaL" || this.ActiveControl.Name == "PunktX" || this.ActiveControl.Name == "PunktY")
            {
                czyZmienicFocus = 1;
            }
            if (openKey.Visible == true)
            {
                wlaczanieKlawiszy();
                openKey.Visible = false;
                if (ktoryTextBox == 0)
                {
                    wpisywanyWzor0.Visible = true;
                    if(czyZmienicFocus==0)
                        wpisywanyWzor0.Focus();
                    fx1.Visible = true;
                    clear1.Visible = true;

                }
                if (ktoryTextBox == 1)
                {
                    wpisywanyWzor1.Visible = true;
                    if (czyZmienicFocus == 0)
                        wpisywanyWzor1.Focus();
                    fx2.Visible = true;
                    clear2.Visible = true;

                }
                if (ktoryTextBox == 2)
                {
                    wpisywanyWzor2.Visible = true;
                    if (czyZmienicFocus == 0)
                        wpisywanyWzor2.Focus();
                    fx3.Visible = true;
                    clear3.Visible = true;
                }
                if (ktoryTextBox == 3)
                {
                    wpisywanyWzor3.Visible = true;
                    if (czyZmienicFocus == 0)
                        wpisywanyWzor3.Focus();
                    fx4.Visible = true;
                    clear4.Visible = true;
                }
                if (ktoryTextBox == 4)
                {
                    wpisywanyWzor4.Visible = true;
                    if (czyZmienicFocus == 0)
                        wpisywanyWzor4.Focus();
                    fx5.Visible = true;
                    clear5.Visible = true;
                }
                if (ktoryTextBox == 5)
                {
                    wpisywanyWzor5.Visible = true;
                    if (czyZmienicFocus == 0)
                        wpisywanyWzor5.Focus();
                    fx6.Visible = true;
                    clear6.Visible = true;
                }
            }


        }

       

        private void wpisywanyWzor_Click(object sender, EventArgs e)
        {
            ktoraPozycja = wpisywanyWzor0.SelectionStart;
        }
        private void wpisywanyWzor1_Click(object sender, EventArgs e)
        {
            ktoraPozycja = wpisywanyWzor1.SelectionStart;

        }
        private void wpisywanyWzor2_Click(object sender, EventArgs e)
        {
            ktoraPozycja = wpisywanyWzor2.SelectionStart;
        }
        private void wpisywanyWzor3_Click(object sender, EventArgs e)
        {
            ktoraPozycja = wpisywanyWzor3.SelectionStart;
        }
        private void wpisywanyWzor4_Click(object sender, EventArgs e)
        {
            ktoraPozycja = wpisywanyWzor4.SelectionStart;
        }
        private void wpisywanyWzor5_Click(object sender, EventArgs e)
        {
            ktoraPozycja = wpisywanyWzor5.SelectionStart;
        }

        private void wlaczenieInstrukcji_Click(object sender, EventArgs e)
        {
            Instrukcja instrukcja = new Instrukcja();
            instrukcja.Show();
            instrukcja.TopMost = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            kalkulator.Close();
            openKey.Visible = true;
        }

        private void panelWzory_Click(object sender, EventArgs e)
        {

            kalkulator.Close(); 
            openKey.Visible = true;
        }

        private void panelWykresy_Click(object sender, EventArgs e)
        {
            kalkulator.Close();
            openKey.Visible = true;
        }
        private void PanelSprPunkt_Click(object sender, EventArgs e)
        {
            kalkulator.Close();
            openKey.Visible = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //zapisGranic(granicaL.Text, granicaP.Text);
            granicaP.Text = granicaL.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //zapisGranic(granicaL.Text, granicaP.Text);
            granicaL.Text = granicaP.Text;
        }

        private void sprawdzPunktPrzycisk_Click(object sender, EventArgs e)
        {
            float punktXDoSprawdzenia, punktYDoSprawdzenia;
            int numerWzoruDoSprawdzenia;
            float.TryParse(PunktX.Text, out punktXDoSprawdzenia);
            float.TryParse(PunktY.Text, out punktYDoSprawdzenia);
            int.TryParse(wzorDoKtoregoPunkt.Text, out numerWzoruDoSprawdzenia);
            
            string wzorDoSprawdzeniaP;
            switch(numerWzoruDoSprawdzenia)
            {
                case 1:
                    wzorDoSprawdzeniaP = wpisywanyWzor0.Text;
                    break;
                case 2:
                    wzorDoSprawdzeniaP = wpisywanyWzor1.Text;
                    break;
                case 3:
                    wzorDoSprawdzeniaP = wpisywanyWzor2.Text;
                    break;
                case 4:
                    wzorDoSprawdzeniaP = wpisywanyWzor3.Text;
                    break;
                case 5:
                    wzorDoSprawdzeniaP = wpisywanyWzor4.Text;
                    break;
                default:
                    wzorDoSprawdzeniaP = "1";
                    break;


            }

            double test = Parser(Konwersja(wzorDoSprawdzeniaP, 0), punktXDoSprawdzenia);
            if (test == punktYDoSprawdzenia)
                WynikPunkt.Text = "Prawda";
            else
                WynikPunkt.Text = "Fałsz";

        }

        private void granicaL_Click(object sender, EventArgs e)
        {
            granicaL.Text = "";
        }

        private void granicaP_Click(object sender, EventArgs e)
        {
            granicaP.Text = "";
        }

        private void pictureWykres_Click(object sender, EventArgs e)
        {
            kalkulator.Close();
            openKey.Visible = true;
        }

        private void Dziedzina_Click(object sender, EventArgs e)
        {
            kalkulator.Close();
            openKey.Visible = true;
        }

        #region przesuwanieWykres1
        int czyPrzesuwacWykres1L = 0;
        int pozycja1L = 0;
        double zmiana1L = 0;
        double staraZmiana1L = 0;
        private void przesuniecieL_MouseDown(object sender, MouseEventArgs e)
        {
            //staraZmiana = 0;
            czyPrzesuwacWykres1L = 1;
            pozycja1L = przesuniecie1L.Location.Y;
            if (zmiana1L != 0)
                staraZmiana1L = zmiana1L;
        }


        private void przesuniecieL_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres1L == 1)
            {
                przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, Cursor.Position.Y - przesuniecie1L.Width);
                zerowanie = przesuniecie1L.Location.Y;
                zmiana1L = (pozycja1L - przesuniecie1L.Location.Y) / wielkoscJednostki;

            }
            if (przesuniecie1L.Location.Y < panelWykresy.Location.Y - 10)
            {
                czyPrzesuwacWykres1L = 0;
                przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y);
            }
            if (przesuniecie1L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - przesuniecie1L.Height + 10)
            {
                czyPrzesuwacWykres1L = 0;
                przesuniecie1L.Location = new Point(przesuniecie1L.Location.X, panelWykresy.Location.Y + panelWykresy.Height - przesuniecie1L.Height);
            }
        }

        private void przesuniecieL_MouseUp(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres1L = 0;
            decimal zaokraglanie1L = (decimal)zmiana1L;
            zaokraglanie1L = System.Decimal.Round(zaokraglanie1L, 2);
            decimal zaokraglanieStare1L = (decimal)staraZmiana1L;
            zaokraglanieStare1L = System.Decimal.Round(zaokraglanieStare1L, 2);
            zaokraglanie1L += zaokraglanieStare1L;
            wpisywanyWzor0.Text = wpisywanyWzor0.Text.Replace("+(" + zaokraglanieStare1L.ToString("0.00")+")", "");
            wpisywanyWzor0.Text += "+(" + zaokraglanie1L+")";
            zmiana1L = (double)zaokraglanie1L;
            RysowanieWykresu(0);
        }

        int czyPrzesuwacWykres1G = 0;
        int pozycja1G = 0;
        double zmiana1G = 0;
        double staraZmiana1G = 0;

        private void przesuniecieG_MouseDown(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres1G = 1;
            pozycja1G = przesuniecie1G.Location.X;
            if (zmiana1G != 0)
                staraZmiana1G = zmiana1G;
        }

        private void przesuniecieG_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Width / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres1G == 1)
            {
                przesuniecie1G.Location = new Point(Cursor.Position.X - (przesuniecie1G.Width/2), przesuniecie1G.Location.Y);
                zerowanie = przesuniecie1G.Location.X;
                zmiana1G = (pozycja1G - przesuniecie1G.Location.X) / wielkoscJednostki;

            }
            if (przesuniecie1G.Location.X < panelWykresy.Location.X - 10)
            {
                czyPrzesuwacWykres1G = 0;
                przesuniecie1G.Location = new Point(panelWykresy.Location.X, przesuniecie1G.Location.Y);
            }
            if (przesuniecie1G.Location.X > panelWykresy.Location.X + panelWykresy.Width - przesuniecie1G.Width + 10)
            {
                czyPrzesuwacWykres1G = 0;
                przesuniecie1G.Location = new Point(panelWykresy.Location.X + panelWykresy.Width - przesuniecie1L.Width, przesuniecie1G.Location.Y);
            }
        }

        private void przesuniecieG_MouseUp(object sender, MouseEventArgs e)
        {
            
            czyPrzesuwacWykres1G = 0;
            decimal zaokraglanie1G = (decimal)zmiana1G;
            zaokraglanie1G = System.Decimal.Round(zaokraglanie1G, 2);
            decimal zaokraglanieStare1G = (decimal)staraZmiana1G;
            zaokraglanieStare1G = System.Decimal.Round(zaokraglanieStare1G, 2);
            zaokraglanie1G += zaokraglanieStare1G;
            //MessageBox.Show(zaokraglanie1G.ToString() + "Vs" + zaokraglanieStare1G.ToString());
            wpisywanyWzor0.Text = wpisywanyWzor0.Text.Replace("(x+" + zaokraglanieStare1G + ")", "x");
            wpisywanyWzor0.Text = wpisywanyWzor0.Text.Replace("x", "(x+" + zaokraglanie1G + ")");
            zmiana1G = (double)zaokraglanie1G;
            RysowanieWykresu(0);
            //przesuniecie1L.Location = new Point(0, 0);
        }
        #endregion

        #region przesuwanieWykres2
        int czyPrzesuwacWykres2L = 0;
        int pozycja2L = 0;
        double zmiana2L = 0;
        double staraZmiana2L = 0;
        private void przesuniecie2L_MouseDown(object sender, MouseEventArgs e)
        {
            //staraZmiana = 0;
            czyPrzesuwacWykres2L = 1;
            pozycja2L = przesuniecie2L.Location.Y;
            if (zmiana2L != 0)
                staraZmiana2L = zmiana2L;
        }


        private void przesuniecie2L_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres2L == 1)
            {
                przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, Cursor.Position.Y - przesuniecie2L.Width);
                zerowanie = przesuniecie2L.Location.Y;
                zmiana2L = (pozycja2L - przesuniecie2L.Location.Y) / wielkoscJednostki;

            }
            if (przesuniecie2L.Location.Y < panelWykresy.Location.Y - 10)
            {
                czyPrzesuwacWykres2L = 0;
                przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, panelWykresy.Location.Y);
            }
            if (przesuniecie2L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - przesuniecie2L.Height + 10)
            {
                czyPrzesuwacWykres2L = 0;
                przesuniecie2L.Location = new Point(przesuniecie2L.Location.X, panelWykresy.Location.Y + panelWykresy.Height - przesuniecie2L.Height);
            }
        }

        private void przesuniecie2L_MouseUp(object sender, MouseEventArgs e)
        {

            czyPrzesuwacWykres2L = 0;
            decimal zaokraglanie2L = (decimal)zmiana2L;
            zaokraglanie2L = System.Decimal.Round(zaokraglanie2L, 2);
            decimal zaokraglanieStare2L = (decimal)staraZmiana2L;
            zaokraglanieStare2L = System.Decimal.Round(zaokraglanieStare2L, 2);
            zaokraglanie2L += zaokraglanieStare2L;
            wpisywanyWzor1.Text = wpisywanyWzor1.Text.Replace("+(" + zaokraglanieStare2L.ToString("0.00") + ")", "");
            wpisywanyWzor1.Text += "+(" + zaokraglanie2L + ")";
            zmiana2L = (double)zaokraglanie2L;
            RysowanieWykresu(0);
        }

        int czyPrzesuwacWykres2G = 0;
        int pozycja2G = 0;
        double zmiana2G = 0;
        double staraZmiana2G = 0;

        private void przesuniecie2G_MouseDown(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres2G = 1;
            pozycja2G = przesuniecie2G.Location.X;
            if (zmiana2G != 0)
                staraZmiana2G = zmiana2G;
        }

        private void przesuniecie2G_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Width / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres2G == 1)
            {
                przesuniecie2G.Location = new Point(Cursor.Position.X - przesuniecie2G.Width, przesuniecie2G.Location.Y);
                zerowanie = przesuniecie2G.Location.X;
                zmiana2G = (pozycja2G - przesuniecie2G.Location.X) / wielkoscJednostki;

            }
            if (przesuniecie2G.Location.X < panelWykresy.Location.X - 10)
            {
                czyPrzesuwacWykres2G = 0;
                przesuniecie2G.Location = new Point(panelWykresy.Location.X, przesuniecie2G.Location.Y);
            }
            if (przesuniecie2G.Location.X > panelWykresy.Location.X + panelWykresy.Width - przesuniecie2G.Width + 10)
            {
                czyPrzesuwacWykres2G = 0;
                przesuniecie2G.Location = new Point(panelWykresy.Location.X + panelWykresy.Width - przesuniecie2L.Width, przesuniecie2G.Location.Y);
            }
        }

        private void przesuniecie2G_MouseUp(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres2G = 0;
            decimal zaokraglanie2G = (decimal)zmiana2G;
            zaokraglanie2G = System.Decimal.Round(zaokraglanie2G, 2);
            decimal zaokraglanieStare2G = (decimal)staraZmiana2G;
            zaokraglanieStare2G = System.Decimal.Round(zaokraglanieStare2G, 2);
            wpisywanyWzor1.Text = wpisywanyWzor1.Text.Replace("(x+" + zaokraglanieStare2G + ")", "x");
            wpisywanyWzor1.Text = wpisywanyWzor1.Text.Replace("x", "(x+" + zaokraglanie2G + ")");
            zmiana2G = (double)zaokraglanie2G;
            RysowanieWykresu(0);
        }
        #endregion

        #region przesuwanieWykres3
        int czyPrzesuwacWykres3L = 0;
        int pozycja3L = 0;
        double zmiana3L = 0;
        double starazmiana3L = 0;
        private void przesuniecie3L_MouseDown(object sender, MouseEventArgs e)
        {
            //staraZmiana = 0;
            czyPrzesuwacWykres3L = 1;
            pozycja3L = przesuniecie3L.Location.Y;
            if (zmiana3L != 0)
                starazmiana3L = zmiana3L;
        }


        private void przesuniecie3L_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres3L == 1)
            {
                przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, Cursor.Position.Y - przesuniecie3L.Width);
                zerowanie = przesuniecie3L.Location.Y;
                zmiana3L = (pozycja3L - przesuniecie3L.Location.Y) / wielkoscJednostki;

            }
            if (przesuniecie3L.Location.Y < panelWykresy.Location.Y - 10)
            {
                czyPrzesuwacWykres3L = 0;
                przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, panelWykresy.Location.Y);
            }
            if (przesuniecie3L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - przesuniecie3L.Height + 10)
            {
                czyPrzesuwacWykres3L = 0;
                przesuniecie3L.Location = new Point(przesuniecie3L.Location.X, panelWykresy.Location.Y + panelWykresy.Height - przesuniecie3L.Height);
            }
        }

        private void przesuniecie3L_MouseUp(object sender, MouseEventArgs e)
        {

            czyPrzesuwacWykres3L = 0;
            decimal zaokraglanie3L = (decimal)zmiana3L;
            zaokraglanie3L = System.Decimal.Round(zaokraglanie3L, 2);
            decimal zaokraglanieStare3L = (decimal)starazmiana3L;
            zaokraglanieStare3L = System.Decimal.Round(zaokraglanieStare3L, 2);
            zaokraglanie3L += zaokraglanieStare3L;
            wpisywanyWzor2.Text = wpisywanyWzor2.Text.Replace("+(" + zaokraglanieStare3L.ToString("0.00") + ")", "");
            wpisywanyWzor2.Text += "+(" + zaokraglanie3L + ")";
            zmiana3L = (double)zaokraglanie3L;
            RysowanieWykresu(0);
        }

        int czyPrzesuwacWykres3G = 0;
        int pozycja3G = 0;
        double zmiana3G = 0;
        double starazmiana3G = 0;

        private void przesuniecie3G_MouseDown(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres3G = 1;
            pozycja3G = przesuniecie3G.Location.X;
            if (zmiana3G != 0)
                starazmiana3G = zmiana3G;
        }

        private void przesuniecie3G_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Width / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres3G == 1)
            {
                przesuniecie3G.Location = new Point(Cursor.Position.X - przesuniecie3G.Width, przesuniecie3G.Location.Y);
                zerowanie = przesuniecie3G.Location.X;
                zmiana3G = (pozycja3G - przesuniecie3G.Location.X) / wielkoscJednostki;

            }
            if (przesuniecie3G.Location.X < panelWykresy.Location.X - 10)
            {
                czyPrzesuwacWykres3G = 0;
                przesuniecie3G.Location = new Point(panelWykresy.Location.X, przesuniecie3G.Location.Y);
            }
            if (przesuniecie3G.Location.X > panelWykresy.Location.X + panelWykresy.Width - przesuniecie3G.Width + 10)
            {
                czyPrzesuwacWykres3G = 0;
                przesuniecie3G.Location = new Point(panelWykresy.Location.X + panelWykresy.Width - przesuniecie3L.Width, przesuniecie3G.Location.Y);
            }
        }

        private void przesuniecie3G_MouseUp(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres3G = 0;
            decimal zaokraglanie3G = (decimal)zmiana3G;
            zaokraglanie3G = System.Decimal.Round(zaokraglanie3G, 2);
            decimal zaokraglanieStare3G = (decimal)starazmiana3G;
            zaokraglanieStare3G = System.Decimal.Round(zaokraglanieStare3G, 2);
            wpisywanyWzor2.Text = wpisywanyWzor2.Text.Replace("(x+" + zaokraglanieStare3G + ")", "x");
            wpisywanyWzor2.Text = wpisywanyWzor2.Text.Replace("x", "(x+" + zaokraglanie3G + ")");
            zmiana3G = (double)zaokraglanie3G;
            RysowanieWykresu(0);
        }
        #endregion

        #region przesuwanieWykres4
        int czyPrzesuwacWykres4L = 0;
        int pozycja4L = 0;
        double zmiana4L = 0;
        double starazmiana4L = 0;
        private void przesuniecie4L_MouseDown(object sender, MouseEventArgs e)
        {
            //staraZmiana = 0;
            czyPrzesuwacWykres4L = 1;
            pozycja4L = przesuniecie4L.Location.Y;
            if (zmiana4L != 0)
                starazmiana4L = zmiana4L;
        }


        private void przesuniecie4L_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres4L == 1)
            {
                przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, Cursor.Position.Y - przesuniecie4L.Width);
                zerowanie = przesuniecie4L.Location.Y;
                zmiana4L = (pozycja4L - przesuniecie4L.Location.Y) / wielkoscJednostki;

            }
            if (przesuniecie4L.Location.Y < panelWykresy.Location.Y - 10)
            {
                czyPrzesuwacWykres4L = 0;
                przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, panelWykresy.Location.Y);
            }
            if (przesuniecie4L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - przesuniecie4L.Height + 10)
            {
                czyPrzesuwacWykres4L = 0;
                przesuniecie4L.Location = new Point(przesuniecie4L.Location.X, panelWykresy.Location.Y + panelWykresy.Height - przesuniecie4L.Height);
            }
        }

        private void przesuniecie4L_MouseUp(object sender, MouseEventArgs e)
        {

            czyPrzesuwacWykres4L = 0;
            decimal zaokraglanie4L = (decimal)zmiana4L;
            zaokraglanie4L = System.Decimal.Round(zaokraglanie4L, 2);
            decimal zaokraglanieStare4L = (decimal)starazmiana4L;
            zaokraglanieStare4L = System.Decimal.Round(zaokraglanieStare4L, 2);
            zaokraglanie4L += zaokraglanieStare4L;
            wpisywanyWzor3.Text = wpisywanyWzor3.Text.Replace("+(" + zaokraglanieStare4L.ToString("0.00") + ")", "");
            wpisywanyWzor3.Text += "+(" + zaokraglanie4L + ")";
            zmiana4L = (double)zaokraglanie4L;
            RysowanieWykresu(0);
        }

        int czyPrzesuwacWykres4G = 0;
        int pozycja4G = 0;
        double zmiana4G = 0;
        double starazmiana4G = 0;

        private void przesuniecie4G_MouseDown(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres4G = 1;
            pozycja4G = przesuniecie4G.Location.X;
            if (zmiana4G != 0)
                starazmiana4G = zmiana4G;
        }

        private void przesuniecie4G_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Width / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres4G == 1)
            {
                przesuniecie4G.Location = new Point(Cursor.Position.X - przesuniecie4G.Width, przesuniecie4G.Location.Y);
                zerowanie = przesuniecie4G.Location.X;
                zmiana4G = (pozycja4G - przesuniecie4G.Location.X) / wielkoscJednostki;

            }
            if (przesuniecie4G.Location.X < panelWykresy.Location.X - 10)
            {
                czyPrzesuwacWykres4G = 0;
                przesuniecie4G.Location = new Point(panelWykresy.Location.X, przesuniecie4G.Location.Y);
            }
            if (przesuniecie4G.Location.X > panelWykresy.Location.X + panelWykresy.Width - przesuniecie4G.Width + 10)
            {
                czyPrzesuwacWykres4G = 0;
                przesuniecie4G.Location = new Point(panelWykresy.Location.X + panelWykresy.Width - przesuniecie4L.Width, przesuniecie4G.Location.Y);
            }
        }

        private void przesuniecie4G_MouseUp(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres4G = 0;
            decimal zaokraglanie4G = (decimal)zmiana4G;
            zaokraglanie4G = System.Decimal.Round(zaokraglanie4G, 2);
            decimal zaokraglanieStare4G = (decimal)starazmiana4G;
            zaokraglanieStare4G = System.Decimal.Round(zaokraglanieStare4G, 2);
            wpisywanyWzor3.Text = wpisywanyWzor3.Text.Replace("(x+" + zaokraglanieStare4G + ")", "x");
            wpisywanyWzor3.Text = wpisywanyWzor3.Text.Replace("x", "(x+" + zaokraglanie4G + ")");
            zmiana4G = (double)zaokraglanie4G;
            RysowanieWykresu(0);
        }
        #endregion

        #region przesuwanieWykres5
        int czyPrzesuwacWykres5L = 0;
        int pozycja5L = 0;
        double zmiana5L = 0;
        double starazmiana5L = 0;
        private void przesuniecie5L_MouseDown(object sender, MouseEventArgs e)
        {
            //staraZmiana = 0;
            czyPrzesuwacWykres5L = 1;
            pozycja5L = przesuniecie5L.Location.Y;
            if (zmiana5L != 0)
                starazmiana5L = zmiana5L;
        }


        private void przesuniecie5L_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres5L == 1)
            {
                przesuniecie5L.Location = new Point(przesuniecie5L.Location.X, Cursor.Position.Y - przesuniecie5L.Width);
                zerowanie = przesuniecie5L.Location.Y;
                zmiana5L = (pozycja5L - przesuniecie5L.Location.Y) / wielkoscJednostki;

            }
            if (przesuniecie5L.Location.Y < panelWykresy.Location.Y - 10)
            {
                czyPrzesuwacWykres5L = 0;
                przesuniecie5L.Location = new Point(przesuniecie5L.Location.X, panelWykresy.Location.Y);
            }
            if (przesuniecie5L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - przesuniecie5L.Height + 10)
            {
                czyPrzesuwacWykres5L = 0;
                przesuniecie5L.Location = new Point(przesuniecie5L.Location.X, panelWykresy.Location.Y + panelWykresy.Height - przesuniecie5L.Height);
            }
        }

        private void przesuniecie5L_MouseUp(object sender, MouseEventArgs e)
        {

            czyPrzesuwacWykres5L = 0;
            decimal zaokraglanie5L = (decimal)zmiana5L;
            zaokraglanie5L = System.Decimal.Round(zaokraglanie5L, 2);
            decimal zaokraglanieStare5L = (decimal)starazmiana5L;
            zaokraglanieStare5L = System.Decimal.Round(zaokraglanieStare5L, 2);
            zaokraglanie5L += zaokraglanieStare5L;
            wpisywanyWzor4.Text = wpisywanyWzor4.Text.Replace("+(" + zaokraglanieStare5L.ToString("0.00") + ")", "");
            wpisywanyWzor4.Text += "+(" + zaokraglanie5L + ")";
            zmiana5L = (double)zaokraglanie5L;
            RysowanieWykresu(0);
        }

        int czyPrzesuwacWykres5G = 0;
        int pozycja5G = 0;
        double zmiana5G = 0;
        double starazmiana5G = 0;

        private void przesuniecie5G_MouseDown(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres5G = 1;
            pozycja5G = przesuniecie5G.Location.X;
            if (zmiana5G != 0)
                starazmiana5G = zmiana5G;
        }

        private void przesuniecie5G_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Width / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres5G == 1)
            {
                przesuniecie5G.Location = new Point(Cursor.Position.X - przesuniecie5G.Width, przesuniecie5G.Location.Y);
                zerowanie = przesuniecie5G.Location.X;
                zmiana5G = (pozycja5G - przesuniecie5G.Location.X) / wielkoscJednostki;

            }
            if (przesuniecie5G.Location.X < panelWykresy.Location.X - 10)
            {
                czyPrzesuwacWykres5G = 0;
                przesuniecie5G.Location = new Point(panelWykresy.Location.X, przesuniecie5G.Location.Y);
            }
            if (przesuniecie5G.Location.X > panelWykresy.Location.X + panelWykresy.Width - przesuniecie5G.Width + 10)
            {
                czyPrzesuwacWykres5G = 0;
                przesuniecie5G.Location = new Point(panelWykresy.Location.X + panelWykresy.Width - przesuniecie5L.Width, przesuniecie5G.Location.Y);
            }
        }

        private void przesuniecie5G_MouseUp(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres5G = 0;
            decimal zaokraglanie5G = (decimal)zmiana5G;
            zaokraglanie5G = System.Decimal.Round(zaokraglanie5G, 2);
            decimal zaokraglanieStare5G = (decimal)starazmiana5G;
            zaokraglanieStare5G = System.Decimal.Round(zaokraglanieStare5G, 2);
            wpisywanyWzor4.Text = wpisywanyWzor4.Text.Replace("(x+" + zaokraglanieStare5G + ")", "x");
            wpisywanyWzor4.Text = wpisywanyWzor4.Text.Replace("x", "(x+" + zaokraglanie5G + ")");
            zmiana5G = (double)zaokraglanie5G;
            RysowanieWykresu(0);
        }
        #endregion

        #region przesuwanieWykres6
        int czyPrzesuwacWykres6L = 0;
        int pozycja6L = 0;
        double zmiana6L = 0;
        double starazmiana6L = 0;
        private void przesuniecie6L_MouseDown(object sender, MouseEventArgs e)
        {
            //staraZmiana = 0;
            czyPrzesuwacWykres6L = 1;
            pozycja6L = przesuniecie6L.Location.Y;
            if (zmiana6L != 0)
                starazmiana6L = zmiana6L;
        }


        private void przesuniecie6L_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Height / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres6L == 1)
            {
                przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, Cursor.Position.Y - przesuniecie6L.Width);
                zerowanie = przesuniecie6L.Location.Y;
                zmiana6L = (pozycja6L - przesuniecie6L.Location.Y) / wielkoscJednostki;

            }
            if (przesuniecie6L.Location.Y < panelWykresy.Location.Y - 10)
            {
                czyPrzesuwacWykres6L = 0;
                przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, panelWykresy.Location.Y);
            }
            if (przesuniecie6L.Location.Y > panelWykresy.Location.Y + panelWykresy.Height - przesuniecie6L.Height + 10)
            {
                czyPrzesuwacWykres6L = 0;
                przesuniecie6L.Location = new Point(przesuniecie6L.Location.X, panelWykresy.Location.Y + panelWykresy.Height - przesuniecie6L.Height);
            }
        }

        private void przesuniecie6L_MouseUp(object sender, MouseEventArgs e)
        {

            czyPrzesuwacWykres6L = 0;
            decimal zaokraglanie6L = (decimal)zmiana6L;
            zaokraglanie6L = System.Decimal.Round(zaokraglanie6L, 2);
            decimal zaokraglanieStare6L = (decimal)starazmiana6L;
            zaokraglanieStare6L = System.Decimal.Round(zaokraglanieStare6L, 2);
            zaokraglanie6L += zaokraglanieStare6L;
            //
            wpisywanyWzor5.Text = wpisywanyWzor5.Text.Replace("+(" + zaokraglanieStare6L.ToString("0.00") + ")", "");
            wpisywanyWzor5.Text += "+(" + zaokraglanie6L + ")";
            zmiana6L = (double)zaokraglanie6L;
            RysowanieWykresu(0);
        }

        int czyPrzesuwacWykres6G = 0;
        int pozycja6G = 0;
        double zmiana6G = 0;
        double starazmiana6G = 0;

        private void przesuniecie6G_MouseDown(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres6G = 1;
            pozycja6G = przesuniecie6G.Location.X;
            if (zmiana6G != 0)
                starazmiana6G = zmiana6G;
        }

        private void przesuniecie6G_MouseMove(object sender, MouseEventArgs e)
        {
            int zerowanie = 0;
            float granicaLewa;
            float.TryParse(granicaL.Text, out granicaLewa);
            float granicaPrawa;
            float.TryParse(granicaL.Text, out granicaPrawa);
            float wielkoscJednostki = pictureWykres.Width / (granicaPrawa + granicaLewa);
            if (czyPrzesuwacWykres6G == 1)
            {
                przesuniecie6G.Location = new Point(Cursor.Position.X - przesuniecie6G.Width, przesuniecie6G.Location.Y);
                zerowanie = przesuniecie6G.Location.X;
                zmiana6G = (pozycja6G - przesuniecie6G.Location.X) / wielkoscJednostki;

            }
            if (przesuniecie6G.Location.X < panelWykresy.Location.X - 10)
            {
                czyPrzesuwacWykres6G = 0;
                przesuniecie6G.Location = new Point(panelWykresy.Location.X, przesuniecie6G.Location.Y);
            }
            if (przesuniecie6G.Location.X > panelWykresy.Location.X + panelWykresy.Width - przesuniecie6G.Width + 10)
            {
                czyPrzesuwacWykres6G = 0;
                przesuniecie6G.Location = new Point(panelWykresy.Location.X + panelWykresy.Width - przesuniecie6L.Width, przesuniecie6G.Location.Y);
            }
        }

        private void przesuniecie6G_MouseUp(object sender, MouseEventArgs e)
        {
            czyPrzesuwacWykres6G = 0;
            decimal zaokraglanie6G = (decimal)zmiana6G;
            zaokraglanie6G = System.Decimal.Round(zaokraglanie6G, 2);
            decimal zaokraglanieStare6G = (decimal)starazmiana6G;
            zaokraglanieStare6G = System.Decimal.Round(zaokraglanieStare6G, 2);
            
            wpisywanyWzor5.Text = wpisywanyWzor5.Text.Replace("(x+" + zaokraglanieStare6G + ")", "x");
            wpisywanyWzor5.Text = wpisywanyWzor5.Text.Replace("x", "(x+" + zaokraglanie6G + ")");
            zmiana6G = (double)zaokraglanie6G;
            RysowanieWykresu(0);
        }
        #endregion

        private void clear1_Click(object sender, EventArgs e)
        {
            wpisywanyWzor0.Text = "";
            wpisywanyWzor0.Focus();
            ktoryTextBox = 0;
            zmiana1L = 0;
            zmiana1G = 0;
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            wpisywanyWzor1.Text = "";
            wpisywanyWzor1.Focus();
            ktoryTextBox = 1;
            zmiana2L = 0;
            zmiana2G = 0;
        }

        private void clear3_Click(object sender, EventArgs e)
        {
            wpisywanyWzor2.Text = "";
            wpisywanyWzor2.Focus();
            ktoryTextBox = 2;
            zmiana3L = 0;
            zmiana3G = 0;
        }

        private void clear4_Click(object sender, EventArgs e)
        {
            wpisywanyWzor3.Text = "";
            wpisywanyWzor3.Focus();
            ktoryTextBox = 3;
            zmiana4L = 0;
            zmiana4G = 0;
        }

        private void clear5_Click(object sender, EventArgs e)
        {
            wpisywanyWzor4.Text = "";
            wpisywanyWzor4.Focus();
            ktoryTextBox = 4;
            zmiana5L = 0;
            zmiana5G = 0;
        }

        private void clear6_Click(object sender, EventArgs e)
        {
            wpisywanyWzor5.Text = "";
            wpisywanyWzor5.Focus();
            ktoryTextBox = 5;
            zmiana6L = 0;
            zmiana6G = 0;
        }



    }
}

