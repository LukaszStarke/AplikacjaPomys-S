using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MusicStoreApplication
{
    public partial class StoreApp : Form
    {

        public StoreApp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open question window when we clicked on exit and we click ok it closed whole app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else if (result == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        /// <summary>
        /// Open new StoreProducts when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storeProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "StoreProducts")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {

                StoreProducts StPr = new StoreProducts();
                StPr.MdiParent = this;
                StPr.StartPosition = FormStartPosition.CenterScreen;
                StPr.Show();
            }
        }

        /// <summary>
        /// Open new StoreOrders when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storeOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "StoreOrders")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {

                StoreOrders StOr = new StoreOrders();
                StOr.MdiParent = this;
                StOr.StartPosition = FormStartPosition.CenterScreen;
                StOr.Show();
            }
        }

        /// <summary>
        /// Open new SearchProducts when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchInStoreProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "SearchProducts")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {

                SearchProducts SePr = new SearchProducts();
                SePr.MdiParent = this;
                SePr.StartPosition = FormStartPosition.CenterScreen;
                SePr.Show();
            }
        }

        /// <summary>
        /// Open new SearchOrders when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchInStoreOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "SearchOrders")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {

                SearchOrders SeOr = new SearchOrders();
                SeOr.MdiParent = this;
                SeOr.StartPosition = FormStartPosition.CenterScreen;
                SeOr.Show();

            }
        }

        /// <summary>
        ///  Open new DailySales when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           bool IsOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Daily sales")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }

                if (IsOpen == false)
                {

                    DailySales DaSe = new DailySales();
                    DaSe.MdiParent = this;
                    DaSe.StartPosition = FormStartPosition.CenterScreen;
                    DaSe.Show();
               }
                
             }
        /// <summary>
        /// Open new MonthlyIncome when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthlyIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "MonthlyIncome")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }

                if (IsOpen == false)
                {

                    MonthlyIncome MoIN = new MonthlyIncome();
                    MoIN.MdiParent = this;
                    MoIN.StartPosition = FormStartPosition.CenterScreen;
                    MoIN.Show();

                }
        }

        /// <summary>
        /// Open new SellProduct when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                bool IsOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Sell product")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    SellProduct SePr = new SellProduct();
                    SePr.MdiParent = this;
                    SePr.StartPosition = FormStartPosition.CenterScreen;
                    SePr.Show();
                }
        }

        /// <summary>
        /// Open new SellHistory when there are no open ones and set it to the center of a screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchInSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Search sold history")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                SellHistory SeHi = new SellHistory();
                SeHi.MdiParent = this;
                SeHi.StartPosition = FormStartPosition.CenterScreen;
                SeHi.Show();
            }
        }
    }

 }
