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
using Controller;
using DTO;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.DanhMuc
{
    public partial class frmXe : frmDanhMuc_Base
    {
        CXe_Controller _XeCtrl = CXe_Controller.getInstance();

        public frmXe()
        {
            InitializeComponent();
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            CustomForm();
            loadData(0);

        }
        private void CustomForm()
        {
            loadFieldName_Grid();
        }
        private void loadFieldName_Grid()
        {
            col_Auto_ID.FieldName = "Auto_ID";
            col_SoXe.FieldName = "So_Xe";
            col_TenXe.FieldName = "Ten_Xe";
            col_TrongTai.FieldName = "Trong_Tai";
            col_GhiChu.FieldName = "Ghi_Chu";


        }
      
        protected override void loadData(int Auto_ID)
        {
          
            try
            {
                myGrid.DataSource = _XeCtrl.List_Xe();
            }
            catch (Exception ex)
            {
                CExtensions.showErrorException(ex, "Lỗi nạp dữ liệu");
            }

        }
        protected override void Add()
        {
            using (frmChiTietXe frm = new frmChiTietXe())
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
        private void Update_Entity()
        {
            if (myGridView1.RowCount > 0 && myGridView1.FocusedRowHandle >= 0)
            {
                try
                {
                    using (var _frm = new frmChiTietXe())
                    {

                        CXe v_objXe = (CXe)myGridView1.GetFocusedRow();
                        _frm._objXe = v_objXe;
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
                    CXe v_objXe = (CXe)myGridView1.GetFocusedRow();
                    if (v_objXe != null)
                    {
                        _XeCtrl.Delete_Xe(v_objXe.Auto_ID, "Admin");
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

        protected override void Deleted()
        {
            Delete_Entity();


        }
        protected override void Close()
        {
            base.Close();
        }
    }
}