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
    public partial class SearchOrders : Form
    {
        public SearchOrders()
        {
            InitializeComponent();

        }
        DataTable dt;

        /// <summary>
        /// Method that load data to OrdersGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[Orders] ", con);
            dt = new DataTable();
            sda.Fill(dt);
            OrdersGridView.DataSource = dt;
        }

        /// <summary>
        /// Method that filter (substring search) (if there are rows in OrdersGridView and value in comboBox)
        /// for selected parametr in comboSearch and searching phrase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPhraseTxtBox_TextChanged(object sender, EventArgs e)
        {

            if (comboSearch.SelectedItem == null || OrdersGridView.Rows.Count == 0)
            { 
                MessageBox.Show("Please select a search category or load data");
            }
            else
            {    
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", comboSearch.Text.Trim(), SearchPhraseTxtBox.Text.Trim());
                OrdersGridView.DataSource = dv;
            }
        }
      }
    }
