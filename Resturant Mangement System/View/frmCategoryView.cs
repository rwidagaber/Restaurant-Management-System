﻿using Resturant_Mangement_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.View
{
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "Select * from category where catName like '%"+txtSearch.Text+"%' ";
            ListBox listBox = new ListBox();
            listBox.Items.Add(dgvid);
            listBox.Items.Add(dgvName);

            MainClass.LoadData(qry, categoryView,listBox); 
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet1.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.restaurantDataSet1.category);
            // TODO: This line of code loads data into the 'restaurantDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.restaurantDataSet.category);
            GetData();
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd();
            frm.ShowDialog();
            GetData();
        }


        private void categoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmCategoryAdd frm = new frmCategoryAdd();
                frm.id = Convert.ToInt32(categoryView.CurrentRow.Cells["dgvid"].Value);
                frm.txtCatName.Text = Convert.ToString(categoryView.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            else if (categoryView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                if (MessageBox.Show("Are you sure to delete this category? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    try
                    {
                        int iD = Convert.ToInt32(categoryView.CurrentRow.Cells["dgvid"].Value);
                        string qry = "Delete from category where catID= " + iD + "";
                        Hashtable ht = new Hashtable();
                        MainClass.SQl(qry, ht);
                        MessageBox.Show("Category has been deleted Successfully..");
                        GetData();
                    }
                    catch (Exception ex) 
                    {
                        if (ex is SqlException || ex is FormatException) // Check if the exception is of type InvalidOperationException
                        {
                            if (MessageBox.Show("Sorry, you can't delete this category as there are products in this category. Would you like to edit it instead?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                // Open the form for editing the product
                                frmCategoryAdd frm = new frmCategoryAdd();
                                frm.id = Convert.ToInt32(categoryView.CurrentRow.Cells["dgvid"].Value);
                                frm.txtCatName.Text = Convert.ToString(categoryView.CurrentRow.Cells["dgvName"].Value);
                                frm.ShowDialog();
                                GetData();
                            }
                        }

                    }
                }
            }  
        }

        

    }
}
