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
using QuanLyCongNo.Extensions;
using DTO;

namespace QuanLyCongNo.GUI.DanhMuc
{
    public partial class frmKhachHang : frmDanhMuc_Base
    {
        CKhach_Hang_Controller _KhachHangCtrl = CKhach_Hang_Controller.getInstance();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            CustomForm();
            loadData(0);

        }

        protected override void loadData(int Auto_ID)
        {
            try
            {
                myGrid.DataSource = _KhachHangCtrl.List_Khach_Hang();
            }
            catch (Exception ex)
            {
                CExtensions.showErrorException(ex, "Lỗi nạp dữ liệu");
            }

        }
        private void CustomForm()
        {
            loadFieldName_Grid();
        }
        private void loadFieldName_Grid()
        {
            col_Auto_ID.FieldName = "Auto_ID";
            col_MaKhachHang.FieldName = "Ma_Khach_Hang";
            col_TenKhachHang.FieldName = "Ten_Khach_Hang";
            col_MaSoThue.FieldName = "Ma_So_Thue";
            col_SoDienThoai.FieldName = "So_Dien_Thoai";
            col_Email.FieldName = "Email";
            col_DiaChi.FieldName = "Dia_Chi";

        }
        protected override void Add()
        {
            using (frmChiTietKhachHang frm = new frmChiTietKhachHang())
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
                    using (var _frm = new frmChiTietKhachHang())
                    {

                        CKhach_Hang v_objKhachHang = (CKhach_Hang)myGridView1.GetFocusedRow();
                        _frm._objKhachHang = v_objKhachHang;
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
                    CKhach_Hang v_objKhachHang = (CKhach_Hang)myGridView1.GetFocusedRow();
                    if (v_objKhachHang != null)
                    {
                        _KhachHangCtrl.Delete_Khach_Hang(v_objKhachHang.Auto_ID, "Admin");
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