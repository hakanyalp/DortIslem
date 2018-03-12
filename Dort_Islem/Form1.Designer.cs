namespace Dort_Islem
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
            this.components = new System.ComponentModel.Container();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdTopla = new System.Windows.Forms.RadioButton();
            this.rdCikar = new System.Windows.Forms.RadioButton();
            this.rdCarp = new System.Windows.Forms.RadioButton();
            this.rdBol = new System.Windows.Forms.RadioButton();
            this.lblVirgulSor = new System.Windows.Forms.Label();
            this.txtHassasiyet = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHesapla.Location = new System.Drawing.Point(41, 175);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(167, 66);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold);
            this.txtSayi1.ForeColor = System.Drawing.Color.Orange;
            this.txtSayi1.Location = new System.Drawing.Point(111, 23);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(343, 35);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.Enter += new System.EventHandler(this.txtSayi1_Enter);
            this.txtSayi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSayi1_KeyDown);
            this.txtSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı 1 :";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold);
            this.txtSayi2.ForeColor = System.Drawing.Color.Orange;
            this.txtSayi2.Location = new System.Drawing.Point(111, 66);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(343, 35);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.Enter += new System.EventHandler(this.txtSayi2_Enter);
            this.txtSayi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSayi2_KeyDown);
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(263, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "İşleminiz :";
            // 
            // rdTopla
            // 
            this.rdTopla.AutoSize = true;
            this.rdTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTopla.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdTopla.Location = new System.Drawing.Point(146, 128);
            this.rdTopla.Name = "rdTopla";
            this.rdTopla.Size = new System.Drawing.Size(62, 21);
            this.rdTopla.TabIndex = 2;
            this.rdTopla.Text = "Topla";
            this.rdTopla.UseVisualStyleBackColor = true;
            // 
            // rdCikar
            // 
            this.rdCikar.AutoSize = true;
            this.rdCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdCikar.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdCikar.Location = new System.Drawing.Point(238, 128);
            this.rdCikar.Name = "rdCikar";
            this.rdCikar.Size = new System.Drawing.Size(58, 21);
            this.rdCikar.TabIndex = 5;
            this.rdCikar.Text = "Çıkar";
            this.rdCikar.UseVisualStyleBackColor = true;
            // 
            // rdCarp
            // 
            this.rdCarp.AutoSize = true;
            this.rdCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdCarp.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdCarp.Location = new System.Drawing.Point(324, 128);
            this.rdCarp.Name = "rdCarp";
            this.rdCarp.Size = new System.Drawing.Size(56, 21);
            this.rdCarp.TabIndex = 5;
            this.rdCarp.Text = "Çarp";
            this.rdCarp.UseVisualStyleBackColor = true;
            // 
            // rdBol
            // 
            this.rdBol.AutoSize = true;
            this.rdBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBol.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdBol.Location = new System.Drawing.Point(408, 128);
            this.rdBol.Name = "rdBol";
            this.rdBol.Size = new System.Drawing.Size(46, 21);
            this.rdBol.TabIndex = 5;
            this.rdBol.Text = "Böl";
            this.rdBol.UseVisualStyleBackColor = true;
            this.rdBol.CheckedChanged += new System.EventHandler(this.rdBol_CheckedChanged);
            // 
            // lblVirgulSor
            // 
            this.lblVirgulSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVirgulSor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblVirgulSor.Location = new System.Drawing.Point(491, 58);
            this.lblVirgulSor.Name = "lblVirgulSor";
            this.lblVirgulSor.Size = new System.Drawing.Size(136, 57);
            this.lblVirgulSor.TabIndex = 7;
            this.lblVirgulSor.Text = "Virgülden sonraki hassasiyeti ayarlayın";
            this.lblVirgulSor.Visible = false;
            // 
            // txtHassasiyet
            // 
            this.txtHassasiyet.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold);
            this.txtHassasiyet.ForeColor = System.Drawing.Color.Orange;
            this.txtHassasiyet.Location = new System.Drawing.Point(494, 118);
            this.txtHassasiyet.Name = "txtHassasiyet";
            this.txtHassasiyet.Size = new System.Drawing.Size(133, 35);
            this.txtHassasiyet.TabIndex = 8;
            this.txtHassasiyet.Visible = false;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonuc.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSonuc.Location = new System.Drawing.Point(324, 175);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(303, 195);
            this.txtSonuc.TabIndex = 9;
            this.txtSonuc.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(639, 382);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtHassasiyet);
            this.Controls.Add(this.lblVirgulSor);
            this.Controls.Add(this.rdBol);
            this.Controls.Add(this.rdCarp);
            this.Controls.Add(this.rdCikar);
            this.Controls.Add(this.rdTopla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "String üzerinde Dört İşlem";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdTopla;
        private System.Windows.Forms.RadioButton rdCikar;
        private System.Windows.Forms.RadioButton rdCarp;
        private System.Windows.Forms.RadioButton rdBol;
        private System.Windows.Forms.Label lblVirgulSor;
        private System.Windows.Forms.TextBox txtHassasiyet;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

