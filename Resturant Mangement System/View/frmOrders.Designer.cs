namespace Resturant_Mangement_System
{
    partial class frmOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantCategory = new Resturant_Mangement_System.RestaurantCategory();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.chkSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbltotPrice = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Resturant_Mangement_System.RestaurantCategoryTableAdapters.categoryTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecevied = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.dgvAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.DataSource = this.categoryBindingSource2;
            this.cbCategory.DisplayMember = "catName";
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(133, 100);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(236, 28);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.ValueMember = "catID";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataMember = "category";
            this.categoryBindingSource2.DataSource = this.restaurantCategory;
            // 
            // restaurantCategory
            // 
            this.restaurantCategory.DataSetName = "RestaurantCategory";
            this.restaurantCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Order";
            // 
            // dgvCheck
            // 
            this.dgvCheck.AllowUserToAddRows = false;
            this.dgvCheck.AllowUserToDeleteRows = false;
            this.dgvCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheck.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCheck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheck.ColumnHeadersHeight = 50;
            this.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSno,
            this.chkId,
            this.chkName,
            this.chkQty,
            this.chkPrice,
            this.chkAmount,
            this.chkDel});
            this.dgvCheck.Location = new System.Drawing.Point(438, 168);
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.ReadOnly = true;
            this.dgvCheck.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCheck.RowHeadersVisible = false;
            this.dgvCheck.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCheck.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheck.RowTemplate.Height = 24;
            this.dgvCheck.Size = new System.Drawing.Size(350, 224);
            this.dgvCheck.TabIndex = 6;
            this.dgvCheck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheck_CellContentClick);
            this.dgvCheck.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCheck_CellFormatting);
            // 
            // chkSno
            // 
            this.chkSno.FillWeight = 66.36678F;
            this.chkSno.HeaderText = "Sr#";
            this.chkSno.MinimumWidth = 6;
            this.chkSno.Name = "chkSno";
            this.chkSno.ReadOnly = true;
            // 
            // chkId
            // 
            this.chkId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chkId.HeaderText = "ID";
            this.chkId.MinimumWidth = 6;
            this.chkId.Name = "chkId";
            this.chkId.ReadOnly = true;
            this.chkId.Visible = false;
            // 
            // chkName
            // 
            this.chkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chkName.FillWeight = 66.36678F;
            this.chkName.HeaderText = "Name";
            this.chkName.MinimumWidth = 6;
            this.chkName.Name = "chkName";
            this.chkName.ReadOnly = true;
            // 
            // chkQty
            // 
            this.chkQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chkQty.FillWeight = 66.36678F;
            this.chkQty.HeaderText = "Quntity";
            this.chkQty.MinimumWidth = 6;
            this.chkQty.Name = "chkQty";
            this.chkQty.ReadOnly = true;
            // 
            // chkPrice
            // 
            this.chkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chkPrice.FillWeight = 66.36678F;
            this.chkPrice.HeaderText = "Price";
            this.chkPrice.MinimumWidth = 6;
            this.chkPrice.Name = "chkPrice";
            this.chkPrice.ReadOnly = true;
            // 
            // chkAmount
            // 
            this.chkAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chkAmount.FillWeight = 66.36678F;
            this.chkAmount.HeaderText = "Amount";
            this.chkAmount.MinimumWidth = 6;
            this.chkAmount.Name = "chkAmount";
            this.chkAmount.ReadOnly = true;
            // 
            // chkDel
            // 
            this.chkDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chkDel.FillWeight = 50F;
            this.chkDel.HeaderText = "";
            this.chkDel.Image = ((System.Drawing.Image)(resources.GetObject("chkDel.Image")));
            this.chkDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.chkDel.MinimumWidth = 50;
            this.chkDel.Name = "chkDel";
            this.chkDel.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoEllipsis = true;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.lblTotal.Location = new System.Drawing.Point(281, 489);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(175, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Payment Received";
            // 
            // lbltotPrice
            // 
            this.lbltotPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotPrice.AutoEllipsis = true;
            this.lbltotPrice.AutoSize = true;
            this.lbltotPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.lbltotPrice.Location = new System.Drawing.Point(683, 99);
            this.lbltotPrice.Name = "lbltotPrice";
            this.lbltotPrice.Size = new System.Drawing.Size(24, 25);
            this.lbltotPrice.TabIndex = 8;
            this.lbltotPrice.Text = "0";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.pictureBox2.Location = new System.Drawing.Point(12, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(762, 1);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(23, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bill Amount";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(506, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(23, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Change";
            // 
            // txtRecevied
            // 
            this.txtRecevied.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRecevied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecevied.Location = new System.Drawing.Point(462, 487);
            this.txtRecevied.Name = "txtRecevied";
            this.txtRecevied.Size = new System.Drawing.Size(100, 27);
            this.txtRecevied.TabIndex = 17;
            this.txtRecevied.Text = "0";
            this.txtRecevied.TextChanged += new System.EventHandler(this.txtRecevied_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(150, 542);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(100, 27);
            this.txtChange.TabIndex = 17;
            this.txtChange.Text = "0";
            // 
            // txtBill
            // 
            this.txtBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(150, 489);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(100, 27);
            this.txtBill.TabIndex = 17;
            this.txtBill.Text = "0";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckout.AutoEllipsis = true;
            this.btnCheckout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(450, 534);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(123, 42);
            this.btnCheckout.TabIndex = 18;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // dgvAdd
            // 
            this.dgvAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAdd.FillWeight = 50F;
            this.dgvAdd.HeaderText = "";
            this.dgvAdd.Image = ((System.Drawing.Image)(resources.GetObject("dgvAdd.Image")));
            this.dgvAdd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvAdd.MinimumWidth = 50;
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.ReadOnly = true;
            this.dgvAdd.Width = 50;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 100;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.FillWeight = 200F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 200;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            // 
            // categoryView
            // 
            this.categoryView.AllowUserToAddRows = false;
            this.categoryView.AllowUserToDeleteRows = false;
            this.categoryView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryView.BackgroundColor = System.Drawing.Color.White;
            this.categoryView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoryView.ColumnHeadersHeight = 50;
            this.categoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvPrice,
            this.dgvAdd});
            this.categoryView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.categoryView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryView.Location = new System.Drawing.Point(5, 168);
            this.categoryView.Name = "categoryView";
            this.categoryView.ReadOnly = true;
            this.categoryView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoryView.RowHeadersVisible = false;
            this.categoryView.RowHeadersWidth = 10;
            this.categoryView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.categoryView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.categoryView.RowTemplate.Height = 24;
            this.categoryView.Size = new System.Drawing.Size(427, 224);
            this.categoryView.StandardTab = true;
            this.categoryView.TabIndex = 3;
            this.categoryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryView_CellContentClick);
            // 
            // frmOrders
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtRecevied);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbltotPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbltotPrice;
        private RestaurantCategory restaurantCategory;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private RestaurantCategoryTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkAmount;
        private System.Windows.Forms.DataGridViewImageColumn chkDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecevied;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtBill;
        public System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridViewImageColumn dgvAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridView categoryView;
    }
}
