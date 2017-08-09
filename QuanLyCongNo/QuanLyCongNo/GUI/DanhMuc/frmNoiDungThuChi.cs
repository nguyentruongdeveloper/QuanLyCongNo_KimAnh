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
    public partial class frmNoiDungThuChi : frmDanhMuc_Base
    {
        CNoi_Dung_Thu_Chi_Controller _NoiDungThuChu_Ctrl = CNoi_Dung_Thu_Chi_Controller.getInstance();
        
        public frmNoiDungThuChi()
        {
            InitializeComponent();
        }

        private void frmNoiDungThuChi_Load(object sender, EventArgs e)
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
            col_LoaiThuChi.FieldName = "Ten_Loai";
            col_NoiDung.FieldName = "Noi_Dung";
        }
       
        protected override void loadData(int Auto_ID)
        {
            try
            {
                myGrid.DataSource = _NoiDungThuChu_Ctrl.List_Noi_Dung_Thu_Chi();
            }
            catch (Exception ex)
            {
                CExtensions.showErrorException(ex, "Lỗi nạp dữ liệu");
            }

        }
        protected override void Add()
        {
            using (frmChiTietNoiDungThuChi frm = new frmChiTietNoiDungThuChi())
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
        private void Update_Entity()
        {
            if (myGridView1.RowCount > 0 && myGridView1.FocusedRowHandle >= 0)
            {
                try
                {
                    using (var _frm = new frmChiTietNoiDungThuChi())
                    {

                        CNoi_Dung_Thu_Chi v_objNoiDungThuChi = (CNoi_Dung_Thu_Chi)myGridView1.GetFocusedRow();
                        _frm._objNoiDungThuChi = v_objNoiDungThuChi;
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
                    CNoi_Dung_Thu_Chi v_objNoiDungThuChi = (CNoi_Dung_Thu_Chi)myGridView1.GetFocusedRow();
                    if (v_objNoiDungThuChi != null)
                    {
                        _NoiDungThuChu_Ctrl.Delete_Noi_Dung_Thu_Chi(v_objNoiDungThuChi.Auto_ID, "Admin");
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
        protected override void Close()
        {
            base.Close();
        }
    }
}