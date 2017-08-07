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

namespace MusicStoreApplication
{
    public partial class StoreOrders : Form
    {
        public StoreOrders()
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
            if (IDOrderBox.Text == "" || OrderNameBox.Text == "" || OrderQualityBox.Text == "" || OrderPriceBox.Text == "" || AdresBox.Text == "" || DateOfOrderBox.Text == "")
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
                        try
                        {
                            newCmd.CommandType = CommandType.Text;
                            newCmd.CommandText =
                             @"INSERT INTO [dbo].[Orders]
                               (ID_Order
                               ,OrderName
                               ,OrderStatus
                               ,OrderQuantity
                               ,OrderPrice
                               ,Adres
                               ,DateOfOrder)
                         VALUES
                               (@ID_Order
                               ,@OrderName
                               ,'Added to the system'
                               ,@OrderQuantity
                               ,@OrderPrice
                               ,@Adres
                               ,@DateOfOrder)";

                            newCmd.Parameters.Add("@ID_Order", SqlDbType.Int)
                                 .Value = System.Convert.ToInt64(IDOrderBox.Text);

                            newCmd.Parameters.Add("@OrderName", SqlDbType.NVarChar)
                                 .Value = System.Convert.ToString(OrderNameBox.Text);

                            newCmd.Parameters.Add("@OrderQuantity", SqlDbType.Int)
                                 .Value = System.Convert.ToInt64(OrderQualityBox.Text);

                            newCmd.Parameters.Add("@OrderPrice", SqlDbType.Money)
                                 .Value = System.Convert.ToDouble(OrderPriceBox.Text);

                            newCmd.Parameters.Add("@Adres", SqlDbType.VarChar)
                                 .Value = System.Convert.ToString(AdresBox.Text);


                            newCmd.Parameters.Add("@DateOfOrder", SqlDbType.Date);
                            newCmd.Parameters["@DateOfOrder"].Value = DateOfOrderBox.Value.ToString("yyyy-MM-dd");

                            newCmd.Connection = con;

                            newCmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Order has been successfully added", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// <summary>
        /// Method that checks if there is no the same ID as we writting in ID_ProductBox
        /// </summary>
        /// <param name="con"></param>
        /// <param name="ID_Order"></param>
        /// <returns></returns>
        public bool IfProductsExists(SqlConnection con, string ID_Order)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 from [SklepMuzyczny].[dbo].[Orders] Where [ID_Order] ='" + ID_Order + "'", con);
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
                SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[Orders] ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OrdersGridView.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {   try
                    {
                    int n = OrdersGridView.Rows.Add();

                    OrdersGridView.Rows[n].Cells[0].Value = item["ID_Order"].ToString();
                    OrdersGridView.Rows[n].Cells[1].Value = item["OrderName"].ToString();
                    OrdersGridView.Rows[n].Cells[2].Value = item["OrderStatus"].ToString();
                    OrdersGridView.Rows[n].Cells[3].Value = item["OrderQuantity"].ToString();
                    OrdersGridView.Rows[n].Cells[4].Value = item["OrderPrice"].ToString();
                    OrdersGridView.Rows[n].Cells[5].Value = item["Adres"].ToString();

                    OrdersGridView.Rows[n].Cells[6].Value = item["DateOfOrder"].ToString();
                    }
                    catch(Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }   
        }

        /// <summary>
        /// This method copy clicked rows to specific texboxes and image to pictureBox (if exists) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                IDOrderBox.Text = OrdersGridView.SelectedRows[0].Cells[0].Value.ToString();
                OrderNameBox.Text = OrdersGridView.SelectedRows[0].Cells[1].Value.ToString();
                OrderQualityBox.Text = OrdersGridView.SelectedRows[0].Cells[3].Value.ToString();
                OrderPriceBox.Text = OrdersGridView.SelectedRows[0].Cells[4].Value.ToString();
                AdresBox.Text = OrdersGridView.SelectedRows[0].Cells[5].Value.ToString();

                DateOfOrderBox.Text = OrdersGridView.SelectedRows[0].Cells[6].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        /// <summary>
        /// This method update row database with written ID in IDProductBox.Text (if rows exists)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IDOrderBox.Text == "" || OrderNameBox.Text == "" || OrderQualityBox.Text == "" || OrderPriceBox.Text == "" || AdresBox.Text == "" || DateOfOrderBox.Text == "")
            {
                MessageBox.Show("Please fill all the information boxes", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
                if (IfProductsExists(con, IDOrderBox.Text))
                {
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        try
                        {
                            con.Open();
                            Cmd.CommandType = CommandType.Text;
                            Cmd.CommandText = @"Update [SklepMuzyczny].[dbo].[Orders] set OrderName = '" + OrderNameBox.Text + "',OrderQuantity ='" + OrderQualityBox.Text + "',OrderPrice = @OrderPrice ,Adres='" + AdresBox.Text + "',DateOfOrder ='" + DateOfOrderBox.Value.ToString("yyyy-MM-dd") + "' Where [ID_Order] = '" + IDOrderBox.Text + "'";

                            Cmd.Parameters.Add("@OrderPrice", SqlDbType.Decimal)
                                 .Value = System.Convert.ToDouble(OrderPriceBox.Text);

                            Cmd.Connection = con;
                            Cmd.ExecuteNonQuery();
                            con.Close();
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
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
        /// This method delete row from database with written ID in IDProductBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");

                var SqlQuery = "";
                if (IfProductsExists(con, IDOrderBox.Text))
                {
                    try
                    {
                        con.Open();
                        SqlQuery = "Delete from [SklepMuzyczny].[dbo].[Orders] Where [ID_Order] = '" + IDOrderBox.Text + "'";

                        SqlCommand newCmd = new SqlCommand(SqlQuery, con);
                        newCmd.ExecuteNonQuery();
                        con.Close();
                        LoadData();
                    }
                    catch (Exception ex)
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
        /// Method that not allow write text different than numeric 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDOrderBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        /// <summary>
        /// Method that not allow write text different than numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderQualityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        /// <summary>
        /// Method that not allow write text different than numeric and allow to write one coma 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderPriceBox_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}