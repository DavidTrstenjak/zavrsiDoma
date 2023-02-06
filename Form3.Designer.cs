namespace bibliotekaDavid
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.richTextBoxIspisKorisnik = new System.Windows.Forms.RichTextBox();
            this.textBoxIDkorisnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUcitajKorisnik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDknjige = new System.Windows.Forms.TextBox();
            this.richTextBoxIspisKnjiga = new System.Windows.Forms.RichTextBox();
            this.buttonUcitajKnjiga = new System.Windows.Forms.Button();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.textBoxAutorKnjige = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOibKorisnika = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxIspisKorisnik
            // 
            this.richTextBoxIspisKorisnik.Location = new System.Drawing.Point(12, 172);
            this.richTextBoxIspisKorisnik.Name = "richTextBoxIspisKorisnik";
            this.richTextBoxIspisKorisnik.Size = new System.Drawing.Size(214, 186);
            this.richTextBoxIspisKorisnik.TabIndex = 0;
            this.richTextBoxIspisKorisnik.Text = "";
            this.richTextBoxIspisKorisnik.TextChanged += new System.EventHandler(this.richTextBoxIspisKorisnik_TextChanged);
            // 
            // textBoxIDkorisnika
            // 
            this.textBoxIDkorisnika.Location = new System.Drawing.Point(16, 42);
            this.textBoxIDkorisnika.Name = "textBoxIDkorisnika";
            this.textBoxIDkorisnika.Size = new System.Drawing.Size(210, 20);
            this.textBoxIDkorisnika.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upiši ime korisnika : ";
            // 
            // buttonUcitajKorisnik
            // 
            this.buttonUcitajKorisnik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUcitajKorisnik.Location = new System.Drawing.Point(16, 364);
            this.buttonUcitajKorisnik.Name = "buttonUcitajKorisnik";
            this.buttonUcitajKorisnik.Size = new System.Drawing.Size(154, 62);
            this.buttonUcitajKorisnik.TabIndex = 3;
            this.buttonUcitajKorisnik.Text = "PRONAĐI KORISNIKA";
            this.buttonUcitajKorisnik.UseVisualStyleBackColor = false;
            this.buttonUcitajKorisnik.Click += new System.EventHandler(this.buttonUcitajKorisnik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upiši naziv knjige :";
            // 
            // textBoxIDknjige
            // 
            this.textBoxIDknjige.Location = new System.Drawing.Point(322, 42);
            this.textBoxIDknjige.Name = "textBoxIDknjige";
            this.textBoxIDknjige.Size = new System.Drawing.Size(211, 20);
            this.textBoxIDknjige.TabIndex = 5;
            // 
            // richTextBoxIspisKnjiga
            // 
            this.richTextBoxIspisKnjiga.Location = new System.Drawing.Point(322, 172);
            this.richTextBoxIspisKnjiga.Name = "richTextBoxIspisKnjiga";
            this.richTextBoxIspisKnjiga.Size = new System.Drawing.Size(211, 186);
            this.richTextBoxIspisKnjiga.TabIndex = 6;
            this.richTextBoxIspisKnjiga.Text = "";
            // 
            // buttonUcitajKnjiga
            // 
            this.buttonUcitajKnjiga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUcitajKnjiga.Location = new System.Drawing.Point(346, 364);
            this.buttonUcitajKnjiga.Name = "buttonUcitajKnjiga";
            this.buttonUcitajKnjiga.Size = new System.Drawing.Size(154, 62);
            this.buttonUcitajKnjiga.TabIndex = 7;
            this.buttonUcitajKnjiga.Text = "PRONAĐI KNJIGU";
            this.buttonUcitajKnjiga.UseVisualStyleBackColor = false;
            this.buttonUcitajKnjiga.Click += new System.EventHandler(this.buttonUcitajKnjiga_Click);
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(12, 468);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(521, 141);
            this.textBoxIspis.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Upiši prezime korisnika :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Upiši autora knjige :";
            // 
            // textBoxPrezimeKorisnika
            // 
            this.textBoxPrezimeKorisnika.Location = new System.Drawing.Point(19, 86);
            this.textBoxPrezimeKorisnika.Name = "textBoxPrezimeKorisnika";
            this.textBoxPrezimeKorisnika.Size = new System.Drawing.Size(207, 20);
            this.textBoxPrezimeKorisnika.TabIndex = 11;
            // 
            // textBoxAutorKnjige
            // 
            this.textBoxAutorKnjige.Location = new System.Drawing.Point(322, 85);
            this.textBoxAutorKnjige.Name = "textBoxAutorKnjige";
            this.textBoxAutorKnjige.Size = new System.Drawing.Size(211, 20);
            this.textBoxAutorKnjige.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unesi OIB korisnika :";
            // 
            // textBoxOibKorisnika
            // 
            this.textBoxOibKorisnika.Location = new System.Drawing.Point(19, 130);
            this.textBoxOibKorisnika.Name = "textBoxOibKorisnika";
            this.textBoxOibKorisnika.Size = new System.Drawing.Size(207, 20);
            this.textBoxOibKorisnika.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ispis podataka :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOibKorisnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAutorKnjige);
            this.Controls.Add(this.textBoxPrezimeKorisnika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.buttonUcitajKnjiga);
            this.Controls.Add(this.richTextBoxIspisKnjiga);
            this.Controls.Add(this.textBoxIDknjige);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUcitajKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDkorisnika);
            this.Controls.Add(this.richTextBoxIspisKorisnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "PREGLED";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxIspisKorisnik;
        private System.Windows.Forms.TextBox textBoxIDkorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUcitajKorisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDknjige;
        private System.Windows.Forms.RichTextBox richTextBoxIspisKnjiga;
        private System.Windows.Forms.Button buttonUcitajKnjiga;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrezimeKorisnika;
        private System.Windows.Forms.TextBox textBoxAutorKnjige;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOibKorisnika;
        private System.Windows.Forms.Label label6;
    }
}