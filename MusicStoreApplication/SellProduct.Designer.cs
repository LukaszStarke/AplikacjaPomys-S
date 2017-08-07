namespace MusicStoreApplication
{
    partial class SellProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellProduct));
            this.ProductQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.IDProductSearchTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.IDSellTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductNameSearchTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SellHistoryGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProductTxtBox = new System.Windows.Forms.TextBox();
            this.ProductNameTxtBox = new System.Windows.Forms.TextBox();
            this.ProductUnitPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WayOfPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GenerateBillButton = new System.Windows.Forms.Button();
            this.PrepareButton = new System.Windows.Forms.Button();
            this.LoadProducts = new System.Windows.Forms.Button();
            this.SellProductButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellHistoryGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductQuantityTxtBox
            // 
            this.ProductQuantityTxtBox.Location = new System.Drawing.Point(196, 45);
            this.ProductQuantityTxtBox.Name = "ProductQuantityTxtBox";
            this.ProductQuantityTxtBox.Size = new System.Drawing.Size(115, 20);
            this.ProductQuantityTxtBox.TabIndex = 0;
            this.ProductQuantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductQuantityTxtBox_KeyPress);
            // 
            // IDProductSearchTxtBox
            // 
            this.IDProductSearchTxtBox.Location = new System.Drawing.Point(18, 41);
            this.IDProductSearchTxtBox.Name = "IDProductSearchTxtBox";
            this.IDProductSearchTxtBox.Size = new System.Drawing.Size(116, 20);
            this.IDProductSearchTxtBox.TabIndex = 1;
            this.IDProductSearchTxtBox.TextChanged += new System.EventHandler(this.IDProductsTxtBox_TextChanged);
            this.IDProductSearchTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDProductsTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Quantity";
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(72, 115);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(772, 140);
            this.ProductGridView.TabIndex = 4;
            this.ProductGridView.DoubleClick += new System.EventHandler(this.ProductGridView_DoubleClick);
            // 
            // IDSellTxtBox
            // 
            this.IDSellTxtBox.Location = new System.Drawing.Point(47, 45);
            this.IDSellTxtBox.Name = "IDSellTxtBox";
            this.IDSellTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IDSellTxtBox.TabIndex = 5;
            this.IDSellTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDSellTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Sell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // ProductNameSearchTxtBox
            // 
            this.ProductNameSearchTxtBox.Location = new System.Drawing.Point(330, 41);
            this.ProductNameSearchTxtBox.Name = "ProductNameSearchTxtBox";
            this.ProductNameSearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameSearchTxtBox.TabIndex = 15;
            this.ProductNameSearchTxtBox.TextChanged += new System.EventHandler(this.ProductNameTxtBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Product name";
            // 
            // SellHistoryGridView
            // 
            this.SellHistoryGridView.AllowUserToAddRows = false;
            this.SellHistoryGridView.AllowUserToDeleteRows = false;
            this.SellHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.SellHistoryGridView.Location = new System.Drawing.Point(12, 453);
            this.SellHistoryGridView.Name = "SellHistoryGridView";
            this.SellHistoryGridView.ReadOnly = true;
            this.SellHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellHistoryGridView.Size = new System.Drawing.Size(897, 168);
            this.SellHistoryGridView.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Sell";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Product quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product unit price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Time";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Way of payment";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date of bought";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // IDProductTxtBox
            // 
            this.IDProductTxtBox.Location = new System.Drawing.Point(153, 321);
            this.IDProductTxtBox.Name = "IDProductTxtBox";
            this.IDProductTxtBox.Size = new System.Drawing.Size(165, 20);
            this.IDProductTxtBox.TabIndex = 21;
            this.IDProductTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDProductTxtBox_KeyPress);
            // 
            // ProductNameTxtBox
            // 
            this.ProductNameTxtBox.Location = new System.Drawing.Point(358, 321);
            this.ProductNameTxtBox.Name = "ProductNameTxtBox";
            this.ProductNameTxtBox.Size = new System.Drawing.Size(165, 20);
            this.ProductNameTxtBox.TabIndex = 22;
            // 
            // ProductUnitPriceTxtBox
            // 
            this.ProductUnitPriceTxtBox.Location = new System.Drawing.Point(560, 321);
            this.ProductUnitPriceTxtBox.Name = "ProductUnitPriceTxtBox";
            this.ProductUnitPriceTxtBox.Size = new System.Drawing.Size(165, 20);
            this.ProductUnitPriceTxtBox.TabIndex = 25;
            this.ProductUnitPriceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductUnitPriceTxtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Way of payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Product name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Product unit price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "ID Product";
            // 
            // WayOfPaymentComboBox
            // 
            this.WayOfPaymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WayOfPaymentComboBox.FormattingEnabled = true;
            this.WayOfPaymentComboBox.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.WayOfPaymentComboBox.Location = new System.Drawing.Point(353, 44);
            this.WayOfPaymentComboBox.Name = "WayOfPaymentComboBox";
            this.WayOfPaymentComboBox.Size = new System.Drawing.Size(121, 21);
            this.WayOfPaymentComboBox.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Search product by ID or Name";
            // 
            // TotalPriceTxtBox
            // 
            this.TotalPriceTxtBox.Location = new System.Drawing.Point(505, 44);
            this.TotalPriceTxtBox.Name = "TotalPriceTxtBox";
            this.TotalPriceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPriceTxtBox.TabIndex = 35;
            this.TotalPriceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalPriceTxtBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Total Price";
            // 
            // GenerateBillButton
            // 
            this.GenerateBillButton.Image = global::MusicStoreApplication.Properties.Resources.Finance_Bill_icon;
            this.GenerateBillButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateBillButton.Location = new System.Drawing.Point(388, 631);
            this.GenerateBillButton.Name = "GenerateBillButton";
            this.GenerateBillButton.Size = new System.Drawing.Size(135, 26);
            this.GenerateBillButton.TabIndex = 37;
            this.GenerateBillButton.Text = "  Generate bill";
            this.GenerateBillButton.UseVisualStyleBackColor = true;
            this.GenerateBillButton.Click += new System.EventHandler(this.GenerateBillButton_Click);
            // 
            // PrepareButton
            // 
            this.PrepareButton.Image = global::MusicStoreApplication.Properties.Resources.document_prepare_icon;
            this.PrepareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrepareButton.Location = new System.Drawing.Point(358, 268);
            this.PrepareButton.Name = "PrepareButton";
            this.PrepareButton.Size = new System.Drawing.Size(183, 28);
            this.PrepareButton.TabIndex = 26;
            this.PrepareButton.Text = "  Prepare product to sell";
            this.PrepareButton.UseVisualStyleBackColor = true;
            this.PrepareButton.Click += new System.EventHandler(this.PrepareButton_Click);
            // 
            // LoadProducts
            // 
            this.LoadProducts.Image = global::MusicStoreApplication.Properties.Resources.Programming_Show_Property_icon__1_;
            this.LoadProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadProducts.Location = new System.Drawing.Point(358, 12);
            this.LoadProducts.Name = "LoadProducts";
            this.LoadProducts.Size = new System.Drawing.Size(183, 28);
            this.LoadProducts.TabIndex = 20;
            this.LoadProducts.Text = "  Load all products in store";
            this.LoadProducts.UseVisualStyleBackColor = true;
            this.LoadProducts.Click += new System.EventHandler(this.LoadProducts_Click);
            // 
            // SellProductButton
            // 
            this.SellProductButton.Image = global::MusicStoreApplication.Properties.Resources._192_credit_card_icon;
            this.SellProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellProductButton.Location = new System.Drawing.Point(267, 72);
            this.SellProductButton.Name = "SellProductButton";
            this.SellProductButton.Size = new System.Drawing.Size(135, 23);
            this.SellProductButton.TabIndex = 19;
            this.SellProductButton.Text = " Sell product";
            this.SellProductButton.UseVisualStyleBackColor = true;
            this.SellProductButton.Click += new System.EventHandler(this.SellProductButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Please fill the text boxes bellow";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductQuantityTxtBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.IDSellTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.SellProductButton);
            this.groupBox1.Controls.Add(this.TotalPriceTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.WayOfPaymentComboBox);
            this.groupBox1.Location = new System.Drawing.Point(120, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 95);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.IDProductSearchTxtBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ProductNameSearchTxtBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(217, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 69);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GenerateBillButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrepareButton);
            this.Controls.Add(this.ProductUnitPriceTxtBox);
            this.Controls.Add(this.ProductNameTxtBox);
            this.Controls.Add(this.IDProductTxtBox);
            this.Controls.Add(this.LoadProducts);
            this.Controls.Add(this.SellHistoryGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellProduct";
            this.Text = "Sell product";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellHistoryGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductQuantityTxtBox;
        private System.Windows.Forms.TextBox IDProductSearchTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.TextBox IDSellTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductNameSearchTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SellProductButton;
        private System.Windows.Forms.Button LoadProducts;
        private System.Windows.Forms.TextBox IDProductTxtBox;
        private System.Windows.Forms.TextBox ProductNameTxtBox;
        private System.Windows.Forms.TextBox ProductUnitPriceTxtBox;
        private System.Windows.Forms.Button PrepareButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox WayOfPaymentComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox TotalPriceTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button GenerateBillButton;
        public System.Windows.Forms.DataGridView SellHistoryGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}