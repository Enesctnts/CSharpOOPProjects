using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.NetV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBaglanti_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=DESKTOP-HNE43R2;Initial Catalog=KitapDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kitaplar", conn);

            SqlDataReader dr = cmd.ExecuteReader();//Arkada Kendisi New()'liyor.// indisleme yaparak içerdeki değerleri alır

            string baslik = "";
            for (int i = 0; i < dr.FieldCount; i++)
            {
                baslik += dr.GetName(i).ToUpper() + " ";
            }
            listBox1.Items.Add(baslik);

            while (dr.Read())//Satir satir oku diyoruz.
            {
                string satir = "";
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    satir += dr[i] + "  ";
                }
                listBox1.Items.Add(satir);
            }
            
            conn.Close();


        }

        //ExecuteReader --> SELECT cümlelerinde kullanlır.
        //ExecuteNonQuery --> UPDATE,DELETE,INSERT işlemlerinde kullanılır.
        //Executescalar --> Sadece tek bir işlem yapıldıgında kullanılır.Aynı işi ExecuteReader ile de yapılabilir.
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=DESKTOP-HNE43R2;Initial Catalog=KitapDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar(KitapAdi,KategoriID,YazarID) VALUES(@ad,@kID,@yID)", conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@kID", textBox3.Text);
            cmd.Parameters.AddWithValue("@yID", textBox2.Text);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnBaglantisiz_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=DESKTOP-HNE43R2;Initial Catalog=KitapDB;Integrated Security=True";

            //SqlDataAdapter varsa bu baglantisiz yöntemdir Open() , Close() yapmaya gerek yok kendisi yapıyor biz karışmıyoruz.

            //DataSet   --> DataTable'lardan oluşur..
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kitaplar", strConn);

            DataTable dt = new DataTable();

            da.Fill(dt);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    string satir = "";
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        satir += dt.Rows[i][j] + " ";

            //    }
            //    listBox1.Items.Add(satir);
            //}


           DataRow  yeni = dt.NewRow();
            yeni[0] = 123;
            yeni[1] = "Serenat";

            //dt.Rows.Add(yeni);

            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Update(dt);

            dataGridView1.DataSource = dt;

        }
    }
}
