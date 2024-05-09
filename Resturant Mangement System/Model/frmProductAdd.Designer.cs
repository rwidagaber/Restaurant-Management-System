namespace Resturant_Mangement_System.View
{
    partial class frmProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductAdd));
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtsproductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantCategoryDataSet = new Resturant_Mangement_System.RestaurantCategoryDataSet();
            this.categoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Resturant_Mangement_System.RestaurantCategoryDataSetTableAdapters.categoryTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCategoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(634, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Size = new System.Drawing.Size(634, 100);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.Text = "Product Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(316, 26);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(177, 26);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(341, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 30);
            this.txtPrice.TabIndex = 7;
            // 
            // txtsproductName
            // 
            this.txtsproductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsproductName.Location = new System.Drawing.Point(31, 163);
            this.txtsproductName.Name = "txtsproductName";
            this.txtsproductName.Size = new System.Drawing.Size(240, 30);
            this.txtsproductName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(337, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // cbcat
            // 
            this.cbcat.DataSource = this.categoryBindingSource4;
            this.cbcat.DisplayMember = "catName";
            this.cbcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(171, 297);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(240, 33);
            this.cbcat.TabIndex = 8;
            this.cbcat.ValueMember = "catID";
            // 
            // categoryBindingSource4
            // 
            this.categoryBindingSource4.DataMember = "category";
            this.categoryBindingSource4.DataSource = this.restaurantCategoryDataSet;
            // 
            // restaurantCategoryDataSet
            // 
            this.restaurantCategoryDataSet.DataSetName = "RestaurantCategoryDataSet";
            this.restaurantCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource3
            // 
            this.categoryBindingSource3.DataMember = "category";
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataMember = "category";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(167, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 534);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtsproductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtsproductName, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbcat, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCategoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtsproductName;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private System.Windows.Forms.BindingSource categoryBindingSource3;
        private RestaurantCategoryDataSet restaurantCategoryDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource4;
        private RestaurantCategoryDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
    }
}