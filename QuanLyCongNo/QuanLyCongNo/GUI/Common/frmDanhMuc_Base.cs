using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace QuanLyCongNo.GUI.Common
{
    public partial class frmDanhMuc_Base : XtraForm
    {
        public frmDanhMuc_Base()
        {
            InitializeComponent();
        }



        private void frmDanhMuc_Base_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btn_DanhMuc_ThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();

        }
        private void btn_DanhMuc_Sua_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updated_Data();


        }
        private void btn_DanhMuc_Xoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deleted();
        }

        private void btn_DanhMuc_NapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            refeshData();
        }

        private void btn_DanhMuc_Dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();

        }
        protected virtual void loadData(int Auto_ID = 0)
        {

        }
        protected virtual void refeshData()
        {

        }
        protected virtual void Add()
        {

        }
        protected virtual void Updated_Data()
        {

        }
        protected virtual void Deleted()
        {

        }
        protected virtual void Close()
        {
            this.Dispose();
        }



    }
}