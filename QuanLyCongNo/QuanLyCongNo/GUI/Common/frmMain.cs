using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanLyCongNo.Extensions;
using QuanLyCongNo.GUI.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCongNo.Extensions.CExtensions;

namespace QuanLyCongNo.GUI.Common
{
    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            clsCallForm.InitFormCollection();
            loadDataForm();
            
        }
        private void loadDataForm()
        {
            addItemClick();
        }
        private void addDocument(DevExpress.XtraEditors.XtraForm _xtrForm)
        {
            if (_xtrForm == null) return;
            BaseDocument document = dcmMain.GetDocument(_xtrForm);
            if (document != null)
                tvMain.Controller.Activate(document);
            else
            {
                //_xtrForm.Text = _xtrForm.Text.Translation(_xtrForm.Name.Replace("_", ""), _xtrForm.Name);
                //_xtrForm.FormClosing += _xtrForm_FormClosing;
                //_xtrForm.Load += _traForm_Load;
                _xtrForm.MdiParent = this;
                _xtrForm.Show();
            }
        }
        private void addItemClick()
        {
            // Duyệt từng page trong ribbon
            foreach (RibbonPage page in ribbon.Pages)
            {
                //page.Visible = false;
                //page.Text = clsEntity.get_Caption(page.Name, ribbon.Name, page.Text);
                try
                {
                    foreach (RibbonPageGroup group in page.Groups)
                    {
                        //group.Visible = false;
                        //group.Text = clsEntity.get_Caption(group.Name, page.Name, group.Text);
                        foreach (var item in group.ItemLinks)
                        {
                            if (item is BarButtonItemLink)
                            {
                                BarButtonItemLink bbi = item as BarButtonItemLink;
                                bbi.Item.ItemClick += bt_ItemClick;
                            }

                            
                        }
                    }
                }
                catch { }
            }
        }

        private void bt_ItemClick(object sender, ItemClickEventArgs e)
        {

          
            if(e.Item.Name== "btn_HeThong_ThayDoiMatKhau" || e.Item.Name == "btn_HeThong_CongTy"
                ||e.Item.Name =="btn_Common_Login")
            {
                XtraForm frm = clsCallForm.CreateNewForm(e.Item.Name);
                frm.ShowDialog();

            }
            else
            {
                CExtensions.CallWaitForm(this);
                addDocument(clsCallForm.CreateNewForm(e.Item.Name));
                CExtensions.CloseWaitForm();

            }
         
        }

        private void btn_Main_HDDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btn_HeThong_ThongTinSuDung_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
