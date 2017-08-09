using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using QuanLyCongNo.GUI.DanhMuc.Sub;

namespace QuanLyCongNo.GUI.DichVu
{
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void navBarItem_PhieuDichVu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //tvMain.Controller.Activate(tvMain.Documents[1]);
       


        }
        private void addDocument(DevExpress.XtraEditors.XtraUserControl _xtrForm,int index)
        {
            //if (_xtrForm == null) return;
            //BaseDocument document = docDichVu.GetDocument(_xtrForm);
            //if (document != null)
            //{

            //    tvMain.Controller.Activate(document);
            //}
            //else
            //{
            //    tvMain.AddDocument(_xtrForm);
               
            //}


        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {

        }

        private void navBarItem_BangKe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //tvMain.Controller.Activate(tvMain.Documents[0]);
            

        }

        private void tvMain_QueryControl(object sender, QueryControlEventArgs e)
        {
           
            if(e.Document.ControlName=="ucPhieuDichVu")
            {
                
                e.Control = new ucPhieuDichVu();
            }
            else
            {
                e.Control = new ucBangKe();
            }

        }

        private void navBarItem_DichVu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (frmChiTietDichVu frm = new frmChiTietDichVu())
            {
                frm.fType = Utility.FormType.Add;
                frm.ShowDialog();
            }

        }

        private void navBarItem_Xe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (frmChiTietXe frm = new frmChiTietXe())
            {
                frm.fType = Utility.FormType.Add;
                frm.ShowDialog();
            }

        }

        private void navBarItem_KhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (frmChiTietKhachHang frm = new frmChiTietKhachHang())
            {
                frm.fType = Utility.FormType.Add;
                frm.ShowDialog();
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            using (frmPhieuDichVu frm = new frmPhieuDichVu())
            {
                frm.ShowDialog();
            }
        }
    }
}