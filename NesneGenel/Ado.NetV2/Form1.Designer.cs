
namespace Ado.NetV2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.lblKitapId = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(153, 35);
            this.txtKitapID.Multiline = true;
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(188, 24);
            this.txtKitapID.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(153, 74);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(188, 24);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(153, 114);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(188, 24);
            this.cmbKategori.TabIndex = 3;
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(153, 154);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(188, 24);
            this.cmbYazar.TabIndex = 4;
            // 
            // lblKitapId
            // 
            this.lblKitapId.AutoSize = true;
            this.lblKitapId.Location = new System.Drawing.Point(90, 38);
            this.lblKitapId.Name = "lblKitapId";
            this.lblKitapId.Size = new System.Drawing.Size(57, 17);
            this.lblKitapId.TabIndex = 5;
            this.lblKitapId.Text = "Kitap ID";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(83, 74);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(64, 17);
            this.lblKitapAdi.TabIndex = 6;
            this.lblKitapAdi.Text = "Kitap Adi";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(86, 114);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 17);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Kategori";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(102, 157);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(45, 17);
            this.lblYazar.TabIndex = 8;
            this.lblYazar.Text = "Yazar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(95, 195);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(101, 34);
            this.btnKitapEkle.TabIndex = 10;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 536);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.lblKitapId);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.Label lblKitapId;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKitapEkle;
    }
}

