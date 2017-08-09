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
    public partial class frmNhanVien : frmDanhMuc_Base
    {
        CNhan_Vien_Controller _NhanVien_Ctrl = CNhan_Vien_Controller.getInstance();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
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
            col_MaNhanVien.FieldName = "Ma_Nhan_Vien";
            col_TenNhanVien.FieldName = "Ten_Nhan_Vien";
            col_SoDienThoai.FieldName = "So_Dien_Thoai";
            col_DiaChi.FieldName = "Dia_Chi";
        }

        protected override void loadData(int Auto_ID)
        {
            try
            {
                myGrid.DataSource = _NhanVien_Ctrl.List_Nhan_Vien();

            }
            catch(Exception ex)
            {
                CExtensions.showErrorException(ex, "Lỗi nạp dữ liệu");
            }

        }
        protected override void Add()
        {
            using (frmChiTietNhanVien frm = new frmChiTietNhanVien())
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
                    using (var _frm = new frmChiTietNhanVien())
                    {

                        CNhan_Vien v_objNhanVien = (CNhan_Vien)myGridView1.GetFocusedRow();
                        _frm._objNhanVien = v_objNhanVien;
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
                    CNhan_Vien v_objNhanVien = (CNhan_Vien)myGridView1.GetFocusedRow();
                    if (v_objNhanVien != null)
                    {
                        _NhanVien_Ctrl.Delete_Nhan_Vien(v_objNhanVien.Auto_ID, "Admin");
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