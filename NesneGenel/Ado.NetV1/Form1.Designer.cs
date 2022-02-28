
namespace Ado.NetV1
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
            this.btnBaglanti = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.lblKitap = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnBaglantisiz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglanti
            // 
            this.btnBaglanti.Location = new System.Drawing.Point(78, 393);
            this.btnBaglanti.Name = "btnBaglanti";
            this.btnBaglanti.Size = new System.Drawing.Size(135, 45);
            this.btnBaglanti.TabIndex = 0;
            this.btnBaglanti.Text = "Baglantili Yontem(Select)";
            this.btnBaglanti.UseVisualStyleBackColor = true;
            this.btnBaglanti.Click += new System.EventHandler(this.btnBaglanti_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(538, 212);
            this.listBox1.TabIndex = 1;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(267, 124);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(119, 29);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(168, 22);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(64, 17);
            this.lblKitap.TabIndex = 3;
            this.lblKitap.Text = "Kitap Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 6;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(168, 63);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(58, 17);
            this.lblYazar.TabIndex = 5;
            this.lblYazar.Text = "YazarID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(254, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 8;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(168, 99);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(74, 17);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "KategoriID";
            // 
            // btnBaglantisiz
            // 
            this.btnBaglantisiz.Location = new System.Drawing.Point(380, 393);
            this.btnBaglantisiz.Name = "btnBaglantisiz";
            this.btnBaglantisiz.Size = new System.Drawing.Size(135, 45);
            this.btnBaglantisiz.TabIndex = 9;
            this.btnBaglantisiz.Text = "Baglantisiz Yöntem";
            this.btnBaglantisiz.UseVisualStyleBackColor = true;
            this.btnBaglantisiz.Click += new System.EventHandler(this.btnBaglantisiz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(585, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 296);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBaglantisiz);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBaglanti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaglanti;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnBaglantisiz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

