using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang_PhanTan
{
    public partial class Xtrp_SaoKe : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_SaoKe()
        {
        }

        public Xtrp_SaoKe(string stk, string dateStart, string dateEnd)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = stk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateStart;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = dateEnd;
            this.sqlDataSource1.Fill();

        }
    }
}
