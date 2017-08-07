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

namespace MusicStoreApplication
{
    public partial class DailySales : Form
    {
        public DailySales()
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
            SqlDataAdapter sda = new SqlDataAdapter("Select* from [SklepMuzyczny].[dbo].[DailyIncome1] ", con);
            dt = new DataTable();
            sda.Fill(dt);
            IncomeGridView.DataSource = dt;
        }

        /// <summary>
        /// Method that filter (substring search) (if there are rows in IncomeGridView) for writted phrase in SearchDateTxtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchDateTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (IncomeGridView.Rows.Count == 0)
            {

                MessageBox.Show("Please select a search category or load data");
                
            }
            else
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("convert(DateIncome, 'System.String') Like '%{0}%' ", SearchDateTxtBox.Text);
                IncomeGridView.DataSource = dv;
            }
        }     
    }
}
