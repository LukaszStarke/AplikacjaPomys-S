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
using Zen.Barcode;

namespace MusicStoreApplication
{
    public partial class SearchProducts : Form
    {
        public SearchProducts()
        {
            InitializeComponent();

        }
        DataTable dt;

        /// <summary>
        /// Method that load data to ProductGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAllProductsButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[Store] ", con);
            dt = new DataTable();
            sda.Fill(dt);
            ProductGridView.DataSource = dt;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)ProductGridView.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in ProductGridView.Rows)
            {
                row.Height = 60;
            }
        }

        /// <summary>
        /// Method that filter (substring search) (if there are rows in ProductGridView and value in comboBox)
        /// for selected parametr in comboSearch and searching phrase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPhraseTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem == null ||  ProductGridView.Rows.Count == 0)
            {               
                MessageBox.Show("Please select a search criteria and load data");
            }
            else
            {
               
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", comboSearch.Text.Trim(), SearchPhraseTxtBox.Text.Trim());
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
        /// Generating bar code for selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarCodeButton_Click(object sender, EventArgs e)
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
                if (ProductGridView.SelectedRows.Count > 0)
                {
                    try
                    {
                        BarCode BaCo = new BarCode();
                        BaCo.IDProductTxtBox.Text = this.ProductGridView.CurrentRow.Cells[0].Value.ToString();
                        BaCo.StartPosition = FormStartPosition.CenterScreen;
                        BaCo.Show();
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.ToString());
                    }   
                }
                else
                {
                    MessageBox.Show("Please  select product first");
                }
            }
        }
    }
}
        

    
