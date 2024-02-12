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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtsproductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMDatabaseDataSet = new Resturant_Mangement_System.RMDatabaseDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Resturant_Mangement_System.RMDatabaseDataSetTableAdapters.categoryTableAdapter();
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(681, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Size = new System.Drawing.Size(681, 100);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.Text = "Product Details";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(31, 257);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(240, 30);
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
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // cbcat
            // 
            this.cbcat.DataSource = this.categoryBindingSource;
            this.cbcat.DisplayMember = "catName";
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(31, 370);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(240, 24);
            this.cbcat.TabIndex = 8;
            this.cbcat.ValueMember = "catID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.rMDatabaseDataSet;
            // 
            // rMDatabaseDataSet
            // 
            this.rMDatabaseDataSet.DataSetName = "RMDatabaseDataSet";
            this.rMDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(390, 142);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(156, 145);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 9;
            this.txtImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(405, 316);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(130, 42);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 534);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtsproductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
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
        private RMDatabaseDataSet rMDatabaseDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private RMDatabaseDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.PictureBox txtImage;
    }
}