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
    public partial class StoreProducts: Form
    {
        
        public StoreProducts()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// Adding product row to our database, at this method checks if we fill all textboxes and if there are no row with the same ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IDProductBox.Text == "" || ProductNameBox.Text == "" || ProductQuantityBox.Text == "" || ProductUPriceBox.Text == "" || LocalisationBox.Text == "" || DeliveryDateBox.Text == "")
            {
                MessageBox.Show("Please fill all the information boxes", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                    using (SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True"))
                    {
                         
                            con.Open();
                       
                            using (SqlCommand newCmd = new SqlCommand())
                            {
                                if (IfProductsExists(con, IDProductBox.Text))
                                {
                                    MessageBox.Show("Product with that ID already exist...", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {   
                                    newCmd.CommandType = CommandType.Text;
                                    if (pictureBox1.Image != null)
                                    {
                                        try
                                        {
                                            newCmd.CommandText =
                                            @"INSERT INTO [SklepMuzyczny].[dbo].[Store]
                                           (ID_Product
                                           ,ProductName
                                           ,ProductQuantity
                                           ,ProductUnitPrice
                                           ,Localisation
                                           ,DateOfOrder
                                           ,Image)
                                          VALUES
                                          ( @ID_Product
                                           ,@ProductName
                                           ,@ProductQuantity
                                           ,@ProductUnitPrice
                                           ,@Localisation
                                           ,@DateOfOrder
                                           ,@Image)";

                                            MemoryStream ms = new MemoryStream();
                                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                            Byte[] img = ms.ToArray();

                                            newCmd.Parameters.Add("@Image", SqlDbType.Image)
                                                 .Value = (img);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }

                                    else if (pictureBox1.Image == null)
                                    {
                                        try
                                        {
                                            newCmd.CommandText =
                                            @"INSERT INTO [SklepMuzyczny].[dbo].[Store]
                                           (ID_Product
                                           ,ProductName
                                           ,ProductQuantity
                                           ,ProductUnitPrice
                                           ,Localisation
                                           ,DateOfOrder)
                                          VALUES
                                          ( @ID_Product
                                           ,@ProductName
                                           ,@ProductQuantity
                                           ,@ProductUnitPrice
                                           ,@Localisation
                                           ,@DateOfOrder)";
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                        
                                        }
                                    try
                                    {
                                        newCmd.Parameters.Add("@ID_Product", SqlDbType.BigInt)
                                             .Value = System.Convert.ToInt64(IDProductBox.Text);

                                        newCmd.Parameters.Add("@ProductName", SqlDbType.NVarChar)
                                             .Value = System.Convert.ToString(ProductNameBox.Text);

                                        newCmd.Parameters.Add("@ProductQuantity", SqlDbType.Int)
                                             .Value = System.Convert.ToInt64(ProductQuantityBox.Text);

                                        newCmd.Parameters.Add("@ProductUnitPrice", SqlDbType.Money)
                                             .Value = System.Convert.ToDouble(ProductUPriceBox.Text);

                                        newCmd.Parameters.Add("@Localisation", SqlDbType.VarChar)
                                             .Value = System.Convert.ToString(LocalisationBox.Text);

                                        newCmd.Parameters.Add("@DateOfOrder", SqlDbType.Date);
                                        newCmd.Parameters["@DateOfOrder"].Value = DeliveryDateBox.Value.ToString("yyyy-MM-dd");

                                        newCmd.Connection = con;

                                        newCmd.ExecuteNonQuery();

                                        con.Close();

                                        MessageBox.Show("Product has been successfully added", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// Method that checks if there is no the same ID as we writting in ID_ProductBox
        /// </summary>
        /// <param name="con"></param>
        /// <param name="ID_Product"></param>
        /// <returns></returns>
        public bool IfProductsExists(SqlConnection con, string ID_Product)
           {

               SqlDataAdapter sda = new SqlDataAdapter("Select 1 from [SklepMuzyczny].[dbo].[Store] Where [ID_Product] ='" + ID_Product + "'", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
                
               if (dt.Rows.Count > 0)
                   return true;
               else
                   return false;

           }

        /// <summary>
        /// Method that load data to specific rows in our ProductsGrindView
        /// </summary>
           public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[Store] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ProductsGrindView.Rows.Clear();

               foreach(DataRow item in dt.Rows)
            {
                
                int n = ProductsGrindView.Rows.Add();
            
                ProductsGrindView.Rows[n].Cells[0].Value = item["ID_Product"].ToString();
                ProductsGrindView.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                ProductsGrindView.Rows[n].Cells[2].Value = item["ProductQuantity"].ToString();
                ProductsGrindView.Rows[n].Cells[3].Value = item["ProductUnitPrice"].ToString();
                ProductsGrindView.Rows[n].Cells[4].Value = item["Localisation"].ToString();
                ProductsGrindView.Rows[n].Cells[5].Value = item["DateOfOrder"];
                ProductsGrindView.Rows[n].Cells[6].Value = item["Image"];
                     
               }
        }
           
        /// <summary>
        /// This method copy clicked rows to specific texboxes and image to pictureBox (if exists) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsGrindView_MouseClick(object sender, MouseEventArgs e)
        {
            IDProductBox.Text = ProductsGrindView.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameBox.Text = ProductsGrindView.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantityBox.Text = ProductsGrindView.SelectedRows[0].Cells[2].Value.ToString();
            ProductUPriceBox.Text = ProductsGrindView.SelectedRows[0].Cells[3].Value.ToString();
            LocalisationBox.Text = ProductsGrindView.SelectedRows[0].Cells[4].Value.ToString();
            DeliveryDateBox.Text = ProductsGrindView.SelectedRows[0].Cells[5].Value.ToString();


            if (ProductsGrindView.SelectedRows[0].Cells[6].Value.ToString() != string.Empty)
            {
                byte[] img = (byte[])ProductsGrindView.CurrentRow.Cells[6].Value;

                MemoryStream ms1 = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms1);
               
            }
            else
            {
                pictureBox1.Image = null;
            
            }
            
            }

        /// <summary>
        /// This method delete row from database with written ID in IDProductBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");

            var SqlQuery = "";
            if (IfProductsExists(con, IDProductBox.Text))
            {
                try
                {
                    con.Open();
                    SqlQuery = "Delete from [SklepMuzyczny].[dbo].[Store] Where [ID_Product] = '" + IDProductBox.Text + "'";

                    SqlCommand newCmd = new SqlCommand(SqlQuery, con);
                    newCmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Record not exists..!");

            }
            
        }
        /// <summary>
        /// This method update row database with written ID in IDProductBox.Text (if rows exists)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (IDProductBox.Text == "" || ProductNameBox.Text == "" || ProductQuantityBox.Text == "" || ProductUPriceBox.Text == "" || LocalisationBox.Text == "" || DeliveryDateBox.Text == "")
            {
                MessageBox.Show("Please fill all the information boxes", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
                
                if (IfProductsExists(con, IDProductBox.Text))
                {

                    if (pictureBox1.Image != null)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {   
                          try {
                            con.Open();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = @"Update [SklepMuzyczny].[dbo].[Store] set ProductName = '" + ProductNameBox.Text + "',ProductQuantity ='" + ProductQuantityBox.Text + "',ProductUnitPrice = @ProductUnitPrice ,Localisation ='" + LocalisationBox.Text + "',DateOfOrder ='" + DeliveryDateBox.Value.ToString("yyyy-MM-dd") + "',Image = @Image Where [ID_Product] = '" + IDProductBox.Text + "'";

                            cmd.Parameters.Add("@ProductUnitPrice", SqlDbType.Decimal)
                             .Value = System.Convert.ToDouble(ProductUPriceBox.Text);



                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            Byte[] img = ms.ToArray();
                            
                            cmd.Parameters.Add("@Image", SqlDbType.Image)
                             .Value = (img);
                            
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            LoadData();
                          }
                            catch (Exception ex)
                            {
                            MessageBox.Show(ex.Message);
                            }
                        }

                    } 
                            if (pictureBox1.Image == null)
                            {
                                using (SqlCommand cmd = new SqlCommand())
                                {
                                  try
                                  {
                                    con.Open();
                                    cmd.CommandType = CommandType.Text;

                                    cmd.CommandText = @"Update [SklepMuzyczny].[dbo].[Store] set ProductName = '" + ProductNameBox.Text + "',ProductQuantity ='" + ProductQuantityBox.Text + "',ProductUnitPrice = @ProductUnitPrice ,Localisation ='" + LocalisationBox.Text + "',DateOfOrder ='" + DeliveryDateBox.Value.ToString("yyyy-MM-dd") + "' Where [ID_Product] = '" + IDProductBox.Text + "'";

                                    cmd.Parameters.Add("@ProductUnitPrice", SqlDbType.Decimal)
                                         .Value = System.Convert.ToDouble(ProductUPriceBox.Text);

                                    
                                    cmd.Connection = con;
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    LoadData();
                                }
                                  catch (Exception ex)
                                  {
                                      MessageBox.Show(ex.Message);
                                  }
                                
                                }
                             }
                          }
                              else
                                    {
                                        MessageBox.Show("Record not exists..!");

                                    }   
                
            }
        }

        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDProductBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductQuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        /// <summary>
        /// Method that not allow write text different than numeric and allow to write one coma 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductUPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            e.Handled = NumberField(sender, e);
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }   
            
        }

        /// <summary>
        /// Help method for ProductUPriceBox_KeyPress it return false when values is number from 0 to 9, backspace or coma (ANSCII)
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
        /// Method for Uploading product images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public string imgLog = "";
        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg) |*.jpg|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Please select product picture";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLog = dlg.FileName.ToString();
                    PathBox.Text = imgLog;
                    pictureBox1.ImageLocation = imgLog;
                
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            
            }
        }
        /// <summary>
        /// Method that show bigger picture in new window when row is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsGrindView_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (ProductsGrindView.SelectedRows[0].Cells[6].Value.ToString() == string.Empty)
                {

                    MessageBox.Show("There is no image file of this product", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Picture picture = new Picture();
                    byte[] img = (byte[])ProductsGrindView.CurrentRow.Cells[6].Value;

                    MemoryStream ms = new MemoryStream(img);
                    picture.pictureBox.Image = Image.FromStream(ms);
                    picture.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
    }
  }
   



