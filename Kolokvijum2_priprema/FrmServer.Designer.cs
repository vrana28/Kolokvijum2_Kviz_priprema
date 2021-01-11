
namespace Kolokvijum2_priprema
{
    partial class FrmServer
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIgra = new System.Windows.Forms.ComboBox();
            this.txtBrojIgraca = new System.Windows.Forms.TextBox();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnKick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pokreni igru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Igra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj igraca:";
            // 
            // cmbIgra
            // 
            this.cmbIgra.FormattingEnabled = true;
            this.cmbIgra.Location = new System.Drawing.Point(173, 53);
            this.cmbIgra.Name = "cmbIgra";
            this.cmbIgra.Size = new System.Drawing.Size(269, 21);
            this.cmbIgra.TabIndex = 3;
            // 
            // txtBrojIgraca
            // 
            this.txtBrojIgraca.Location = new System.Drawing.Point(173, 102);
            this.txtBrojIgraca.Name = "txtBrojIgraca";
            this.txtBrojIgraca.Size = new System.Drawing.Size(269, 20);
            this.txtBrojIgraca.TabIndex = 4;
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToAddRows = false;
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Location = new System.Drawing.Point(30, 191);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIgraci.Size = new System.Drawing.Size(412, 150);
            this.dgvIgraci.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 147);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 6;
            // 
            // btnKick
            // 
            this.btnKick.Location = new System.Drawing.Point(256, 147);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(75, 23);
            this.btnKick.TabIndex = 7;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 345);
            this.Controls.Add(this.btnKick);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvIgraci);
            this.Controls.Add(this.txtBrojIgraca);
            this.Controls.Add(this.cmbIgra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmServer";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIgra;
        private System.Windows.Forms.TextBox txtBrojIgraca;
        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnKick;
    }
}

