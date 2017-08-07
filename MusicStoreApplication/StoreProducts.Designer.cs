namespace MusicStoreApplication
{
    partial class StoreProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreProducts));
            this.ProductsGrindView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProductBox = new System.Windows.Forms.TextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.ProductQuantityBox = new System.Windows.Forms.TextBox();
            this.ProductUPriceBox = new System.Windows.Forms.TextBox();
            this.LocalisationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeliveryDateBox = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrindView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGrindView
            // 
            this.ProductsGrindView.AllowUserToAddRows = false;
            this.ProductsGrindView.AllowUserToDeleteRows = false;
            this.ProductsGrindView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrindView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.ProductsGrindView.Location = new System.Drawing.Point(12, 333);
            this.ProductsGrindView.Name = "ProductsGrindView";
            this.ProductsGrindView.ReadOnly = true;
            this.ProductsGrindView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGrindView.Size = new System.Drawing.Size(832, 204);
            this.ProductsGrindView.TabIndex = 0;
            this.ProductsGrindView.DoubleClick += new System.EventHandler(this.ProductsGrindView_DoubleClick);
            this.ProductsGrindView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductsGrindView_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Product unit price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Localisation";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Delivery date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Image";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // IDProductBox
            // 
            this.IDProductBox.Location = new System.Drawing.Point(45, 25);
            this.IDProductBox.Name = "IDProductBox";
            this.IDProductBox.Size = new System.Drawing.Size(100, 20);
            this.IDProductBox.TabIndex = 1;
            this.IDProductBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDProductBox_KeyPress);
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(174, 25);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameBox.TabIndex = 2;
            // 
            // ProductQuantityBox
            // 
            this.ProductQuantityBox.Location = new System.Drawing.Point(309, 25);
            this.ProductQuantityBox.Name = "ProductQuantityBox";
            this.ProductQuantityBox.Size = new System.Drawing.Size(100, 20);
            this.ProductQuantityBox.TabIndex = 3;
            this.ProductQuantityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductQuantityBox_KeyPress);
            // 
            // ProductUPriceBox
            // 
            this.ProductUPriceBox.Location = new System.Drawing.Point(449, 25);
            this.ProductUPriceBox.Name = "ProductUPriceBox";
            this.ProductUPriceBox.Size = new System.Drawing.Size(100, 20);
            this.ProductUPriceBox.TabIndex = 4;
            this.ProductUPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductUPriceBox_KeyPress);
            // 
            // LocalisationBox
            // 
            this.LocalisationBox.Location = new System.Drawing.Point(582, 25);
            this.LocalisationBox.Name = "LocalisationBox";
            this.LocalisationBox.Size = new System.Drawing.Size(100, 20);
            this.LocalisationBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID_Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product unit price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Localistion";
            // 
            // DeliveryDateBox
            // 
            this.DeliveryDateBox.CustomFormat = "yyyy-MM-dd";
            this.DeliveryDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDateBox.Location = new System.Drawing.Point(714, 25);
            this.DeliveryDateBox.Name = "DeliveryDateBox";
            this.DeliveryDateBox.Size = new System.Drawing.Size(99, 20);
            this.DeliveryDateBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delivery date";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(258, 234);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(351, 20);
            this.PathBox.TabIndex = 19;
            // 
            // UploadButton
            // 
            this.UploadButton.Image = global::MusicStoreApplication.Properties.Resources.upload_icon;
            this.UploadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UploadButton.Location = new System.Drawing.Point(355, 260);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(153, 31);
            this.UploadButton.TabIndex = 17;
            this.UploadButton.Text = "  Upload product image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(309, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = global::MusicStoreApplication.Properties.Resources.Actions_edit_delete_icon;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(534, 297);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "   Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Image = global::MusicStoreApplication.Properties.Resources.edit_validated_icon;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(395, 297);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(81, 31);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "   Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Image = global::MusicStoreApplication.Properties.Resources.Button_Add_icon__1_;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(258, 297);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 31);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "  Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StoreProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 549);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeliveryDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LocalisationBox);
            this.Controls.Add(this.ProductUPriceBox);
            this.Controls.Add(this.ProductQuantityBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.IDProductBox);
            this.Controls.Add(this.ProductsGrindView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StoreProducts";
            this.Text = "StoreProducts";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrindView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGrindView;
        private System.Windows.Forms.TextBox IDProductBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.TextBox ProductQuantityBox;
        private System.Windows.Forms.TextBox ProductUPriceBox;
        private System.Windows.Forms.TextBox LocalisationBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DeliveryDateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}