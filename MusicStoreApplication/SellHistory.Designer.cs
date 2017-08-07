namespace MusicStoreApplication
{
    partial class SellHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPhraseTxtBox = new System.Windows.Forms.TextBox();
            this.SellHistoryGridView = new System.Windows.Forms.DataGridView();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowSellHistoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Searching phrase";
            // 
            // SearchPhraseTxtBox
            // 
            this.SearchPhraseTxtBox.Location = new System.Drawing.Point(435, 84);
            this.SearchPhraseTxtBox.Name = "SearchPhraseTxtBox";
            this.SearchPhraseTxtBox.Size = new System.Drawing.Size(155, 20);
            this.SearchPhraseTxtBox.TabIndex = 1;
            this.SearchPhraseTxtBox.TextChanged += new System.EventHandler(this.SearchPhraseTxtBox_TextChanged);
            // 
            // SellHistoryGridView
            // 
            this.SellHistoryGridView.AllowUserToDeleteRows = false;
            this.SellHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellHistoryGridView.Location = new System.Drawing.Point(12, 125);
            this.SellHistoryGridView.Name = "SellHistoryGridView";
            this.SellHistoryGridView.ReadOnly = true;
            this.SellHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellHistoryGridView.Size = new System.Drawing.Size(662, 270);
            this.SellHistoryGridView.TabIndex = 2;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "ID_Sell",
            "ID_Product",
            "ProductName",
            "ProductQuantity",
            "ProductUnitPrice",
            "TotalPrice",
            "Time",
            "WayOfPayment",
            "DateOfBought"});
            this.CategoryComboBox.Location = new System.Drawing.Point(83, 84);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(155, 21);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Searching category";
            // 
            // ShowSellHistoryButton
            // 
            this.ShowSellHistoryButton.Image = global::MusicStoreApplication.Properties.Resources.Programming_Show_Property_icon__1_;
            this.ShowSellHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowSellHistoryButton.Location = new System.Drawing.Point(267, 27);
            this.ShowSellHistoryButton.Name = "ShowSellHistoryButton";
            this.ShowSellHistoryButton.Size = new System.Drawing.Size(155, 29);
            this.ShowSellHistoryButton.TabIndex = 5;
            this.ShowSellHistoryButton.Text = "   Show all sold history";
            this.ShowSellHistoryButton.UseVisualStyleBackColor = true;
            this.ShowSellHistoryButton.Click += new System.EventHandler(this.ShowSellHistoryButton_Click);
            // 
            // SellHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 407);
            this.Controls.Add(this.ShowSellHistoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.SellHistoryGridView);
            this.Controls.Add(this.SearchPhraseTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellHistory";
            this.Text = "Search sold history";
            ((System.ComponentModel.ISupportInitialize)(this.SellHistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchPhraseTxtBox;
        private System.Windows.Forms.DataGridView SellHistoryGridView;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowSellHistoryButton;
    }
}