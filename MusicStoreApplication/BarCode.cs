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
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Printing;
namespace MusicStoreApplication
{
    public partial class BarCode : Form
    {
        public BarCode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creating barcode with Zen Bar Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDProductTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                BarCodePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                BarCodePictureBox.Image = barcode.Draw(IDProductTxtBox.Text, 100);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        /// <summary>
        /// Method that print generated barcode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {

            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();

        }
        /// <summary>
        /// Support method for PrintButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(BarCodePictureBox.Width, BarCodePictureBox.Height);
            BarCodePictureBox.DrawToBitmap(bm, new Rectangle(0, 0, BarCodePictureBox.Width, BarCodePictureBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

        }

        /// <summary>
        /// Generating ID number at the top of generated BarCode, set Font,Textsize,location to draw. etc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarCodePictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                PointF locationToDraw = new PointF();
                SizeF textSize = e.Graphics.MeasureString(IDProductTxtBox.Text, myFont);
                locationToDraw.X = (BarCodePictureBox.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (BarCodePictureBox.Height / 6) - (textSize.Height / 2);
                e.Graphics.DrawString(IDProductTxtBox.Text, myFont, Brushes.Black, locationToDraw);
            }
            
        }

        

        
    }
}
