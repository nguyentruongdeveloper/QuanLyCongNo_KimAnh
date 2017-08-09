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
using Utility;
using Controller;
using DTO;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.DanhMuc.Sub
{
    public partial class frmChiTietNhanVien : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public FormType fType { get; set; }
        private CNhan_Vien_Controller _NhanVien_Ctrl = CNhan_Vien_Controller.getInstance();
        public delegate void LoadData(int strKey);
        public LoadData ReLoadParent;
        public CNhan_Vien _objNhanVien { get; set; }
        #endregion
      
        public frmChiTietNhanVien()
        {
            InitializeComponent();
        }
        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {
            customFrom();
            loadDataFrom();

        }
        private void customFrom()
        {

        }
        private void loadDataFrom()
        {
            if (fType == FormType.Add)
            {
                this.Text = "Thêm mới thông tin nhân viên";
                _objNhanVien = new CNhan_Vien();

            }
            else
            {
                this.Text = "Sửa thông tin nhân viên";
                getDataFromEntity();
            }

        }
        private void getDataFromEntity()
        {
            txt_MaNhanVien.Text = _objNhanVien.Ma_Nhan_Vien;
            txt_TenNhanVien.Text = _objNhanVien.Ten_Nhan_Vien;
            txt_SoDienThoai.Text = _objNhanVien.So_Dien_Thoai;
            txt_DiaChi.Text = _objNhanVien.Dia_Chi;
         
            


        }
        private void setDataToEntity()
        {
            _objNhanVien.Ma_Nhan_Vien = txt_MaNhanVien.Text;
            _objNhanVien.Ten_Nhan_Vien = txt_TenNhanVien.Text;
            _objNhanVien.So_Dien_Thoai = txt_SoDienThoai.Text;
            _objNhanVien.Dia_Chi = txt_DiaChi.Text;
      


        }
        private bool saveData()
        {
            bool v_blResult = true;
            setDataToEntity();

            if (fType == FormType.Add)
            {
                try
                {
                    _NhanVien_Ctrl.Insert_Nhan_Vien(_objNhanVien);
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
                    _NhanVien_Ctrl.Update_Nhan_Vien(_objNhanVien);
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
            txt_MaNhanVien.Text = "";
            txt_TenNhanVien.Text = "";
            txt_SoDienThoai.Text = "";
            txt_DiaChi.Text = "";
            txt_MaNhanVien.Focus();
         

        }
        private void closeForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            closeForm();
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