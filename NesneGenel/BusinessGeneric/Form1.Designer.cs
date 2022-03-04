
namespace BusinessGeneric
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
            this.btnFilmler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnYonetmenler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilmler
            // 
            this.btnFilmler.Location = new System.Drawing.Point(90, 118);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Size = new System.Drawing.Size(125, 40);
            this.btnFilmler.TabIndex = 0;
            this.btnFilmler.Text = "Filmler";
            this.btnFilmler.UseVisualStyleBackColor = true;
            this.btnFilmler.Click += new System.EventHandler(this.btnFilmler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 175);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(272, 118);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(131, 40);
            this.btnKategoriler.TabIndex = 2;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnYonetmenler
            // 
            this.btnYonetmenler.Location = new System.Drawing.Point(490, 118);
            this.btnYonetmenler.Name = "btnYonetmenler";
            this.btnYonetmenler.Size = new System.Drawing.Size(132, 40);
            this.btnYonetmenler.TabIndex = 3;
            this.btnYonetmenler.Text = "Yonetmentler";
            this.btnYonetmenler.UseVisualStyleBackColor = true;
            this.btnYonetmenler.Click += new System.EventHandler(this.btnYonetmenler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYonetmenler);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnYonetmenler;
    }
}

