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
    public partial class DetailGift : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DetailGift()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}