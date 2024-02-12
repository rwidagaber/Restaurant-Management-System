﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.Model
{
    public partial class frmTableSelect : Form
    {

        public string TableName;
        public frmTableSelect()
        {
            InitializeComponent();
        }

        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            string qry = "Select * from table";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button b = new System.Windows.Forms.Button();
                b.Text = row["tname"].ToString();
                b.Width = 150;
                b.Height = 50;
                //b.fillColor = Color.FromArgb(241, 85, 126);
                //b.hoverState.FillColor = Color.FromArgb(50, 55, 89);

                //event for click
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);

            }


        }

        private void b_Click(object sender, EventArgs e)
        {

            TableName = (sender as System.Windows.Forms.Button).Text.ToString();
            this.Close();
        }
    }
}
