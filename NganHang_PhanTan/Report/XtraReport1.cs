using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace NganHang_PhanTan.Report
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
        }
        public XtraReport1(string stk, string dateStart, string dateEnd)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = stk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateStart;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = dateEnd;
            this.sqlDataSource1.Fill();
            IEnumerator enumerator = this.sqlDataSource1.Result.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                // In giá trị của mỗi phần tử ra màn hình
                Console.WriteLine(item.ToString());
            }

        }
    }
}
