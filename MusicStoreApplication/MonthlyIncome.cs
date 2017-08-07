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
    public partial class MonthlyIncome : Form
    {
        public MonthlyIncome()
        {
            InitializeComponent();

        }
        DataTable dt;

        /// <summary>
        /// Method that load data to specific rows in IncomeGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowIncomeButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[MonthIncome] ", con);
            dt = new DataTable();
            sda.Fill(dt);
            IncomeGridView.DataSource = dt;
        }

        /// <summary>
        /// Method that filtr (substring search) (if there are rows in ProductGridView) for writted ID in IDProductsTxtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPhraseTxtBox_TextChanged_1(object sender, EventArgs e)
        {

            if (SearchCategoryComboBox.SelectedItem == null || IncomeGridView.Rows.Count == 0)
            {    
                MessageBox.Show("Please select a search category and load data to table");
            }
            else
            
            {   
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", SearchCategoryComboBox.Text.Trim(), SearchPhraseTxtBox.Text.Trim());
                IncomeGridView.DataSource = dv;
            }


        }

        
    }
}