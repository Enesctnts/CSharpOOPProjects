using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOrnekV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.Left += 20 + (i * 60);
                btn.Text = i.ToString();
                panel1.Controls.Add(btn);

                btn.Click += Btn_Click;
                btn.MouseEnter += Btn_MouseEnter; 
                btn.MouseLeave += Btn_MouseLeave;
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = this.BackColor;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Text + ". Butona tiklandi");
            textBox1.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Yellow;

        }
    }
}
