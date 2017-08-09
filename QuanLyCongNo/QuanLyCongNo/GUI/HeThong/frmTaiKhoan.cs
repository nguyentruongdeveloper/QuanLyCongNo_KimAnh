using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyCongNo.GUI.Common;
using QuanLyCongNo.GUI.DanhMuc.Sub;

namespace QuanLyCongNo.GUI.HeThong
{
    public partial class frmTaiKhoan : frmDanhMuc_Base
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loadData(0);

        }
        protected override void refeshData()
        {

        }
        protected override void loadData(int Auto_ID)
        {

        }
        protected override void Add()
        {
            using (frmChiTietTaiKhoan frm = new frmChiTietTaiKhoan())
            {
                frm.fType = Utility.FormType.Add;
                frm.ShowDialog();
            }

        }
        protected override void Updated_Data()
        {
            using (frmChiTietTaiKhoan frm = new frmChiTietTaiKhoan())
            {
                frm.fType = Utility.FormType.Update;
                frm.ShowDialog();
            }
        }

        protected override void Deleted()
        {


        }
        protected override void Close()
        {
            base.Close();
        }
    }
}