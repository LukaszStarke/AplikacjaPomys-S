namespace MusicStoreApplication
{
    partial class StoreApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreApp));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.storeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchInStoreProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchInStoreOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchInSoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeProductsToolStripMenuItem,
            this.storeOrdersToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.searchInStoreProductsToolStripMenuItem,
            this.searchInStoreOrdersToolStripMenuItem,
            this.toolStripMenuItem1,
            this.searchInSoldToolStripMenuItem,
            this.dailyIncomeToolStripMenuItem,
            this.monthlyIncomeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // storeProductsToolStripMenuItem
            // 
            this.storeProductsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.storeProductsToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.guitar_icon;
            this.storeProductsToolStripMenuItem.Name = "storeProductsToolStripMenuItem";
            this.storeProductsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.storeProductsToolStripMenuItem.Text = "Store products";
            this.storeProductsToolStripMenuItem.Click += new System.EventHandler(this.storeProductsToolStripMenuItem_Click);
            // 
            // storeOrdersToolStripMenuItem
            // 
            this.storeOrdersToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.Status_mail_task_icon;
            this.storeOrdersToolStripMenuItem.Name = "storeOrdersToolStripMenuItem";
            this.storeOrdersToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.storeOrdersToolStripMenuItem.Text = "Store orders";
            this.storeOrdersToolStripMenuItem.Click += new System.EventHandler(this.storeOrdersToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.payment_icon;
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.sellToolStripMenuItem.Text = "Sell product";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // searchInStoreProductsToolStripMenuItem
            // 
            this.searchInStoreProductsToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.search_icon;
            this.searchInStoreProductsToolStripMenuItem.Name = "searchInStoreProductsToolStripMenuItem";
            this.searchInStoreProductsToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.searchInStoreProductsToolStripMenuItem.Text = "Search in store products";
            this.searchInStoreProductsToolStripMenuItem.Click += new System.EventHandler(this.searchInStoreProductsToolStripMenuItem_Click);
            // 
            // searchInStoreOrdersToolStripMenuItem
            // 
            this.searchInStoreOrdersToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.search_icon;
            this.searchInStoreOrdersToolStripMenuItem.Name = "searchInStoreOrdersToolStripMenuItem";
            this.searchInStoreOrdersToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.searchInStoreOrdersToolStripMenuItem.Text = "Search in store orders";
            this.searchInStoreOrdersToolStripMenuItem.Click += new System.EventHandler(this.searchInStoreOrdersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // searchInSoldToolStripMenuItem
            // 
            this.searchInSoldToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.search_icon;
            this.searchInSoldToolStripMenuItem.Name = "searchInSoldToolStripMenuItem";
            this.searchInSoldToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.searchInSoldToolStripMenuItem.Text = "Search in sold history";
            this.searchInSoldToolStripMenuItem.Click += new System.EventHandler(this.searchInSoldToolStripMenuItem_Click);
            // 
            // dailyIncomeToolStripMenuItem
            // 
            this.dailyIncomeToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.Income_icon;
            this.dailyIncomeToolStripMenuItem.Name = "dailyIncomeToolStripMenuItem";
            this.dailyIncomeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.dailyIncomeToolStripMenuItem.Text = "Daily sales";
            this.dailyIncomeToolStripMenuItem.Click += new System.EventHandler(this.DailySalesToolStripMenuItem_Click);
            // 
            // monthlyIncomeToolStripMenuItem
            // 
            this.monthlyIncomeToolStripMenuItem.Image = global::MusicStoreApplication.Properties.Resources.Income_icon;
            this.monthlyIncomeToolStripMenuItem.Name = "monthlyIncomeToolStripMenuItem";
            this.monthlyIncomeToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.monthlyIncomeToolStripMenuItem.Text = "Monthly income";
            this.monthlyIncomeToolStripMenuItem.Click += new System.EventHandler(this.monthlyIncomeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // StoreApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "StoreApp";
            this.Text = "Store App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreApp_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem storeProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchInStoreProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchInStoreOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchInSoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyIncomeToolStripMenuItem;
    }
}



