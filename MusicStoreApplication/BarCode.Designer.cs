namespace MusicStoreApplication
{
    partial class BarCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCode));
            this.IDProductTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.BarCodePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IDProductTxtBox
            // 
            this.IDProductTxtBox.Location = new System.Drawing.Point(79, 267);
            this.IDProductTxtBox.Name = "IDProductTxtBox";
            this.IDProductTxtBox.Size = new System.Drawing.Size(256, 20);
            this.IDProductTxtBox.TabIndex = 1;
            this.IDProductTxtBox.TextChanged += new System.EventHandler(this.IDProductTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID";
            // 
            // PrintButton
            // 
            this.PrintButton.Image = global::MusicStoreApplication.Properties.Resources.print_icon;
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.Location = new System.Drawing.Point(142, 12);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(128, 23);
            this.PrintButton.TabIndex = 4;
            this.PrintButton.Text = "  Print barcode";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BarCodePictureBox
            // 
            this.BarCodePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.BarCodePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BarCodePictureBox.Location = new System.Drawing.Point(28, 41);
            this.BarCodePictureBox.Name = "BarCodePictureBox";
            this.BarCodePictureBox.Size = new System.Drawing.Size(353, 188);
            this.BarCodePictureBox.TabIndex = 3;
            this.BarCodePictureBox.TabStop = false;
            this.BarCodePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.BarCodePictureBox_Paint);
            // 
            // BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(417, 316);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.BarCodePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDProductTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BarCode";
            this.Text = "Bar code generator";
            ((System.ComponentModel.ISupportInitialize)(this.BarCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox IDProductTxtBox;
        private System.Windows.Forms.PictureBox BarCodePictureBox;
        private System.Windows.Forms.Button PrintButton;
    }
}