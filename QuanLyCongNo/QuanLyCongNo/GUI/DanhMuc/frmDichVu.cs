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
using QuanLyCongNo.GUI.Common;
using QuanLyCongNo.GUI.DanhMuc.Sub;
using DTO;
using Controller;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.DanhMuc
{
    public partial class frmDichVu : frmDanhMuc_Base
    {
        private CDich_Vu_Controller _DichVu_Ctrl = CDich_Vu_Controller.getInstance();

        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            CustomForm();
            loadData(0);
        }
       private void CustomForm()
        {
            loadColumFieldName();
        }
        private void loadColumFieldName()
        {
            col_Auto_ID.FieldName = "Auto_ID";
            col_MaDichVu.FieldName = "Ma_Dich_Vu";
            col_TenDichVu.FieldName = "Ten_Dich_Vu";
            col_DienGiai.FieldName = "Dien_Giai";
        }
          
        protected override void loadData(int Auto_ID)
        {
            try
            {
                myGrid.DataSource = _DichVu_Ctrl.List_Dich_Vu();

            }
            catch (Exception ex)
            {
                CExtensions.showErrorException(ex, "Lỗi nạp dữ liệu!");

            }

        }
        protected override void Add()
        {
            using (frmChiTietDichVu frm = new frmChiTietDichVu())
            {
                frm.fType = Utility.FormType.Add;
                frm.ReLoadParent = this.loadData;
                frm.ShowDialog();
            }

        }
        protected override void Updated_Data()
        {
            Update_Entity();
        }

        protected override void Deleted()
        {
            Delete_Entity();

        }
        protected override void Close()
        {
            base.Close();
        }
        private void Update_Entity()
        {
            if (myGridView1.RowCount > 0 && myGridView1.FocusedRowHandle >= 0)
            {
                try
                {
                    using (var _frm = new frmChiTietDichVu())
                    {

                        CDich_Vu v_objDichVu = (CDich_Vu)myGridView1.GetFocusedRow();
                        _frm._objDichVu = v_objDichVu;
                        _frm.fType = Utility.FormType.Update;
                        _frm.ReLoadParent = this.loadData;
                        _frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    CExtensions.showErrorException(ex, "Error");
                }
            }

        }
        private void Delete_Entity()
        {
            if (myGridView1.RowCount > 0 && myGridView1.FocusedRowHandle >= 0 && CExtensions.showConfirmMessage("Xác nhận xóa dữ liệu"))
            {
                try
                {
                    CDich_Vu v_objDichVu = (CDich_Vu)myGridView1.GetFocusedRow();
                    if (v_objDichVu != null)
                    {
                        _DichVu_Ctrl.Delete_Dich_Vu(v_objDichVu.Auto_ID, "Admin");
                        loadData(0);
                        CExtensions.showMessage("Xóa thành công!");


                    }
                }
                catch (Exception ex)
                {
                    CExtensions.showErrorException(ex, "Xóa dữ liệu không thành công.\r\nVui lòng kiểm tra lại");
                }
            }

        }


    }
}