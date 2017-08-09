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
using QuanLyCongNo.Extensions;
using Controller;
using DTO;

namespace QuanLyCongNo.GUI.DanhMuc.Sub
{
    public partial class frmChiTietKhachHang : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public FormType fType { get; set; }
        private CKhach_Hang_Controller _KhachHang_Ctrl = CKhach_Hang_Controller.getInstance();
        public delegate void LoadData(int strKey);
        public LoadData ReLoadParent;
        public CKhach_Hang _objKhachHang { get; set; }

        #endregion
        public frmChiTietKhachHang()
        {
            InitializeComponent();
        }

        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
        {
            customFrom();
            loadDataFrom();
        }
        
        private void customFrom()
        {

        }
        private void loadDataFrom()
        {
            if(fType== FormType.Add)
            {
                this.Text = "Thêm mới thông tin khách hàng";
                _objKhachHang = new CKhach_Hang();
                

            }
            else
            {
                this.Text = "Sửa thông tin khách hàng";
                getDataFromEntity();
               
            }

        }
       
        private void getDataFromEntity()
        {
            txtMaKH.Text = _objKhachHang.Ma_Khach_Hang;
            txtTenKH.Text = _objKhachHang.Ten_Khach_Hang;
            txtMaSoThue.Text = _objKhachHang.Ma_So_Thue;
            txtSDT.Text = _objKhachHang.So_Dien_Thoai;
            txtDiaChi.Text = _objKhachHang.Dia_Chi;
            txtEmail.Text = _objKhachHang.Email;
        }
        private void setDataToEntity()
        {
            _objKhachHang.Ma_Khach_Hang = txtMaKH.Text;
            _objKhachHang.Ten_Khach_Hang = txtTenKH.Text;
            _objKhachHang.Ma_So_Thue = txtMaSoThue.Text;
            _objKhachHang.So_Dien_Thoai = txtSDT.Text;
            _objKhachHang.Dia_Chi = txtDiaChi.Text;
            _objKhachHang.Email = txtEmail.Text;

        }
        private bool saveData()
        {
            bool v_blResult = true;
            setDataToEntity();
          
            if(fType == FormType.Add)
            {
                try
                {
                    _KhachHang_Ctrl.Insert_Khach_Hang(_objKhachHang);
                }
                catch (Exception ex)
                {
                    v_blResult = false;
                    CExtensions.showErrorException(ex, "Error!");
                }
               

            }
            if(fType==FormType.Update)
            {
                try
                {
                    _KhachHang_Ctrl.Update_Khach_Hang(_objKhachHang);
                }
                catch(Exception ex)
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
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtMaSoThue.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtMaKH.Focus();

        }
        private void closeForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           if(validateForm())
            {
                if(saveData())
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