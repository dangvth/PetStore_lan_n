﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PetStore
{
    public partial class DetailToys : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DetailToys()
        {
            InitializeComponent();
        }

        private void btnclose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}