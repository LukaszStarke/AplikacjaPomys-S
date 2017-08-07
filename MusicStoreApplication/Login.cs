using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MusicStoreApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();    
        }

        /// <summary>
        /// This method clear all text in texboxes and focus on UserTexBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserTextBox.Text = "";
            PasswordTextBox.Clear();
            UserTextBox.Focus();

        }

        /// <summary>
        /// Method create and open connection to SQL database, select row which is the same as the textboxes with query in SqlAdapter
        /// and fill it into DataTable.
        /// If it counted one row it's hide this window and open StoreApp if password is incorect it give's us error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\ADONISCE30;Initial Catalog=SklepMuzyczny;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [SklepMuzyczny].[dbo].[Logins] where Username ='" + UserTextBox.Text + "' and Password ='" + PasswordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StoreApp main = new StoreApp();
                main.Show();
            }

            else
            {
                MessageBox.Show("UserName or Password is not correct", "ERROR!",MessageBoxButtons.OK ,MessageBoxIcon.Error);              
            }

        }

        /// <summary>
        /// When checkBox is checked we can see password otherwise we can't
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowHide.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false; 
            }
        }

        /// <summary>
        /// This method makes our password hidden when loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        public void Login_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
