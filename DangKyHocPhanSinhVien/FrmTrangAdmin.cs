using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhanSinhVien
{
    public partial class FrmTrangAdmin : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangAdmin()
        {
            InitializeComponent();
        }

        private void FrmTrangAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
