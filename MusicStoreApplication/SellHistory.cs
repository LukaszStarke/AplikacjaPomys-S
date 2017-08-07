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
    public partial class SellHistory : Form
    {
        public SellHistory()
        {
            InitializeComponent();
        }
        DataTable dt;

        /// <summary>
        /// Method that load data to SellHistoryGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSellHistoryButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[SoldHistory] ", con);
            dt = new DataTable();
            sda.Fill(dt);
            SellHistoryGridView.DataSource = dt;
        }
        
        /// <summary>
        /// Method that filter (substring search) (if there are rows in SellHistoryGridView) for selected parametr in comboSearch and searching
        /// phrase in SearchPhraseTxtBox, if value of comboSearch isn't null and there are more than 0 rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPhraseTxtBox_TextChanged(object sender, EventArgs e)
        {

            if (CategoryComboBox.SelectedItem == null || SellHistoryGridView.Rows.Count == 0)
            {          
                MessageBox.Show("Please select a search category or load data");
            }
            else
            {               
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", CategoryComboBox.Text.Trim(), SearchPhraseTxtBox.Text.Trim());
                SellHistoryGridView.DataSource = dv;
            }
        }
    }
}