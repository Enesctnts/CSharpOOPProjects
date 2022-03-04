
namespace EntityFrameworkCodeFirst
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLazy = new System.Windows.Forms.Button();
            this.btnEager = new System.Windows.Forms.Button();
            this.btnKatogoriEkle = new System.Windows.Forms.Button();
            this.btnFilmAra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnLazy
            // 
            this.btnLazy.Location = new System.Drawing.Point(223, 100);
            this.btnLazy.Name = "btnLazy";
            this.btnLazy.Size = new System.Drawing.Size(112, 44);
            this.btnLazy.TabIndex = 2;
            this.btnLazy.Text = "Lazy";
            this.btnLazy.UseVisualStyleBackColor = true;
            this.btnLazy.Click += new System.EventHandler(this.btnLazy_Click);
            // 
            // btnEager
            // 
            this.btnEager.Location = new System.Drawing.Point(371, 100);
            this.btnEager.Name = "btnEager";
            this.btnEager.Size = new System.Drawing.Size(112, 44);
            this.btnEager.TabIndex = 3;
            this.btnEager.Text = "Eager";
            this.btnEager.UseVisualStyleBackColor = true;
            this.btnEager.Click += new System.EventHandler(this.btnEager_Click);
            // 
            // btnKatogoriEkle
            // 
            this.btnKatogoriEkle.Location = new System.Drawing.Point(526, 73);
            this.btnKatogoriEkle.Name = "btnKatogoriEkle";
            this.btnKatogoriEkle.Size = new System.Drawing.Size(112, 71);
            this.btnKatogoriEkle.TabIndex = 4;
            this.btnKatogoriEkle.Text = "Kategori Ekle";
            this.btnKatogoriEkle.UseVisualStyleBackColor = true;
            this.btnKatogoriEkle.Click += new System.EventHandler(this.btnKatogoriEkle_Click);
            // 
            // btnFilmAra
            // 
            this.btnFilmAra.Location = new System.Drawing.Point(950, 12);
            this.btnFilmAra.Name = "btnFilmAra";
            this.btnFilmAra.Size = new System.Drawing.Size(112, 71);
            this.btnFilmAra.TabIndex = 5;
            this.btnFilmAra.Text = "Film Ara";
            this.btnFilmAra.UseVisualStyleBackColor = true;
            this.btnFilmAra.Click += new System.EventHandler(this.btnFilmAra_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1105, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "Bul ve Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1258, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 71);
            this.button3.TabIndex = 7;
            this.button3.Text = "Bul ve Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(836, 116);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 33);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(954, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 33);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 481);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFilmAra);
            this.Controls.Add(this.btnKatogoriEkle);
            this.Controls.Add(this.btnEager);
            this.Controls.Add(this.btnLazy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnEager;
        private System.Windows.Forms.Button btnKatogoriEkle;
        private System.Windows.Forms.Button btnFilmAra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox textBox1;
    }
}

