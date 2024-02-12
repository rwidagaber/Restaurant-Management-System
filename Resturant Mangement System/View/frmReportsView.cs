using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.View
{
    public partial class frmReportsView : Form
    {
        public frmReportsView()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string qry = @"select * from tblMain m inner join tblDetails d on m.MainID = d.MainID
                               inner join product p on p.pID = d.proID " ;

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            MainClass.con.Close();
            //frmPrint frm = new frmPrint();   
            //rptBill cr = new rptBill();
            //cr.SetDataselogin("sa", "123");
            //cr.SetDataSource(dt);
            //frm.crystalReport[Viewer].ReportSource=cr;
            //frm.crystalReport[Viewer].Refresh();
            //frm.show();





        }
    }
}
