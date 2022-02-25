
namespace WndTextShop
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
            this.lstEfekler = new System.Windows.Forms.ListBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnUygula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEfekler
            // 
            this.lstEfekler.FormattingEnabled = true;
            this.lstEfekler.ItemHeight = 16;
            this.lstEfekler.Location = new System.Drawing.Point(60, 73);
            this.lstEfekler.Name = "lstEfekler";
            this.lstEfekler.Size = new System.Drawing.Size(320, 180);
            this.lstEfekler.TabIndex = 0;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(471, 82);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(215, 22);
            this.txtMesaj.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(468, 123);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblSonuc.TabIndex = 2;
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(488, 167);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(126, 41);
            this.btnUygula.TabIndex = 3;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lstEfekler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEfekler;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnUygula;
    }
}

