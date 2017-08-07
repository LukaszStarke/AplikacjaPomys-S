namespace MusicStoreApplication
{
    partial class SearchOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrders));
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchPhraseTxtBox = new System.Windows.Forms.TextBox();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.ShowOrdersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AllowUserToDeleteRows = false;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(12, 107);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGridView.Size = new System.Drawing.Size(715, 218);
            this.OrdersGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Searching phrase";
            // 
            // SearchPhraseTxtBox
            // 
            this.SearchPhraseTxtBox.Location = new System.Drawing.Point(462, 67);
            this.SearchPhraseTxtBox.Name = "SearchPhraseTxtBox";
            this.SearchPhraseTxtBox.Size = new System.Drawing.Size(182, 20);
            this.SearchPhraseTxtBox.TabIndex = 3;
            this.SearchPhraseTxtBox.TextChanged += new System.EventHandler(this.SearchPhraseTxtBox_TextChanged);
            // 
            // comboSearch
            // 
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "ID_Order",
            "OrderName",
            "OrderStatus",
            "OrderQuantity",
            "OrderPrice",
            "Adres",
            "DateOfOrder"});
            this.comboSearch.Location = new System.Drawing.Point(74, 66);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(182, 21);
            this.comboSearch.TabIndex = 4;
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.Image = global::MusicStoreApplication.Properties.Resources.Programming_Show_Property_icon__1_;
            this.ShowOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowOrdersButton.Location = new System.Drawing.Point(272, 12);
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.Size = new System.Drawing.Size(182, 28);
            this.ShowOrdersButton.TabIndex = 5;
            this.ShowOrdersButton.Text = "  Show all store orders";
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // SearchOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 337);
            this.Controls.Add(this.ShowOrdersButton);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.SearchPhraseTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchOrders";
            this.Text = "SearchOrders";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchPhraseTxtBox;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Button ShowOrdersButton;
    }
}