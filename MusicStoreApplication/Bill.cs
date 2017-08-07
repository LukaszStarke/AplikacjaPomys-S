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
using System.IO;
using System.Drawing.Printing;

namespace MusicStoreApplication
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        
        /// <summary>
        ///This method printing generated payment bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintBill_Click(object sender, EventArgs e)
        {

            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.Doc_PrintPage;
                PrintDialog dlgSettings = new PrintDialog();
                dlgSettings.Document = doc;
                if (dlgSettings.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }

        }
        /// <summary>
        /// Support method for PrintBill_Click, set margins for printing payment bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.PaymentBill.Width, this.PaymentBill.Height);
            this.PaymentBill.DrawToBitmap(bmp, new Rectangle(0, 0, this.PaymentBill.Width, this.PaymentBill.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
  
    
    
    
    }
}
