using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utility;
using Controller;
using DTO;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.DanhMuc.Sub
{
    public partial class frmChiTietTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormType fType { get; set; }
        private CTai_Khoan_Controller _TaiKhoan_Ctrl = CTai_Khoan_Controller.getInstance();
        public delegate void LoadData(int strKey);
        public LoadData ReLoadParent;
        public CTai_Khoan _objTaiKhoan { get; set; }
        public frmChiTietTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmChiTietTaiKhoan_Load(object sender, EventArgs e)
        {
            customFrom();
            loadRepository();
            loadDataFrom();

        }
        private void customFrom()
        {

        }
        private void loadDataFrom()
        {
            if (fType == FormType.Add)
            {
                this.Text = "Thêm mới thông tin tài khoản";
                _objTaiKhoan = new CTai_Khoan();

            }
            else
            {
                this.Text = "Sửa thông tin tài khoản";
                getDataFromEntity();

            }

        }
        private void loadRepository()
        {
            loadRepository_NhanVien();

        }
        private void loadRepository_NhanVien()
        {
            CNhan_Vien_Controller NhanVien_Ctrl = CNhan_Vien_Controller.getInstance();
            slok_NhanVien.Properties.DataSource = NhanVien_Ctrl.List_Nhan_Vien();
            slok_NhanVien.Properties.DisplayMember = "MaNhanVien";
            slok_NhanVien.Properties.ValueMember = "Auto_ID";
            

        }
        private void getDataFromEntity()
        {
            slok_NhanVien.EditValue = _objTaiKhoan.Nhan_Vien_ID;
            txt_TenDangNhap.Text = _objTaiKhoan.Tai_Khoan;
            txt_MatKhau.Text = _objTaiKhoan.Mat_Khau;
        }
        private void setDataToEntity()
        {
            _objTaiKhoan.Nhan_Vien_ID = CUtility.Convert_To_Int32(slok_NhanVien.EditValue);
            _objTaiKhoan.Tai_Khoan = txt_TenDangNhap.Text;
            _objTaiKhoan.Mat_Khau = txt_MatKhau.Text;
         


        }
        private bool saveData()
        {
            bool v_blResult = true;
            setDataToEntity();

            if (fType == FormType.Add)
            {
                try
                {
                    _TaiKhoan_Ctrl.Insert_Tai_Khoan(_objTaiKhoan);
                }
                catch (Exception ex)
                {
                    v_blResult = false;
                    CExtensions.showErrorException(ex, "Error!");
                }


            }
            if (fType == FormType.Update)
            {
                try
                {
                    _TaiKhoan_Ctrl.Update_Tai_Khoan(_objTaiKhoan);
                }
                catch (Exception ex)
                {
                    v_blResult = false;
                    CExtensions.showErrorException(ex, "Error!");
                }

            }

            return v_blResult;

        }
        private bool validateForm()
        {
            bool v_blResult = true;
            return v_blResult;

        }
        private void resetForm()
        {
            slok_NhanVien.EditValue = 0;
            txt_TenDangNhap.Text = "";
            txt_MatKhau.Text = "";
            slok_NhanVien.Focus();


        }
        private void closeForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (saveData())
                {
                    closeForm();
                    ReLoadParent(0);

                }

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void btnLuuAndThem_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (saveData())
                {
                    resetForm();
                    ReLoadParent(0);

                }

            }
        }
    }
}