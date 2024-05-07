using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.View
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
            
        }
        public int id = 0;
        public int cID = 0;
        
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantCategoryDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.restaurantCategoryDataSet.category);
            // TODO: This line of code loads data into the 'rMSDataSet1.category' table. You can move, or remove it, as needed.
            cbcat.SelectedIndex = -1;

            if (cID > 0)
            {
                cbcat.SelectedValue=cID;
            }
            

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            //insert category
            if (id == 0)
            {
                qry = "Insert into product Values(@Name,@Price,@cat)";
            }
            //Update category
            else
            {
                qry = "Update product Set pName = @Name,pPrice = @Price, categoryID=@cat where pID= @id";

            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add("@id", id);
            hashtable.Add("@Name", txtsproductName.Text);
            hashtable.Add("@Price", txtPrice.Text);
            hashtable.Add("@cat", Convert.ToInt32(cbcat.SelectedValue));




            if (MainClass.SQl(qry, hashtable) > 0)
            {
                MessageBox.Show("Saved Successfuly..");
                id = 0;
                cID = 0;
                txtsproductName.Text = "";
                txtsproductName.Focus();
                txtPrice.Text = "";
                txtPrice.Focus();
                cbcat.SelectedIndex = -1;
                cbcat.Focus();
            }
        }
      
        
        
       /* private void ForUpdatelLoadData()
        {
            string qry = @"select * from product where pID= " + id + "";
            SqlCommand cmd=new SqlCommand(qry,MainClass.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
                txtsproductName.Text = dataTable.Rows[0]["pName"].ToString();
                txtPrice.Text= dataTable.Rows[0]["pPrice"].ToString();
                byte[] imageByteArray = (byte[])(dataTable.Rows[0]["pImage"]);
                txtImage.Image=Image.FromStream(new MemoryStream(imageByteArray));


            }
        }*/
    }
}
