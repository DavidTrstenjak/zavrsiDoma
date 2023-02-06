namespace bibliotekaDavid
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDkorisnika = new System.Windows.Forms.TextBox();
            this.buttonUnesiPodatke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime korisnika :";
            // 
            // textBoxImeKorisnika
            // 
            this.textBoxImeKorisnika.Location = new System.Drawing.Point(31, 63);
            this.textBoxImeKorisnika.Name = "textBoxImeKorisnika";
            this.textBoxImeKorisnika.Size = new System.Drawing.Size(170, 20);
            this.textBoxImeKorisnika.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime korisnika :";
            // 
            // textBoxPrezimeKorisnika
            // 
            this.textBoxPrezimeKorisnika.Location = new System.Drawing.Point(31, 134);
            this.textBoxPrezimeKorisnika.Name = "textBoxPrezimeKorisnika";
            this.textBoxPrezimeKorisnika.Size = new System.Drawing.Size(170, 20);
            this.textBoxPrezimeKorisnika.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "OIB korisnika :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxIDkorisnika
            // 
            this.textBoxIDkorisnika.Location = new System.Drawing.Point(31, 205);
            this.textBoxIDkorisnika.Name = "textBoxIDkorisnika";
            this.textBoxIDkorisnika.Size = new System.Drawing.Size(170, 20);
            this.textBoxIDkorisnika.TabIndex = 10;
            // 
            // buttonUnesiPodatke
            // 
            this.buttonUnesiPodatke.Location = new System.Drawing.Point(31, 246);
            this.buttonUnesiPodatke.Name = "buttonUnesiPodatke";
            this.buttonUnesiPodatke.Size = new System.Drawing.Size(170, 57);
            this.buttonUnesiPodatke.TabIndex = 13;
            this.buttonUnesiPodatke.Text = "REGISTRIRAJ KORISNIKA";
            this.buttonUnesiPodatke.UseVisualStyleBackColor = true;
            this.buttonUnesiPodatke.Click += new System.EventHandler(this.buttonUnesiPodatke_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 355);
            this.Controls.Add(this.buttonUnesiPodatke);
            this.Controls.Add(this.textBoxIDkorisnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrezimeKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImeKorisnika);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "UPIS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeKorisnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezimeKorisnika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDkorisnika;
        private System.Windows.Forms.Button buttonUnesiPodatke;
    }
}