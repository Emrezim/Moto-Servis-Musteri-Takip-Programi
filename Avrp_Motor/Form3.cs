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

namespace Avrp_Motor
{
    public partial class Form3 : Form
    {
        private string saseNo;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(string[] values)
        {
            saseNo = values[1]; 
            textBox1.Text = values[1]; 
            textBox2.Text = values[2]; 
            textBox3.Text = values[3]; 
            textBox4.Text = values[4]; 
            textBox7.Text = values[5]; 
            textBox8.Text = values[6]; 
            textBox9.Text = values[7]; 
            textBox10.Text = values[8]; 
            textBox11.Text = values[9]; 
            textBox12.Text = values[10]; 
            textBox13.Text = values[11];
            textBox14.Text = values[12];
            textBox5.Text = values[13];
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Avrupa_Motor;Integrated Security=True; Encrypt=false;"))
                {
                    string kayit = @"UPDATE Servis 
                                 SET Arac_Model = @Arac_Model,
                                     Arac_Sahibi = @Arac_Sahibi,
                                     Plaka = @Plaka,
                                     islem1 = @islem1,
                                     islem2 = @islem2,
                                     islem3 = @islem3,
                                     islem4 = @islem4,
                                     islem5 = @islem5,
                                     islem6 = @islem6,
                                     islem7 = @islem7,
                                     islem8 = @islem8,
                                     Fiyat = @Fiyat,
                                     GuncellemeTarihi = @GuncellemeTarihi
                                 WHERE Sase_No = @Sase_No";

                    using (SqlCommand cmd = new SqlCommand(kayit, conn))
                    {
                        cmd.Parameters.AddWithValue("@Sase_No", saseNo);
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
                        cmd.Parameters.AddWithValue("@Fiyat", textBox5.Text);
                        cmd.Parameters.AddWithValue("@GuncellemeTarihi", DateTime.Now);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Veri güncellendi.");
                    }
                }

               
                Form1 form1 = Application.OpenForms["Form1"] as Form1;
                if (form1 != null)
                {
                    form1.listele();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Form1 bulunamadı.");
                }

               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
