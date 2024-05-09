using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Resturant_Mangement_System
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }
        public void GetData()
        {

            string qry = "";
            if (cbCategory.SelectedIndex != -1) qry = "Select pID,pName,pPrice from product where categoryID =" + cbCategory.SelectedValue + " ";
            else qry = "Select pID,pName,pPrice from product";
            ListBox listBox = new ListBox();
            listBox.Items.Add(dgvid);
            listBox.Items.Add(dgvName);
            listBox.Items.Add(dgvPrice);
            MainClass.LoadData(qry, categoryView, listBox);
        }

        private void GetTotal()
        {
            double tot = 0;
            lbltotPrice.Text = "";
            foreach (DataGridViewRow item in dgvCheck.Rows)
            {

                tot += double.Parse(item.Cells["chkAmount"].Value.ToString());
            }
            lbltotPrice.Text = tot.ToString("N2")+" EGP";
            txtBill.Text = tot.ToString("N2");

        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantCategory.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.restaurantCategory.category);
            cbCategory.SelectedIndex = -1;
            GetData();

        }

        private void categoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryView.CurrentCell.OwningColumn.Name == "dgvAdd")
            {
                //this will check product already there then +1 to quantity and update price
                foreach (DataGridViewRow item in dgvCheck.Rows)
                {
                  

                    if (item.Cells["chkId"].Value.ToString() == categoryView.CurrentRow.Cells["dgvid"].Value.ToString())
                    {

                        item.Cells["chkQty"].Value = int.Parse(item.Cells["chkQty"].Value.ToString()) + 1;
                        item.Cells["chkAmount"].Value = int.Parse(item.Cells["chkQty"].Value.ToString()) * double.Parse(item.Cells["chkPrice"].Value.ToString());
                        GetTotal();
                        return;
                    }
                }
                //this line add new product
                dgvCheck.Rows.Add(new object[] { 0, categoryView.CurrentRow.Cells["dgvid"].Value, categoryView.CurrentRow.Cells["dgvName"].Value, 1, categoryView.CurrentRow.Cells["dgvPrice"].Value, categoryView.CurrentRow.Cells["dgvPrice"].Value });
                GetTotal();             
            }
            

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgvCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure to remove this item? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvCheck.CurrentCell.OwningColumn.Name == "chkDel")
                {
                    if (int.Parse(dgvCheck.CurrentRow.Cells["chkQty"].Value.ToString()) == 1)
                    {
                        dgvCheck.Rows.RemoveAt(dgvCheck.CurrentRow.Index);
                    }
                    else
                    {
                        dgvCheck.CurrentRow.Cells["chkQty"].Value = int.Parse(dgvCheck.CurrentRow.Cells["chkQty"].Value.ToString()) - 1;
                        dgvCheck.CurrentRow.Cells["chkAmount"].Value = int.Parse(dgvCheck.CurrentRow.Cells["chkQty"].Value.ToString()) * double.Parse(dgvCheck.CurrentRow.Cells["chkPrice"].Value.ToString());
                        GetTotal();

                    }
                }
            }
        }

        private void dgvCheck_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // set serial number
            int count = 0;
            foreach (DataGridViewRow row in dgvCheck.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void txtRecevied_TextChanged(object sender, EventArgs e)
        {
            if(txtRecevied.Text.Length!=0)
            txtChange.Text=(double.Parse(txtRecevied.Text.ToString())-double.Parse(txtBill.Text.ToString())).ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            double x = 0;
            dgvCheck.Rows.Clear();
            lbltotPrice.Text = x.ToString();
            txtBill.Text = x.ToString();
            txtChange.Text = x.ToString();
            txtRecevied.Text = x.ToString();
            cbCategory.SelectedIndex = -1;

        }
    }
}
