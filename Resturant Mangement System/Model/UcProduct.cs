﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.Model
{
    public partial class UcProduct : UserControl
    {
        public UcProduct()
        {
            InitializeComponent();
        }


        public event EventHandler onSelect = null;

        public int id { get; set; }

        public string PPrice { get; set; }

        public string PCategory { get; set; }

        public string PName
        {
            get { return IbName.Text; }
            set { IbName.Text = value; }


        }

        public Image PImage
        {
            get { return txtImg.Image; }
            set { txtImg.Image = value; }


        }

        private void txtImg_click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

    }
}
