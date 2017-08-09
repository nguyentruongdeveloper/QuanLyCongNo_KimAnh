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
using DTO;
using Controller;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.DanhMuc.Sub
{
    public partial class frmChiTietXe : DevExpress.XtraEditors.XtraForm
    {
        public FormType fType { get; set; }
        private CXe_Controller _Xe_Ctrl = CXe_Controller.getInstance();
        public delegate void LoadData(int strKey);
        public LoadData ReLoadParent;
        public CXe _objXe { get; set; }
        public frmChiTietXe()
        {
            InitializeComponent();
        }

        private void frmChiTietXe_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới thông tin xe";
                _objXe = new CXe();

            }
            else
            {
                this.Text = "Sửa thông tin xe";
                getDataFromEntity();
            }

        }
        private void getDataFromEntity()
        {
            txt_SoXe.Text = _objXe.So_Xe;
            txtTenXe.Text = _objXe.Ten_Xe;
            txt_TrongTai.Text = _objXe.Trong_Tai;
            txt_GhiChu.Text = _objXe.Ghi_Chu;



        }
        private void setDataToEntity()
        {
            _objXe.So_Xe = txt_SoXe.Text;
            _objXe.Ten_Xe = txtTenXe.Text;
            _objXe.Trong_Tai = txt_TrongTai.Text;
            _objXe.Ghi_Chu = txt_GhiChu.Text;



        }
        private bool saveData()
        {
            bool v_blResult = true;
            setDataToEntity();

            if (fType == FormType.Add)
            {
                try
                {
                    _Xe_Ctrl.Insert_Xe(_objXe);
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
                    _Xe_Ctrl.Update_Xe(_objXe);
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
            txt_SoXe.Text = "";
            txtTenXe.Text = "";
            txt_TrongTai.Text = "";
            txt_GhiChu.Text = "";
            txt_SoXe.Focus();

        }
        private void closeForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void btnLuuAndThemMoi_Click(object sender, EventArgs e)
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
    }
}