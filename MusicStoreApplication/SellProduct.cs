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

namespace MusicStoreApplication
{
    public partial class SellProduct : Form
    {
        /// <summary>
        /// Initiation form with addition assignment operator for two texboxes and TextChanged method and loaded data from database
        /// </summary>
        public SellProduct()
        {

            InitializeComponent();
            ProductUnitPriceTxtBox.TextChanged += TextChanged;
            ProductQuantityTxtBox.TextChanged += TextChanged;
            LoadData();

        }
        /// <summary>
        /// Method that load data to specific rows in ProductsGridView
        /// </summary>
        DataTable dt;
        private void LoadProducts_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[Store] ", con);
            dt = new DataTable();
            sda.Fill(dt);
            ProductGridView.DataSource = dt;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)ProductGridView.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
           

            foreach (DataGridViewRow row in ProductGridView.Rows)
            {
                row.Height = 60;

            }

        }

        /// <summary>
        /// Method that filtr (substring search) (if there are rows in ProductGridView) for writted ID in IDProductsTxtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDProductsTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no products or records are not loaded", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("convert(ID_Product, 'System.String') Like '%{0}%' ", IDProductSearchTxtBox.Text);
                ProductGridView.DataSource = dv;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)ProductGridView.Columns[6];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (DataGridViewRow row in ProductGridView.Rows)
                {
                    row.Height = 60;

                }
            }
        }
        /// <summary>
        /// Method that filter (substring search) (if there are rows in ProductGridView) for writted Name in ProductNameTxtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no products or records are not loaded", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("convert(ProductName, 'System.String') Like '%{0}%' ", ProductNameSearchTxtBox.Text);
            ProductGridView.DataSource = dv;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)ProductGridView.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in ProductGridView.Rows)
            {
                row.Height = 60;

            }
           }
        }

        /// <summary>
        /// This method copy clicked rows to specific texboxes
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrepareButton_Click(object sender, EventArgs e)
        {

            if (ProductGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no products or records are not loaded", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IDProductTxtBox.Text = this.ProductGridView.CurrentRow.Cells[0].Value.ToString();
                ProductNameTxtBox.Text = this.ProductGridView.CurrentRow.Cells[1].Value.ToString();
                ProductUnitPriceTxtBox.Text = this.ProductGridView.CurrentRow.Cells[3].Value.ToString();
            }
            }
        /// <summary>
        /// Method adds sell product row to our database, at this method checks if we fill all textboxes and if there are no row with the same ID
        /// and checked that the sell quantity is smaller than quantity in store, and automatically substract the sold quantity from store
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellProductButton_Click(object sender, EventArgs e)
        {
            if (IDProductTxtBox.Text == "" || ProductNameTxtBox.Text == "" || ProductUnitPriceTxtBox.Text == "" || IDSellTxtBox.Text == "" || ProductQuantityTxtBox.Text == "" || WayOfPaymentComboBox.Text == "")
            {
                MessageBox.Show("Please fill all the information boxes", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
                SqlCommand sqlCmd = new SqlCommand("SELECT ProductQuantity FROM Store WHERE ID_Product = '" + IDProductTxtBox.Text + "'", con);
                con.Open();
                
                if (IfProductsExists(con, IDSellTxtBox.Text))
                      {

                    MessageBox.Show("Product with that ID already exist..." , "Completed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                else
                {
                
                int ProductQuantity = Convert.ToInt32(sqlCmd.ExecuteScalar());
                int SalesQuantity;
                SalesQuantity = Convert.ToInt32(ProductQuantityTxtBox.Text);
                if (SalesQuantity > ProductQuantity)
                {
                    MessageBox.Show("There is not enough quantity in the store", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SalesQuantity <= ProductQuantity)
                {
                    using (con)
                    {
                        try
                        {       
                            SqlCommand newCmd = new SqlCommand
                                (@"INSERT INTO [SklepMuzyczny].[dbo].[SoldHistory]
                                   (ID_Sell
                                   ,ID_Product
                                   ,ProductName
                                   ,ProductQuantity
                                   ,ProductUnitPrice
                                   ,TotalPrice
                                   ,Time
                                   ,WayOfPayment
                                   ,DateOfBought)
                             VALUES
                                  ( @ID_Sell
                                   ,@ID_Product
                                   ,@ProductName
                                   ,@ProductQuantity
                                   ,@ProductUnitPrice
                                   ,@TotalPrice
                                   ,@Time
                                   ,@WayOfPayment
                                   ,@DateOfBought)");

                            newCmd.Parameters.Add("@ID_Sell", SqlDbType.BigInt)
                                .Value = System.Convert.ToInt64(IDSellTxtBox.Text);

                            newCmd.Parameters.Add("@ID_Product", SqlDbType.BigInt)
                                 .Value = System.Convert.ToInt64(IDProductTxtBox.Text);

                            newCmd.Parameters.Add("@ProductName", SqlDbType.NVarChar)
                                 .Value = System.Convert.ToString(ProductNameTxtBox.Text);

                            newCmd.Parameters.Add("@ProductQuantity", SqlDbType.Int)
                                 .Value = System.Convert.ToInt64(ProductQuantityTxtBox.Text);

                            newCmd.Parameters.Add("@ProductUnitPrice", SqlDbType.Money)
                                 .Value = System.Convert.ToDouble(ProductUnitPriceTxtBox.Text);

                            newCmd.Parameters.Add("@TotalPrice", SqlDbType.Money)
                                 .Value = System.Convert.ToDouble(TotalPriceTxtBox.Text);

                            newCmd.Parameters.Add("@Time", SqlDbType.Time)
                                 .Value = System.Convert.ToString(DateTime.Now.ToString("HH:mm:ss tt"));

                            newCmd.Parameters.Add("@WayOfPayment", SqlDbType.NVarChar)
                                 .Value = System.Convert.ToString(WayOfPaymentComboBox.Text);

                            newCmd.Parameters.Add("@DateOfBought", SqlDbType.Date)
                            .Value = System.Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));

                            newCmd.Connection = con;
                            newCmd.ExecuteNonQuery();
                            con.Close();

                            con.Open();
               
                            SqlCommand newCmd1 = new SqlCommand
                            (@"Update [SklepMuzyczny].[dbo].[Store]
                                SET ProductQuantity = ProductQuantity - @Quantity
                                WHERE ID_Product = @IDProduct", con);

                            newCmd1.Parameters.Add("@Quantity", SqlDbType.Int)
                            .Value = System.Convert.ToInt64(ProductQuantityTxtBox.Text);

                            newCmd1.Parameters.Add("@IDProduct", SqlDbType.BigInt)
                            .Value = System.Convert.ToInt64(IDProductTxtBox.Text);

                            newCmd1.Connection = con;
                            newCmd1.ExecuteNonQuery();
                            con.Close();
                      
                            MessageBox.Show("Product has been successfully sold", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }

                        catch (Exception ex)
                        
                        {
                            MessageBox.Show(ex.Message);
                        }

                       }
                   }
                }
            }
        }
        /// <summary>
        /// Multiplying sold quantity * unit price and return value in TotalPriceTxtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChanged(object sender, EventArgs e)
        {
            double val1;
            double val2;

            if (!double.TryParse(ProductQuantityTxtBox.Text, out val1) || !double.TryParse(ProductUnitPriceTxtBox.Text, out val2))
                return;

            Double val3 = val1 * val2;
            TotalPriceTxtBox.Text = val3.ToString();
        }
        /// <summary>
        /// Method that checks if there is no the same ID as we writting in IDSellTxtBox)
        /// </summary>
        /// <param name="con"></param>
        /// <param name="ID_Sell"></param>
        /// <returns></returns>
        public bool IfProductsExists(SqlConnection con, string ID_Sell)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 from [SklepMuzyczny].[dbo].[SoldHistory] Where [ID_Sell] ='" + ID_Sell + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        /// <summary>
        ///  Method that load data to specific rows in our SellHistoryGrindView
        /// </summary>
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[SoldHistory] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SellHistoryGridView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = SellHistoryGridView.Rows.Add();

                SellHistoryGridView.Rows[n].Cells[0].Value = item["ID_Sell"].ToString();
                SellHistoryGridView.Rows[n].Cells[1].Value = item["ID_Product"].ToString();
                SellHistoryGridView.Rows[n].Cells[2].Value = item["ProductName"].ToString();
                SellHistoryGridView.Rows[n].Cells[3].Value = item["ProductQuantity"].ToString();
                SellHistoryGridView.Rows[n].Cells[4].Value = item["ProductUnitPrice"].ToString();
                SellHistoryGridView.Rows[n].Cells[5].Value = item["TotalPrice"].ToString();
                SellHistoryGridView.Rows[n].Cells[6].Value = item["Time"].ToString();
                SellHistoryGridView.Rows[n].Cells[7].Value = item["WayOfPayment"].ToString();
                SellHistoryGridView.Rows[n].Cells[8].Value = item["DateOfBought"].ToString();

            }
        }

        /// <summary>
        /// Method that show bigger picture in new window when row is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ProductGridView.SelectedRows[0].Cells[6].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There is no image file of this product", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Picture picture = new Picture();
                byte[] img = (byte[])ProductGridView.CurrentRow.Cells[6].Value;

                MemoryStream ms = new MemoryStream(img);
                picture.pictureBox.Image = Image.FromStream(ms);
                picture.ShowDialog();
            }
        }

        /// <summary>
        /// Generating payment bill from selected row or rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateBillButton_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BarCode")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                string productsnames = "";
                string quantityprice = "";
                double sumtotalprice = 0;
                for (int c = 0; c < SellHistoryGridView.Rows.Count; c++)
                {

                    if (SellHistoryGridView.Rows[c].Selected == true)
                    {
                        productsnames += this.SellHistoryGridView.Rows[c].Cells[2].Value.ToString() + Environment.NewLine;

                        quantityprice += this.SellHistoryGridView.Rows[c].Cells[3].Value.ToString() + "x" + this.SellHistoryGridView.Rows[c].Cells[4].Value.ToString() + Environment.NewLine;

                        sumtotalprice = sumtotalprice + double.Parse(this.SellHistoryGridView.Rows[c].Cells[5].Value.ToString());

                    }
                }
                Bill bill = new Bill();
                bill.ProductNames.Text = productsnames;
                bill.TotalPriceValue.Text = sumtotalprice.ToString("#0.00");
                bill.QuantityAndUnitPrice.Text = quantityprice;
                bill.Show();

                foreach (DataGridViewCell cell in SellHistoryGridView.SelectedCells)
                {
                    bill.label15.Text = this.SellHistoryGridView.CurrentRow.Cells[8].Value.ToString();
                    bill.label14.Text = this.SellHistoryGridView.CurrentRow.Cells[6].Value.ToString();
                }
            }

            else
            {
                MessageBox.Show("Please  select product first");
            }
        }

        /// <summary>
        /// Method that not allow write text different than numeric and allow to write one coma 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumberField(sender, e);
            
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }      
        }

        /// <summary>
        /// Method that not allow write text different than numeric and allow to write one coma 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductUnitPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumberField(sender, e);
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Help method for ProductUPriceTxtBox_KeyPress it return false when values is number from 0 to 9, backspace or coma (ANSCII)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool NumberField(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDProductTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDSellTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductQuantityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDProductsTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}



