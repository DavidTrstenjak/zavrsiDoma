using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace bibliotekaDavid
{
    public partial class Form2 : Form
    {
        string dokument = @"C:\Users\ucenik\Music\Filtriranje-i-pregled-podataka-main\korisnikXML.xml";
        List<podatci> korisnik = new List<podatci>();


        public Form2()
        {
            InitializeComponent();
        }

    

   


        private void buttonUnesiPodatke_Click(object sender, EventArgs e)
        {
            var korisnikXML = XDocument.Load(dokument);

            podatci Korisnik = new podatci(textBoxImeKorisnika.Text, textBoxPrezimeKorisnika.Text, Convert.ToInt32(textBoxIDkorisnika.Text));
            korisnik.Add(Korisnik);
     
                foreach (podatci korisnik1 in korisnik)
                {
                    var podatak = new XElement("Korisnici", new XElement("Ime", Korisnik.ImeKorisnika),
                    new XElement("Prezime", Korisnik.PrezimeKorisnika), new XElement("OIB_korisnika", Korisnik.IDkorisnika));
                korisnikXML.Add(podatak);
                }

                
            korisnikXML.Save(dokument);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
    }
        
    

