using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_RECHNER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dblEingabe1;
            double dblEingabe2;
            string strEingabe1;
            string strEingabe2;
            string strCaption;
            double Ergebnis;
            string strText;
            bool canConvertEingabe1;
            bool canConvertEingabe2;
           
 

            strCaption = "Zahleneingabe:";
            strText = "Geben Sie bitte eine Zahl ein:";
            strEingabe2 = textBox2.Text;
            strEingabe1 = textBox1.Text;
            
            // Variante 1: Beginn der Schleife (Abbruchbedingung am Ende: 1mal ausgeführt)
            



                // Überprüfen ob der Eingabe eine Zahl (=numerisch) ist?
                canConvertEingabe1 = double.TryParse(strEingabe1, out dblEingabe1);
                canConvertEingabe2 = double.TryParse(strEingabe2, out dblEingabe2);
                        if (canConvertEingabe2 = double.TryParse(strEingabe2, out dblEingabe2))
            {
                dblEingabe1 = System.Convert.ToDouble(strEingabe1);
            }
                        else
            {
                if (this.radioButton3.Checked == true)
                {

                }
                MessageBox.Show("Bitte eine Zahl eingeben!!!", "Falsche Eingabe!!!", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
            canConvertEingabe2 = double.TryParse(strEingabe2, out dblEingabe2);
            canConvertEingabe1 = double.TryParse(strEingabe1, out dblEingabe1);
            // Wenn NEIN ==> MsBox mit Hinweis dass kein Zahl eingeben wurde!
            if (this.radioButton1.Checked == true)
            {
                Ergebnis = dblEingabe1 + dblEingabe2;
                this.textBox3.Text = Ergebnis.ToString();

            }
            else if (this.radioButton8.Checked == true)
            {
                Ergebnis = dblEingabe1 - dblEingabe2;
                this.textBox3.Text = Ergebnis.ToString();
            }
            else if (this.radioButton7.Checked == true)
            {
                Ergebnis = dblEingabe2 * dblEingabe2;
                this.textBox3.Text = Ergebnis.ToString();
            }
            else if (this.radioButton6.Checked == true)
            {
                if (dblEingabe2 != 0)
                {
                    Ergebnis = dblEingabe1 / dblEingabe2;
                    this.textBox3.Text = Ergebnis.ToString();
                }
                else
                {
                    MessageBox.Show("Die zweite Zahl darf nicht kleiner als 0 sein.", "Falsche Eingabe!!!", MessageBoxButtons.OK,
                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else if (this.radioButton5.Checked == true)
            {

                if (dblEingabe1 != 0 && dblEingabe2 != 0)
                {
                    Ergebnis = dblEingabe1 % dblEingabe2;
                    this.textBox3.Text = Ergebnis.ToString();
                }
                else
                {
                    MessageBox.Show("Die zweite Zahl und/oder Zahl 1 darf nicht kleiner als 0 sein.", "Falsche Eingabe!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else if (this.radioButton4.Checked == true)
            {
                Ergebnis = Math.Sqrt(Math.Pow(dblEingabe1, 2) + Math.Pow(dblEingabe2, 2));
                this.textBox3.Text = Ergebnis.ToString();
            }

            else if (this.radioButton3.Checked == true)
            {


              //  MessageBox.Show("bitte 0 bei der 2 zahl eingeben", "Richtge Eingabe!!!", MessageBoxButtons.OK,
               //  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
               //  MessageBoxOptions.DefaultDesktopOnly);


                Ergebnis = Math.Sqrt(Math.Pow(dblEingabe1, 2)) * Math.PI * Math.Sqrt(Math.Pow(dblEingabe2, 0));
                this.textBox3.Text = Ergebnis.ToString();
            }


            else if (this.radioButton2.Checked == true)
            {

                Ergebnis = Math.Sqrt(Math.Pow(dblEingabe1, 2)) * Math.PI * dblEingabe2;
                this.textBox3.Text = Ergebnis.ToString();
            }


            else if (this.radioButton9.Checked == true)
            {
                double winkl;
                winkl = Math.PI * dblEingabe1 / 180.0;
                Ergebnis = Math.Sin(winkl);
                this.textBox3.Text = Ergebnis.ToString();

            }
            else if (this.radioButton10.Checked == true)
            {
                double winkl;
                winkl = Math.PI * dblEingabe1 / 180.0;
                Ergebnis = Math.Cos(winkl);
                this.textBox3.Text = Ergebnis.ToString();
            }
            else if (this.radioButton11.Checked == true)
            {
                int i;  
                int Ziffer;
                long quersumme = 0;
                string qSummeEingabe;

                qSummeEingabe = Math.Floor(dblEingabe1).ToString();
                //Length is wichtig
                for ( i = 0; i <= qSummeEingabe.Length-1; i++)
                {

                    Ziffer = Convert.ToInt32(strEingabe1.Substring(i,1)) ;
                    quersumme = quersumme + Ziffer; //<-- muss sein weil long in string
                
                }
                 this.textBox3.Text = quersumme.ToString();
          
            }
        }
       
        }
    }

