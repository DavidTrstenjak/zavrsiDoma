﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bibliotekaDavid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btnUpis_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument korisnikXML = new XDocument(new XElement ("Korisnici"));
            korisnikXML.Save(@"C:\Users\ucenik\Music\Filtriranje-i-pregled-podataka-main\korisnikXML.xml");
        }
    }
}
