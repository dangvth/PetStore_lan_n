using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace PetStore
{
    public partial class BillReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BillReport()
        {
            InitializeComponent();
        }
        private GridControl control;
        public GridControl GridControl
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
                printableComponentContainer1.PrintableComponent = control;
            }
        }
    }
}
