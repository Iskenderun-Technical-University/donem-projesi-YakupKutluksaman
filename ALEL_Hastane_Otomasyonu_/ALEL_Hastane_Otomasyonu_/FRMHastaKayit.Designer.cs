
namespace ALEL_Hastane_Otomasyonu_
{
    partial class FRMHastaKayit
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
            this.BtnGiris = new System.Windows.Forms.Button();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.mskTlf = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cbmCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(216, 331);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(159, 32);
            this.BtnGiris.TabIndex = 9;
            this.BtnGiris.Text = "Kayıt Ol";
            this.BtnGiris.UseVisualStyleBackColor = true;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(215, 153);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(159, 29);
            this.txtsoyisim.TabIndex = 8;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(215, 188);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(160, 29);
            this.MskTC.TabIndex = 7;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "TC Kimlik Numarası:";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(215, 118);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(159, 29);
            this.txtisim.TabIndex = 12;
            // 
            // mskTlf
            // 
            this.mskTlf.Location = new System.Drawing.Point(214, 223);
            this.mskTlf.Mask = "(999) 000-0000";
            this.mskTlf.Name = "mskTlf";
            this.mskTlf.Size = new System.Drawing.Size(160, 29);
            this.mskTlf.TabIndex = 13;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(214, 258);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(159, 29);
            this.txtSifre.TabIndex = 14;
            // 
            // cbmCinsiyet
            // 
            this.cbmCinsiyet.FormattingEnabled = true;
            this.cbmCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbmCinsiyet.Location = new System.Drawing.Point(215, 294);
            this.cbmCinsiyet.Name = "cbmCinsiyet";
            this.cbmCinsiyet.Size = new System.Drawing.Size(160, 31);
            this.cbmCinsiyet.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALEL_Hastane_Otomasyonu_.Properties.Resources.ÖZEL_ALEL_HASTANESİ__3_2;
            this.pictureBox1.Location = new System.Drawing.Point(216, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FRMHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmCinsiyet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTlf);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRMHastaKayit";
            this.Text = "FRMHastaKayit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.MaskedTextBox mskTlf;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ComboBox cbmCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}