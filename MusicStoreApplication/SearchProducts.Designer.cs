namespace MusicStoreApplication
{
    partial class SearchProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProducts));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPhraseTxtBox = new System.Windows.Forms.TextBox();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BarCodeButton = new System.Windows.Forms.Button();
            this.ShowAllProductsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Searching phrase";
            // 
            // SearchPhraseTxtBox
            // 
            this.SearchPhraseTxtBox.Location = new System.Drawing.Point(482, 61);
            this.SearchPhraseTxtBox.Name = "SearchPhraseTxtBox";
            this.SearchPhraseTxtBox.Size = new System.Drawing.Size(218, 20);
            this.SearchPhraseTxtBox.TabIndex = 1;
            this.SearchPhraseTxtBox.TextChanged += new System.EventHandler(this.SearchPhraseTxtBox_TextChanged);
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(12, 138);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(739, 338);
            this.ProductGridView.TabIndex = 2;
            this.ProductGridView.DoubleClick += new System.EventHandler(this.ProductGridView_DoubleClick);
            // 
            // comboSearch
            // 
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "ID_Product",
            "ProductName",
            "ProductQuantity",
            "ProductUnitPrice",
            "Localisation",
            "DateOfOrder"});
            this.comboSearch.Location = new System.Drawing.Point(48, 61);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(218, 21);
            this.comboSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Searching category";
            // 
            // BarCodeButton
            // 
            this.BarCodeButton.Image = global::MusicStoreApplication.Properties.Resources.Bar_Code_icon;
            this.BarCodeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BarCodeButton.Location = new System.Drawing.Point(265, 482);
            this.BarCodeButton.Name = "BarCodeButton";
            this.BarCodeButton.Size = new System.Drawing.Size(226, 23);
            this.BarCodeButton.TabIndex = 6;
            this.BarCodeButton.Text = "  Generate bar code for this product";
            this.BarCodeButton.UseVisualStyleBackColor = true;
            this.BarCodeButton.Click += new System.EventHandler(this.BarCodeButton_Click);
            // 
            // ShowAllProductsButton
            // 
            this.ShowAllProductsButton.Image = global::MusicStoreApplication.Properties.Resources.Programming_Show_Property_icon__1_;
            this.ShowAllProductsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowAllProductsButton.Location = new System.Drawing.Point(286, 12);
            this.ShowAllProductsButton.Name = "ShowAllProductsButton";
            this.ShowAllProductsButton.Size = new System.Drawing.Size(183, 26);
            this.ShowAllProductsButton.TabIndex = 3;
            this.ShowAllProductsButton.Text = "  Show all products in store";
            this.ShowAllProductsButton.UseVisualStyleBackColor = true;
            this.ShowAllProductsButton.Click += new System.EventHandler(this.ShowAllProductsButton_Click);
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 515);
            this.Controls.Add(this.BarCodeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.ShowAllProductsButton);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.SearchPhraseTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchProducts";
            this.Text = "SearchProducts";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchPhraseTxtBox;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Button ShowAllProductsButton;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BarCodeButton;
    }
}