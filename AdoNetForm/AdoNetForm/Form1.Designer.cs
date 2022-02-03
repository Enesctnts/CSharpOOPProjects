
namespace AdoNetForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.tbnEkle = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabEkle2 = new System.Windows.Forms.TabPage();
            this.lblBoxSilinicek = new System.Windows.Forms.Label();
            this.cmbSilinecek = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabDüzenle = new System.Windows.Forms.TabPage();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lblTcGüncelle = new System.Windows.Forms.Label();
            this.tbxTcGüncelle = new System.Windows.Forms.TextBox();
            this.lblTelefonGüncelle = new System.Windows.Forms.Label();
            this.lblSoyadGüncelle = new System.Windows.Forms.Label();
            this.lblAdGüncelle = new System.Windows.Forms.Label();
            this.txtSoyadGüncelle = new System.Windows.Forms.TextBox();
            this.txtTelefonGüncelle = new System.Windows.Forms.TextBox();
            this.txtAdGüncelle = new System.Windows.Forms.TextBox();
            this.lblDüzenle = new System.Windows.Forms.Label();
            this.cmbGüncelle = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_ogrenciler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabEkle2.SuspendLayout();
            this.tabDüzenle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(275, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ekle";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabEkle2);
            this.tabControl1.Controls.Add(this.tabDüzenle);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(86, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 479);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.Orange;
            this.tabEkle.Controls.Add(this.tbnEkle);
            this.tabEkle.Controls.Add(this.txtTc);
            this.tabEkle.Controls.Add(this.txtTelefon);
            this.tabEkle.Controls.Add(this.txtSoyad);
            this.tabEkle.Controls.Add(this.lblTc);
            this.tabEkle.Controls.Add(this.lblTelefon);
            this.tabEkle.Controls.Add(this.lblSoyad);
            this.tabEkle.Controls.Add(this.lblAd);
            this.tabEkle.Controls.Add(this.txtAd);
            this.tabEkle.Controls.Add(this.label1);
            this.tabEkle.ForeColor = System.Drawing.Color.Black;
            this.tabEkle.Location = new System.Drawing.Point(4, 46);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(740, 429);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekle";
            // 
            // tbnEkle
            // 
            this.tbnEkle.BackColor = System.Drawing.Color.Lime;
            this.tbnEkle.Location = new System.Drawing.Point(275, 347);
            this.tbnEkle.Name = "tbnEkle";
            this.tbnEkle.Size = new System.Drawing.Size(146, 48);
            this.tbnEkle.TabIndex = 9;
            this.tbnEkle.Text = "Ekle";
            this.tbnEkle.UseVisualStyleBackColor = false;
            this.tbnEkle.Click += new System.EventHandler(this.tbnEkle_Click_1);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(242, 289);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(241, 43);
            this.txtTc.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(242, 230);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(241, 43);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(242, 162);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(241, 43);
            this.txtSoyad.TabIndex = 6;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(110, 278);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(42, 38);
            this.lblTc.TabIndex = 5;
            this.lblTc.Text = "Tc";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(110, 221);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(107, 38);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(110, 162);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(92, 38);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(110, 103);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(51, 38);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(242, 103);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(241, 43);
            this.txtAd.TabIndex = 1;
            // 
            // tabEkle2
            // 
            this.tabEkle2.BackColor = System.Drawing.Color.Silver;
            this.tabEkle2.Controls.Add(this.lblBoxSilinicek);
            this.tabEkle2.Controls.Add(this.cmbSilinecek);
            this.tabEkle2.Controls.Add(this.btnSil);
            this.tabEkle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabEkle2.Location = new System.Drawing.Point(4, 46);
            this.tabEkle2.Name = "tabEkle2";
            this.tabEkle2.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle2.Size = new System.Drawing.Size(740, 429);
            this.tabEkle2.TabIndex = 1;
            this.tabEkle2.Text = "Sil";
            // 
            // lblBoxSilinicek
            // 
            this.lblBoxSilinicek.AutoSize = true;
            this.lblBoxSilinicek.Location = new System.Drawing.Point(201, 82);
            this.lblBoxSilinicek.Name = "lblBoxSilinicek";
            this.lblBoxSilinicek.Size = new System.Drawing.Size(338, 38);
            this.lblBoxSilinicek.TabIndex = 2;
            this.lblBoxSilinicek.Text = "Silinecek Öğrencisi Giriniz";
            // 
            // cmbSilinecek
            // 
            this.cmbSilinecek.FormattingEnabled = true;
            this.cmbSilinecek.Location = new System.Drawing.Point(148, 172);
            this.cmbSilinecek.Name = "cmbSilinecek";
            this.cmbSilinecek.Size = new System.Drawing.Size(427, 45);
            this.cmbSilinecek.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Location = new System.Drawing.Point(285, 273);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 55);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabDüzenle
            // 
            this.tabDüzenle.BackColor = System.Drawing.Color.Bisque;
            this.tabDüzenle.Controls.Add(this.btnGüncelle);
            this.tabDüzenle.Controls.Add(this.lblTcGüncelle);
            this.tabDüzenle.Controls.Add(this.tbxTcGüncelle);
            this.tabDüzenle.Controls.Add(this.lblTelefonGüncelle);
            this.tabDüzenle.Controls.Add(this.lblSoyadGüncelle);
            this.tabDüzenle.Controls.Add(this.lblAdGüncelle);
            this.tabDüzenle.Controls.Add(this.txtSoyadGüncelle);
            this.tabDüzenle.Controls.Add(this.txtTelefonGüncelle);
            this.tabDüzenle.Controls.Add(this.txtAdGüncelle);
            this.tabDüzenle.Controls.Add(this.lblDüzenle);
            this.tabDüzenle.Controls.Add(this.cmbGüncelle);
            this.tabDüzenle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDüzenle.Location = new System.Drawing.Point(4, 46);
            this.tabDüzenle.Name = "tabDüzenle";
            this.tabDüzenle.Size = new System.Drawing.Size(740, 429);
            this.tabDüzenle.TabIndex = 2;
            this.tabDüzenle.Text = "Düzenle";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(377, 346);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(171, 52);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // lblTcGüncelle
            // 
            this.lblTcGüncelle.AutoSize = true;
            this.lblTcGüncelle.ForeColor = System.Drawing.Color.Blue;
            this.lblTcGüncelle.Location = new System.Drawing.Point(178, 297);
            this.lblTcGüncelle.Name = "lblTcGüncelle";
            this.lblTcGüncelle.Size = new System.Drawing.Size(85, 38);
            this.lblTcGüncelle.TabIndex = 9;
            this.lblTcGüncelle.Text = "TCKN";
            // 
            // tbxTcGüncelle
            // 
            this.tbxTcGüncelle.Location = new System.Drawing.Point(304, 297);
            this.tbxTcGüncelle.Name = "tbxTcGüncelle";
            this.tbxTcGüncelle.Size = new System.Drawing.Size(320, 43);
            this.tbxTcGüncelle.TabIndex = 8;
            // 
            // lblTelefonGüncelle
            // 
            this.lblTelefonGüncelle.AutoSize = true;
            this.lblTelefonGüncelle.ForeColor = System.Drawing.Color.Blue;
            this.lblTelefonGüncelle.Location = new System.Drawing.Point(178, 248);
            this.lblTelefonGüncelle.Name = "lblTelefonGüncelle";
            this.lblTelefonGüncelle.Size = new System.Drawing.Size(107, 38);
            this.lblTelefonGüncelle.TabIndex = 7;
            this.lblTelefonGüncelle.Text = "Telefon";
            // 
            // lblSoyadGüncelle
            // 
            this.lblSoyadGüncelle.AutoSize = true;
            this.lblSoyadGüncelle.ForeColor = System.Drawing.Color.Blue;
            this.lblSoyadGüncelle.Location = new System.Drawing.Point(178, 196);
            this.lblSoyadGüncelle.Name = "lblSoyadGüncelle";
            this.lblSoyadGüncelle.Size = new System.Drawing.Size(92, 38);
            this.lblSoyadGüncelle.TabIndex = 6;
            this.lblSoyadGüncelle.Text = "Soyad";
            // 
            // lblAdGüncelle
            // 
            this.lblAdGüncelle.AutoSize = true;
            this.lblAdGüncelle.ForeColor = System.Drawing.Color.Blue;
            this.lblAdGüncelle.Location = new System.Drawing.Point(178, 147);
            this.lblAdGüncelle.Name = "lblAdGüncelle";
            this.lblAdGüncelle.Size = new System.Drawing.Size(51, 38);
            this.lblAdGüncelle.TabIndex = 5;
            this.lblAdGüncelle.Text = "Ad";
            // 
            // txtSoyadGüncelle
            // 
            this.txtSoyadGüncelle.Location = new System.Drawing.Point(304, 196);
            this.txtSoyadGüncelle.Name = "txtSoyadGüncelle";
            this.txtSoyadGüncelle.Size = new System.Drawing.Size(320, 43);
            this.txtSoyadGüncelle.TabIndex = 4;
            // 
            // txtTelefonGüncelle
            // 
            this.txtTelefonGüncelle.Location = new System.Drawing.Point(304, 248);
            this.txtTelefonGüncelle.Name = "txtTelefonGüncelle";
            this.txtTelefonGüncelle.Size = new System.Drawing.Size(320, 43);
            this.txtTelefonGüncelle.TabIndex = 3;
            // 
            // txtAdGüncelle
            // 
            this.txtAdGüncelle.Location = new System.Drawing.Point(304, 147);
            this.txtAdGüncelle.Name = "txtAdGüncelle";
            this.txtAdGüncelle.Size = new System.Drawing.Size(320, 43);
            this.txtAdGüncelle.TabIndex = 2;
            // 
            // lblDüzenle
            // 
            this.lblDüzenle.AutoSize = true;
            this.lblDüzenle.ForeColor = System.Drawing.Color.Blue;
            this.lblDüzenle.Location = new System.Drawing.Point(108, 25);
            this.lblDüzenle.Name = "lblDüzenle";
            this.lblDüzenle.Size = new System.Drawing.Size(516, 38);
            this.lblDüzenle.TabIndex = 1;
            this.lblDüzenle.Text = "Düzenlenecek öğrenciyi listeden seçiniz.";
            // 
            // cmbGüncelle
            // 
            this.cmbGüncelle.FormattingEnabled = true;
            this.cmbGüncelle.Location = new System.Drawing.Point(178, 75);
            this.cmbGüncelle.Name = "cmbGüncelle";
            this.cmbGüncelle.Size = new System.Drawing.Size(398, 45);
            this.cmbGüncelle.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.data_ogrenciler);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(740, 429);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Listele";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // data_ogrenciler
            // 
            this.data_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ogrenciler.Location = new System.Drawing.Point(54, 67);
            this.data_ogrenciler.Name = "data_ogrenciler";
            this.data_ogrenciler.RowHeadersWidth = 51;
            this.data_ogrenciler.RowTemplate.Height = 29;
            this.data_ogrenciler.Size = new System.Drawing.Size(633, 318);
            this.data_ogrenciler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 832);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabEkle2.ResumeLayout(false);
            this.tabEkle2.PerformLayout();
            this.tabDüzenle.ResumeLayout(false);
            this.tabDüzenle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.Button tbnEkle;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabPage tabEkle2;
        private System.Windows.Forms.Label lblBoxSilinicek;
        private System.Windows.Forms.ComboBox cmbSilinecek;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TabPage tabDüzenle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_ogrenciler;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblTcGüncelle;
        private System.Windows.Forms.TextBox tbxTcGüncelle;
        private System.Windows.Forms.Label lblTelefonGüncelle;
        private System.Windows.Forms.Label lblSoyadGüncelle;
        private System.Windows.Forms.Label lblAdGüncelle;
        private System.Windows.Forms.TextBox txtSoyadGüncelle;
        private System.Windows.Forms.TextBox txtTelefonGüncelle;
        private System.Windows.Forms.TextBox txtAdGüncelle;
        private System.Windows.Forms.Label lblDüzenle;
        private System.Windows.Forms.ComboBox cmbGüncelle;
    }
}

