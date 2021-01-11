
namespace Client
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPosaljiOdgovor = new System.Windows.Forms.Button();
            this.txtUkupnoPoena = new System.Windows.Forms.TextBox();
            this.txtPorukaServera = new System.Windows.Forms.TextBox();
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.txtPitanje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijava:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnicko ime:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrijavi);
            this.panel1.Controls.Add(this.txtKorisnickoIme);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 142);
            this.panel1.TabIndex = 2;
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Location = new System.Drawing.Point(273, 85);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(75, 23);
            this.btnPrijavi.TabIndex = 3;
            this.btnPrijavi.Text = "btnPrijava";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(124, 41);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(224, 20);
            this.txtKorisnickoIme.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Odgovor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Korisnicko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ukupno poena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pitanje:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPosaljiOdgovor);
            this.panel2.Controls.Add(this.txtUkupnoPoena);
            this.panel2.Controls.Add(this.txtPorukaServera);
            this.panel2.Controls.Add(this.txtOdgovor);
            this.panel2.Controls.Add(this.txtPitanje);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 245);
            this.panel2.TabIndex = 7;
            // 
            // btnPosaljiOdgovor
            // 
            this.btnPosaljiOdgovor.Location = new System.Drawing.Point(297, 138);
            this.btnPosaljiOdgovor.Name = "btnPosaljiOdgovor";
            this.btnPosaljiOdgovor.Size = new System.Drawing.Size(75, 23);
            this.btnPosaljiOdgovor.TabIndex = 12;
            this.btnPosaljiOdgovor.Text = "Posalji odgovor";
            this.btnPosaljiOdgovor.UseVisualStyleBackColor = true;
            this.btnPosaljiOdgovor.Click += new System.EventHandler(this.btnPosaljiOdgovor_Click);
            // 
            // txtUkupnoPoena
            // 
            this.txtUkupnoPoena.Location = new System.Drawing.Point(142, 200);
            this.txtUkupnoPoena.Name = "txtUkupnoPoena";
            this.txtUkupnoPoena.ReadOnly = true;
            this.txtUkupnoPoena.Size = new System.Drawing.Size(230, 20);
            this.txtUkupnoPoena.TabIndex = 11;
            // 
            // txtPorukaServera
            // 
            this.txtPorukaServera.Location = new System.Drawing.Point(142, 167);
            this.txtPorukaServera.Name = "txtPorukaServera";
            this.txtPorukaServera.ReadOnly = true;
            this.txtPorukaServera.Size = new System.Drawing.Size(230, 20);
            this.txtPorukaServera.TabIndex = 10;
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(142, 98);
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(230, 20);
            this.txtOdgovor.TabIndex = 9;
            // 
            // txtPitanje
            // 
            this.txtPitanje.Location = new System.Drawing.Point(142, 66);
            this.txtPitanje.Name = "txtPitanje";
            this.txtPitanje.ReadOnly = true;
            this.txtPitanje.Size = new System.Drawing.Size(230, 20);
            this.txtPitanje.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Poruka servera:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Button btnPosaljiOdgovor;
        private System.Windows.Forms.TextBox txtUkupnoPoena;
        private System.Windows.Forms.TextBox txtPorukaServera;
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.TextBox txtPitanje;
        private System.Windows.Forms.Label label7;
    }
}

