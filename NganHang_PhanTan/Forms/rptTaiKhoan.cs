using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang_PhanTan
{
    public partial class rptTaiKhoan : Form
    {
        public rptTaiKhoan(string quyen, DateTime value)
        {
            InitializeComponent();
        }

        public rptTaiKhoan(string quyen, DateTime value, DateTime value1) : this(quyen, value)
        {
        }
    }
}
