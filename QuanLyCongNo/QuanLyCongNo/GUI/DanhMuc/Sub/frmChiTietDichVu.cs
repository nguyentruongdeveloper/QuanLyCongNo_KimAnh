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
    public partial class frmChiTietDichVu : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public FormType fType { get; set; }
        private CDich_Vu_Controller _DichVu_Ctrl = CDich_Vu_Controller.getInstance();
        public delegate void LoadData(int strKey);
        public LoadData ReLoadParent;
        public CDich_Vu _objDichVu { get; set; }
        #endregion
        public frmChiTietDichVu()
        {
            InitializeComponent();
        }

        private void frmChiTietDichVu_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới thông tin dịch vụ";
                _objDichVu = new CDich_Vu();

            }
            else
            {
                this.Text = "Sửa thông tin dịch vụ";
                getDataFromEntity();
            }

        }
        private void getDataFromEntity()
        {
            txt_MaDichVu.Text = _objDichVu.Ma_Dich_Vu;
            txt_TenDichVu.Text = _objDichVu.Ten_Dich_Vu;
            txt_GhiChu.Text = _objDichVu.Dien_Giai;
        

        }
        private void setDataToEntity()
        {
            _objDichVu.Ma_Dich_Vu = txt_MaDichVu.Text;
            _objDichVu.Ten_Dich_Vu = txt_TenDichVu.Text;
            _objDichVu.Dien_Giai = txt_GhiChu.Text;
          


        }
        private bool saveData()
        {
            bool v_blResult = true;
            setDataToEntity();

            if (fType == FormType.Add)
            {
                try
                {
                    _DichVu_Ctrl.Insert_Dich_Vu(_objDichVu);
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
                    _DichVu_Ctrl.Update_Dich_Vu(_objDichVu);
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
            txt_MaDichVu.Text = "";
            txt_TenDichVu.Text = "";
            txt_GhiChu.Text = "";
          
            txt_MaDichVu.Focus();

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