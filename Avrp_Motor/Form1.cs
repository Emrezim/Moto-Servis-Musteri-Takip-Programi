using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Avrp_Motor
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void listele()
        {
            try
            {
                conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Avrupa_Motor;Integrated Security=True; Encrypt=false;");
                string kayit = "select * from Servis ";
                da = new SqlDataAdapter(kayit, conn);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Avrupa_Motor;Integrated Security=True; Encrypt=false;");
                string kayit = "insert into Servis (Sase_No, Arac_Model, Arac_Sahibi, Plaka, islem1, islem2, islem3, islem4, islem5, islem6, islem7, islem8, Fiyat) values (@Sase_No, @Arac_Model, @Arac_Sahibi, @Plaka, @islem1, @islem2, @islem3, @islem4, @islem5, @islem6, @islem7, @islem8, @Fiyat)";
                cmd = new SqlCommand(kayit, conn);

                cmd.Parameters.AddWithValue("@Sase_No", textBox1.Text);
                cmd.Parameters.AddWithValue("@Arac_Model", textBox2.Text);
                cmd.Parameters.AddWithValue("@Arac_Sahibi", textBox3.Text);
                cmd.Parameters.AddWithValue("@Plaka", textBox4.Text);
                cmd.Parameters.AddWithValue("@islem1", textBox7.Text);
                cmd.Parameters.AddWithValue("@islem2", textBox8.Text);
                cmd.Parameters.AddWithValue("@islem3", textBox9.Text);
                cmd.Parameters.AddWithValue("@islem4", textBox10.Text);
                cmd.Parameters.AddWithValue("@islem5", textBox11.Text);
                cmd.Parameters.AddWithValue("@islem6", textBox12.Text);
                cmd.Parameters.AddWithValue("@islem7", textBox13.Text);
                cmd.Parameters.AddWithValue("@islem8", textBox14.Text);
                cmd.Parameters.AddWithValue("@Fiyat", int.Parse(textBox5.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string aramaKriteri = textBox6.Text;

                conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Avrupa_Motor;Integrated Security=True; Encrypt=false;");

                string kayit = "SELECT * FROM Servis WHERE Sase_No LIKE @aramaKriteri OR Arac_Sahibi LIKE @aramaKriteri OR Arac_Model LIKE @aramaKriteri OR Plaka LIKE @aramaKriteri";
                cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@aramaKriteri", "%" + aramaKriteri + "%");

                da = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    // DataGridView'den Sase_No değerini al
                    string sase = dataGridView1.CurrentRow.Cells["saseNoDataGridViewTextBoxColumn"].Value.ToString();

                    // SQL bağlantısını oluştur
                    using (conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Avrupa_Motor;Integrated Security=True; Encrypt=false;"))
                    {
                        // SQL silme komutunu oluştur
                        string kayit = "DELETE FROM Servis WHERE Sase_No = @Sase_No";
                        using (cmd = new SqlCommand(kayit, conn))
                        {
                            // Parametreyi ekle
                            cmd.Parameters.AddWithValue("@Sase_No", sase);

                            // Bağlantıyı aç ve komutu çalıştır
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Yeniden listele
                    listele();
                }
                catch (Exception ex)
                {
                    // Hata mesajı göster
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                // Kayıt seçilmedi uyarısı göster
                MessageBox.Show("Silmek için bir kayıt seçin.");
            }
        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Seçilen satırdaki verileri al
                string[] values = new string[dataGridView1.ColumnCount];
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    values[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                }

                // Form3'ü oluştur ve verileri yükle
                Form3 form3 = new Form3();
                form3.LoadData(values);

                // Form3'ü göster
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Güncellemek için bir kayıt seçin.");
            }
        }

        private void dataGridView1_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            // Yeni Form2'yi oluştur
            Form2 form2 = new Form2();

            // Tıklanan hücredeki verileri ve sütun adlarını al
            string[] headers = new string[dataGridView1.ColumnCount];
            string[] values = new string[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                headers[i] = dataGridView1.Columns[i].HeaderText;
                values[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
            }

            // Verileri ve başlıkları Form2'deki ListBox'a ekle
            form2.AddToListBoxWithHeaders(headers, values);

            // Form2'yi göster
            form2.Show();
        }
    }
}

