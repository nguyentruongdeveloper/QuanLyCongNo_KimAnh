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
using Controller;
using DTO;
using QuanLyCongNo.Extensions;



namespace QuanLyCongNo.GUI.DanhMuc
{
    public partial class frmCongNoDauKy : XtraForm
    {
        CCong_No_Dau_Ky_Khach_Hang_Controller _CongNoDauKy_Ctrl = CCong_No_Dau_Ky_Khach_Hang_Controller.getInstance();
        private List<CCong_No_Dau_Ky_Khach_Hang> _arrCongNoDauKyKhachHang;

        public List<CCong_No_Dau_Ky_Khach_Hang> ListCongNoDauKyKhachHang
        {
            get { return _arrCongNoDauKyKhachHang; }
            set { _arrCongNoDauKyKhachHang = value; }
        }


        public frmCongNoDauKy()
        {
            InitializeComponent();
        }

        private void frmCongNoDauKy_Load(object sender, EventArgs e)
        {
            CustomFrom();
            loadDataForm();
            

        }
        private void CustomFrom()
        {
            formatControl();
            loadFieldName_Grid();
        }
        private void loadFieldName_Grid()
        {
            col_Auto_ID.FieldName = "Auto_ID";
            col_MaKhachHang.FieldName = "Ma_Khach_Hang";
            col_TenKhachHang.FieldName = "Ten_Khach_Hang";
            col_TienNo.FieldName = "Tien_No";
            col_DienGiai.FieldName = "Dien_Giai";

        }

        private void formatControl()
        {
            res_sp_TienNo.Format(2,false, true, true);
        }

        private void loadDataForm()
        {
           _arrCongNoDauKyKhachHang = _CongNoDauKy_Ctrl.List_Cong_No_Dau_Ky_Khach_Hang().ToList();
            myGrid1.DataSource = _arrCongNoDauKyKhachHang;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(SaveData())
            {
                CExtensions.showConfirmMessage("Lưu dữ liệu thành công!");
            }
        }
        private bool SaveData()
        {
            bool v_blResult = true;
            try
            {

                foreach(CCong_No_Dau_Ky_Khach_Hang v_obj in _arrCongNoDauKyKhachHang)
                { 
            
                    if (v_obj.Auto_ID > 0)
                    {
                        _CongNoDauKy_Ctrl.Update_Cong_No_Dau_Ky_Khach_Hang(v_obj);
                    }
                    if (v_obj.Auto_ID == 0)
                    {
                        _CongNoDauKy_Ctrl.Insert_Cong_No_Dau_Ky_Khach_Hang(v_obj);

                    }
                }
            }
            catch(Exception ex)
            {
                CExtensions.showErrorException(ex, "Error!");
                v_blResult = false;
            }
            return v_blResult;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataForm();
        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }
    }
}