using Controller;
using DTO;
using QuanLyCongNo.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongNo.GUI.DichVu
{
    public partial class frmPhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
        CChi_Tiet_Dich_Vu_Controller _CTDV_Ctrl = CChi_Tiet_Dich_Vu_Controller.getInstance();
        BindingList<CChi_Tiet_Dich_Vu> _bdChiTietDichVu = new BindingList<CChi_Tiet_Dich_Vu>();
        public frmPhieuDichVu()
        {
            InitializeComponent();
        }

        private void frmPhieuDichVu_Load(object sender, EventArgs e)
        {
            customFrom();
            loadDataForm();
        }
        private void customFrom()
        {
            _bdChiTietDichVu.AllowNew = true;
            _bdChiTietDichVu.AllowEdit = true;
            _bdChiTietDichVu.AllowRemove = true;
            FormatControl();
        }
        private void FormatControl()
        {
            res_sp_DonGia.Format(2, false, true);
            res_sp_ThanhTien.Format(2, false, true);

        }

        private void loadDataForm()
        {
            loadRepository();
            getDataFromEntity();

        }
        private void getDataFromEntity()
        {
            getDataGrid();

        }
        private void getDataGrid()
        {
            _bdChiTietDichVu = new BindingList<CChi_Tiet_Dich_Vu>(_CTDV_Ctrl.List_Chi_Tiet_Dich_Vu());
            grc_DichVu.DataSource = _bdChiTietDichVu;
        }


        private void loadRepository()
        {
            loadRepository_KhachHang();
            loadRepository_NhanVien();
            loadRepositoty_Xe();
            loadRepository_DichVu();

        }
        private void loadRepository_KhachHang(int p_iAutoID = 0)
        {
            CKhach_Hang_Controller v_KhachHang_Ctrl = CKhach_Hang_Controller.getInstance();
            slok_DV_KhachHang.Properties.DataSource = v_KhachHang_Ctrl.List_Khach_Hang();
            slok_DV_KhachHang.Properties.ValueMember = "Auto_ID";
            slok_DV_KhachHang.Properties.DisplayMember = "Ma_Khach_Hang";

        }
        private void loadRepository_NhanVien(int p_iAutoID = 0)
        {
            CNhan_Vien_Controller v_NhanVien_Ctrl = CNhan_Vien_Controller.getInstance();
            slok_DV_NhanVien.Properties.DataSource = v_NhanVien_Ctrl.List_Nhan_Vien();
            slok_DV_NhanVien.Properties.ValueMember = "Auto_ID";
            slok_DV_NhanVien.Properties.DisplayMember = "Ten_Nhan_Vien";
        }
        private void loadRepositoty_Xe(int p_iAutoID = 0)
        {
            CXe_Controller v_Xe_Ctrl = CXe_Controller.getInstance();
            res_slok_Xe.DataSource = v_Xe_Ctrl.List_Xe();
            res_slok_Xe.ValueMember = "Auto_ID";
            res_slok_Xe.DisplayMember = "So_Xe";
        }
        private void loadRepository_DichVu(int p_iDichVu = 0)
        {
            CDich_Vu_Controller v_DichVu_Ctrl = CDich_Vu_Controller.getInstance();
            res_slok_DichVu.DataSource = v_DichVu_Ctrl.List_Dich_Vu();
            res_slok_DichVu.ValueMember = "Auto_ID";
            res_slok_DichVu.DisplayMember = "Ten_Dich_Vu";
        }

        private void slok_DV_KhachHang_EditValueChanged(object sender, EventArgs e)
        {
            CKhach_Hang v_objKH = slok_DV_KhachHang.Properties.View.GetFocusedRow() as CKhach_Hang;
            if(v_objKH!=null)
            {
                txt_DV_TenKH.Text = v_objKH.Ten_Khach_Hang;
                txt_DV_DiaChi.Text = v_objKH.Dia_Chi;
                txt_DV_Email.Text = v_objKH.Email;
                txt_DV_SDT.Text = v_objKH.So_Dien_Thoai;
            }
        }

        private void barLargeButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
