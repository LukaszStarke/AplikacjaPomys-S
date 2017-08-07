namespace MusicStoreApplication
{
    partial class DailySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySales));
            this.IncomeGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchDateTxtBox = new System.Windows.Forms.TextBox();
            this.ShowIncomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeGridView
            // 
            this.IncomeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeGridView.Location = new System.Drawing.Point(12, 111);
            this.IncomeGridView.Name = "IncomeGridView";
            this.IncomeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IncomeGridView.Size = new System.Drawing.Size(238, 192);
            this.IncomeGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search date";
            // 
            // SearchDateTxtBox
            // 
            this.SearchDateTxtBox.Location = new System.Drawing.Point(32, 85);
            this.SearchDateTxtBox.Name = "SearchDateTxtBox";
            this.SearchDateTxtBox.Size = new System.Drawing.Size(199, 20);
            this.SearchDateTxtBox.TabIndex = 2;
            this.SearchDateTxtBox.TextChanged += new System.EventHandler(this.SearchDateTxtBox_TextChanged);
            // 
            // ShowIncomeButton
            // 
            this.ShowIncomeButton.Image = global::MusicStoreApplication.Properties.Resources.Programming_Show_Property_icon__1_;
            this.ShowIncomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowIncomeButton.Location = new System.Drawing.Point(52, 12);
            this.ShowIncomeButton.Name = "ShowIncomeButton";
            this.ShowIncomeButton.Size = new System.Drawing.Size(165, 28);
            this.ShowIncomeButton.TabIndex = 3;
            this.ShowIncomeButton.Text = "Show all daily incomes";
            this.ShowIncomeButton.UseVisualStyleBackColor = true;
            this.ShowIncomeButton.Click += new System.EventHandler(this.ShowIncomeButton_Click);
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 315);
            this.Controls.Add(this.ShowIncomeButton);
            this.Controls.Add(this.SearchDateTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncomeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DailySales";
            this.Text = "Daily sales";
            ((System.ComponentModel.ISupportInitialize)(this.IncomeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IncomeGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchDateTxtBox;
        private System.Windows.Forms.Button ShowIncomeButton;
    }
}