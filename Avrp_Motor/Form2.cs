using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avrp_Motor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ClientSize = new Size(1000, 600);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void AddUpdateDate()
        {
            listBox1.Items.Add("Güncelleme Tarihi: " + DateTime.Now.ToString());
        }
        public void AddToListBoxWithHeaders(string[] headers, string[] values)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                listBox2.Items.Add(headers[i] + ": " );
            }
            for (int i = 0; i < headers.Length; i++)
            {
                listBox1.Items.Add(  values[i]);
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0f;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Arial", 20);
            Font headerFont = new Font("Arial", 30, FontStyle.Bold); 
            Font titleFont = new Font("Arial", 35, FontStyle.Bold); 
            Font boldFont = new Font("Arial", 20, FontStyle.Bold); 
            SolidBrush myBrush = new SolidBrush(Color.Black);

            

            Image originalImage = Image.FromFile("C:\\Users\\yusuf\\source\\repos\\Avrp_Motor\\Avrp_Motor\\avrp.jpg"); // Resmin yolu burada belirtilmeli
            Bitmap bitmapImage = new Bitmap(originalImage);

            // Saydamlık ayarları
            float opacity = 0.2f; // Saydamlık oranı: 0.0 (tamamen saydam) - 1.0 (tamamen opak)
            ColorMatrix colorMatrix = new ColorMatrix
            {
                Matrix33 = opacity
            };

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Resmi sayfanın tamamına yay
            Rectangle pageBounds = e.PageBounds;
            e.Graphics.DrawImage(bitmapImage, pageBounds, 0, 0, bitmapImage.Width, bitmapImage.Height, GraphicsUnit.Pixel, imageAttributes);


            line = "AVRUPA MOTOR";
            yPos = topMargin;
            e.Graphics.DrawString(line, titleFont, myBrush, leftMargin + (e.MarginBounds.Width - e.Graphics.MeasureString(line, titleFont).Width) / 2, yPos, new StringFormat());
            yPos += titleFont.GetHeight(e.Graphics);

         
            line = "Müşteri İşlem Bilgileri";
            yPos += 30; 
            e.Graphics.DrawString(line, headerFont, myBrush, leftMargin + (e.MarginBounds.Width - e.Graphics.MeasureString(line, headerFont).Width) / 2, yPos, new StringFormat());
            yPos += headerFont.GetHeight(e.Graphics);

            yPos += 45; 

            
            for (int i = 0; i < listBox1.Items.Count && i < listBox2.Items.Count; i++)
            {
                string value = listBox1.Items[i].ToString();
                string header = listBox2.Items[i].ToString();

                e.Graphics.DrawString(header, boldFont, myBrush, leftMargin, yPos, new StringFormat());
                e.Graphics.DrawString(value, printFont, myBrush, leftMargin + 400, yPos, new StringFormat()); 
                yPos += printFont.GetHeight(e.Graphics);
                yPos += 20; 
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
