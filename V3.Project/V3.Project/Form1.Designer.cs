
namespace V3.Project
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
            this.lblOgrenciBilgi = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.Bilgiler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblOgrenciBilgi
            // 
            this.lblOgrenciBilgi.AutoSize = true;
            this.lblOgrenciBilgi.Location = new System.Drawing.Point(210, 188);
            this.lblOgrenciBilgi.Name = "lblOgrenciBilgi";
            this.lblOgrenciBilgi.Size = new System.Drawing.Size(175, 20);
            this.lblOgrenciBilgi.TabIndex = 0;
            this.lblOgrenciBilgi.Text = "Öğrenci Bilgilerini Göster";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(239, 220);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(94, 29);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "button1";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Bilgiler
            // 
            this.Bilgiler.FormattingEnabled = true;
            this.Bilgiler.ItemHeight = 20;
            this.Bilgiler.Location = new System.Drawing.Point(463, 12);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(304, 504);
            this.Bilgiler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblOgrenciBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciBilgi;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox Bilgiler;
    }
}

