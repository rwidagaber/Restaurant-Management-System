﻿using System;
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

namespace Resturant_Mangement_System.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        public string OrderType;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProducts();
        }


        private void AddCategory()
        {
            string qry = "Select * from category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            CategoryPanel.Controls.Clear();


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) //back again to make sure--->
                {
                    //properties
                    Button b = new Button();
                    b.BackColor = Color.FromArgb(255, 223, 0);
                    b.Size = new Size(134, 45);
                    //b.ButtonMode = System.Windows.Forms.Enums.ButtonMode.RadioButton;
                    b.Text = row["CatNamw"].ToString();

                    //event for click

                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }

            }
        }

        private void b_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

            if (b.Text == "All Ctegories")
            {
                txtsearch.Text = "1";
                txtsearch.Text = "";
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (UcProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            };
        }

        private void AddItems(string id, string proID, string name, string cat, string price, Image pimage)
        {
            var w = new UcProduct
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UcProduct)ss;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    //this will check product already there then +1 to quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString());
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                            double.Parse(item.Cells["dgvPricec"].Value.ToString());

                        return;

                    }


                }
                //this line add new product
                dataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });

                GetTotal();
            };



        }


        //getting product from DB

        private void LoadProducts()
        {
            string qry = "select * from product inner join category on catID = categoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["PImage"];
                byte[] imagebytarray = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagebytarray)));
            }
        }



        private void CategoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (UcProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtsearch.Text.Trim().ToLower());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //for serial no

            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        //total price
        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            dataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private void btnDelievery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Delievery";
        }

        

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Din in";
            frmTableSelect tabfrm = new frmTableSelect();
            //MainClass.BlurBackground(tabfrm);

            if (tabfrm.TableName != "")
            {
                lblTable.Text = tabfrm.TableName;
                lblTable.Visible = true;
            }

            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }


            frmWaiterSelect frm2 =  new frmWaiterSelect();

           // MainClass.BlurBackground(frm2);

            if (frm2.WaiterName != "")
            {
                lblWaiter.Text = frm2.WaiterName;
                lblWaiter.Visible = true;
            }

            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            //save the date in DB

            string qryl = "";  //main table
            string qry2 = ""; //deatil table

            int detailID = 0;
            if (MainID == 0) //insert
            {
                qryl = @"insert into tblMain Values(@aDate , @aTime , @TableName  ,@WaiterName ,
                               @status , @orderType , @total , @recevied , @change);
                                 select SCOPE_IDENTITY()";  //this line will get recent add id value

            }

            else //update
            {
                qryl = @"update into tblMain set status= @status,total = @total,recevied = @recevied,change = @change where MainID = @ID)";

            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qryl, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("(@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(0));  //as we only saving data for kitch value will update when payement
            cmd.Parameters.AddWithValue("@recevied", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) //insert
                {
                    qry2 = @"insert info tblDetails Values(@MainID , @proID , @qty , @priec , @amount";
                }

                else
                {
                    qry2 = @"update  tblDetails set  proID = @proID , qty = @qty , priec = @priec , amount = @amount";

                }


                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd.Parameters.AddWithValue("@ID", detailID);
                cmd.Parameters.AddWithValue("@MainID", MainID);
                cmd.Parameters.AddWithValue("(@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd.Parameters.AddWithValue("@priec", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvQty"].Value));


                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


                //msg--->saved successfully

                MainID = 0;
                detailID = 0;
                dataGridView1.Rows.Clear();
                lblTable.Text = "";
                lblWaiter.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                MainID = 0;
                lblTotal.Text = "00";

            }

        }


    }
}