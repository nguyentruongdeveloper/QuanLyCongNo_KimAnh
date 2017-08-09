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
    public partial class frmChiTietNoiDungThuChi : DevExpress.XtraEditors.XtraForm
    {
        public FormType fType { get; set; }
        private CNoi_Dung_Thu_Chi_Controller _NoiDungThuChi_Ctrl = CNoi_Dung_Thu_Chi_Controller.getInstance();
        public delegate void LoadData(int strKey);
        public LoadData ReLoadParent;
        public CNoi_Dung_Thu_Chi _objNoiDungThuChi { get; set; }
        public frmChiTietNoiDungThuChi()
        {
            InitializeComponent();
        }

        private void frmChiTietNoiDungThuChi_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới nội dung thu chi";
                _objNoiDungThuChi = new CNoi_Dung_Thu_Chi();


            }
            else
            {
                this.Text = "Sửa thông tin nội dung thu chi";
                getDataFromEntity();
            }

        }
        private void loadRepository()
        {
            LoadRepository_LoaiThuChi();

        }
        private void LoadRepository_LoaiThuChi()
        {
            CLoai_Thu_Chi_Controller LoaiThiChu_Ctrl = CLoai_Thu_Chi_Controller.getInstance();
            slok_LoaiThuChi.Properties.DataSource = LoaiThiChu_Ctrl.List_Loai_Thu_Chi();
            slok_LoaiThuChi.Properties.DisplayMember = "MaLoai";
            slok_LoaiThuChi.Properties.ValueMember = "Auto_ID";

        }
        private void getDataFromEntity()
        {
            slok_LoaiThuChi.EditValue = _objNoiDungThuChi.Loai_Thu_Chi_ID;
            txt_GhiChu.Text = _objNoiDungThuChi.Noi_Dung;


        }
        private void setDataToEntity()
        {
            _objNoiDungThuChi.Loai_Thu_Chi_ID = CUtility.Convert_To_Int32( slok_LoaiThuChi.EditValue);
            _objNoiDungThuChi.Noi_Dung = txt_GhiChu.Text;
          

        }
        private bool saveData()
        {
            bool v_blResult = true;
            setDataToEntity();

            if (fType == FormType.Add)
            {
                try
                {
                    _NoiDungThuChi_Ctrl.Insert_Noi_Dung_Thu_Chi(_objNoiDungThuChi);
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
                    _NoiDungThuChi_Ctrl.Update_Noi_Dung_Thu_Chi(_objNoiDungThuChi);
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
            slok_LoaiThuChi.EditValue = 0;
            txt_GhiChu.Text = "";
            slok_LoaiThuChi.Focus();
            

        }
        private void closeForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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