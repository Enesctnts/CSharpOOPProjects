
namespace V1
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
            this.gbxToplama = new System.Windows.Forms.GroupBox();
            this.btnCarp = new System.Windows.Forms.Button();
            this.tbxToplam = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.Islem = new System.Windows.Forms.ListBox();
            this.gbxToplama.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxToplama
            // 
            this.gbxToplama.Controls.Add(this.btnCarp);
            this.gbxToplama.Controls.Add(this.tbxToplam);
            this.gbxToplama.Controls.Add(this.tbxSayi2);
            this.gbxToplama.Controls.Add(this.tbxSayi1);
            this.gbxToplama.Controls.Add(this.btnTopla);
            this.gbxToplama.Controls.Add(this.lblSayi2);
            this.gbxToplama.Controls.Add(this.lblSayi1);
            this.gbxToplama.Location = new System.Drawing.Point(205, 61);
            this.gbxToplama.Name = "gbxToplama";
            this.gbxToplama.Size = new System.Drawing.Size(511, 220);
            this.gbxToplama.TabIndex = 0;
            this.gbxToplama.TabStop = false;
            this.gbxToplama.Text = "Toplama";
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(244, 84);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(94, 29);
            this.btnCarp.TabIndex = 6;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // tbxToplam
            // 
            this.tbxToplam.Location = new System.Drawing.Point(359, 65);
            this.tbxToplam.Name = "tbxToplam";
            this.tbxToplam.Size = new System.Drawing.Size(125, 27);
            this.tbxToplam.TabIndex = 1;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Location = new System.Drawing.Point(98, 81);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(125, 27);
            this.tbxSayi2.TabIndex = 5;
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Location = new System.Drawing.Point(98, 40);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(125, 27);
            this.tbxSayi1.TabIndex = 4;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(244, 43);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(94, 29);
            this.btnTopla.TabIndex = 1;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(18, 84);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(44, 20);
            this.lblSayi2.TabIndex = 3;
            this.lblSayi2.Text = "Sayi2";
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(18, 43);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(44, 20);
            this.lblSayi1.TabIndex = 2;
            this.lblSayi1.Text = "Sayi1";
            // 
            // Islem
            // 
            this.Islem.FormattingEnabled = true;
            this.Islem.ItemHeight = 20;
            this.Islem.Location = new System.Drawing.Point(367, 287);
            this.Islem.Name = "Islem";
            this.Islem.Size = new System.Drawing.Size(204, 144);
            this.Islem.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.Islem);
            this.Controls.Add(this.gbxToplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxToplama.ResumeLayout(false);
            this.gbxToplama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxToplama;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TextBox tbxToplam;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.ListBox Islem;
    }
}

