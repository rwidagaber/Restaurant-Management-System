namespace Resturant_Mangement_System.View
{
    partial class frmCategoryView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryView));
            this.categoryView = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet1 = new Resturant_Mangement_System.RestaurantDataSet1();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new Resturant_Mangement_System.RestaurantDataSet();
            this.categoryTableAdapter = new Resturant_Mangement_System.RestaurantDataSetTableAdapters.categoryTableAdapter();
            this.categoryTableAdapter1 = new Resturant_Mangement_System.RestaurantDataSet1TableAdapters.categoryTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 28);
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.Text = "Category List";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Location = new System.Drawing.Point(12, 103);
            this.btnAdd.Size = new System.Drawing.Size(46, 42);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(521, 109);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(517, 86);
            // 
            // categoryView
            // 
            this.categoryView.AllowUserToAddRows = false;
            this.categoryView.AllowUserToDeleteRows = false;
            this.categoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryView.BackgroundColor = System.Drawing.Color.White;
            this.categoryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryView.ColumnHeadersHeight = 50;
            this.categoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvedit,
            this.dgvdel});
            this.categoryView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.categoryView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryView.Location = new System.Drawing.Point(12, 184);
            this.categoryView.Name = "categoryView";
            this.categoryView.ReadOnly = true;
            this.categoryView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoryView.RowHeadersVisible = false;
            this.categoryView.RowHeadersWidth = 10;
            this.categoryView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.categoryView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryView.RowTemplate.Height = 24;
            this.categoryView.Size = new System.Drawing.Size(776, 243);
            this.categoryView.StandardTab = true;
            this.categoryView.TabIndex = 1;
            this.categoryView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryView_CellClick);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = ((System.Drawing.Image)(resources.GetObject("dgvedit.Image")));
            this.dgvedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvedit.MinimumWidth = 6;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Width = 50;
            // 
            // dgvdel
            // 
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.FillWeight = 50F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = ((System.Drawing.Image)(resources.GetObject("dgvdel.Image")));
            this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvdel.MinimumWidth = 50;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.Width = 50;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            this.categoryBindingSource1.DataSource = this.restaurantDataSet1;
            // 
            // restaurantDataSet1
            // 
            this.restaurantDataSet1.DataSetName = "RestaurantDataSet1";
            this.restaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // frmCategoryView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.categoryView);
            this.Name = "frmCategoryView";
            this.Text = "frmCategoryView";
            this.Load += new System.EventHandler(this.frmCategoryView_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.categoryView, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.categoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryView;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private RestaurantDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private RestaurantDataSet1 restaurantDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private RestaurantDataSet1TableAdapters.categoryTableAdapter categoryTableAdapter1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}