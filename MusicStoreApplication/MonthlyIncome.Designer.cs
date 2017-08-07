namespace MusicStoreApplication
{
    partial class MonthlyIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyIncome));
            this.IncomeGridView = new System.Windows.Forms.DataGridView();
            this.ShowIncomeButton = new System.Windows.Forms.Button();
            this.SearchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPhraseTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeGridView
            // 
            this.IncomeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeGridView.Location = new System.Drawing.Point(12, 128);
            this.IncomeGridView.Name = "IncomeGridView";
            this.IncomeGridView.Size = new System.Drawing.Size(468, 180);
            this.IncomeGridView.TabIndex = 0;
            // 
            // ShowIncomeButton
            // 
            this.ShowIncomeButton.Image = global::MusicStoreApplication.Properties.Resources.Programming_Show_Property_icon__1_;
            this.ShowIncomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowIncomeButton.Location = new System.Drawing.Point(156, 24);
            this.ShowIncomeButton.Name = "ShowIncomeButton";
            this.ShowIncomeButton.Size = new System.Drawing.Size(182, 30);
            this.ShowIncomeButton.TabIndex = 1;
            this.ShowIncomeButton.Text = "  Show all monthly income";
            this.ShowIncomeButton.UseVisualStyleBackColor = true;
            this.ShowIncomeButton.Click += new System.EventHandler(this.ShowIncomeButton_Click);
            // 
            // SearchCategoryComboBox
            // 
            this.SearchCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCategoryComboBox.FormattingEnabled = true;
            this.SearchCategoryComboBox.Items.AddRange(new object[] {
            "Months",
            "Years"});
            this.SearchCategoryComboBox.Location = new System.Drawing.Point(90, 98);
            this.SearchCategoryComboBox.Name = "SearchCategoryComboBox";
            this.SearchCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchCategoryComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Searching category";
            // 
            // SearchPhraseTxtBox
            // 
            this.SearchPhraseTxtBox.Location = new System.Drawing.Point(281, 98);
            this.SearchPhraseTxtBox.Name = "SearchPhraseTxtBox";
            this.SearchPhraseTxtBox.Size = new System.Drawing.Size(121, 20);
            this.SearchPhraseTxtBox.TabIndex = 4;
            this.SearchPhraseTxtBox.TextChanged += new System.EventHandler(this.SearchPhraseTxtBox_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Searching phrase";
            // 
            // MonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchPhraseTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchCategoryComboBox);
            this.Controls.Add(this.ShowIncomeButton);
            this.Controls.Add(this.IncomeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MonthlyIncome";
            this.Text = "MonthlyIncome";
            ((System.ComponentModel.ISupportInitialize)(this.IncomeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IncomeGridView;
        private System.Windows.Forms.Button ShowIncomeButton;
        private System.Windows.Forms.ComboBox SearchCategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchPhraseTxtBox;
        private System.Windows.Forms.Label label2;
    }
}