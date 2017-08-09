using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataPlayer;
using System.Data;
using Utility;


namespace Controller
{
    public class CDieu_Khoan_Thanh_Toan_Controller
    {
        private static CDieu_Khoan_Thanh_Toan_Controller Instance { get; set; }
        public static CDieu_Khoan_Thanh_Toan_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CDieu_Khoan_Thanh_Toan_Controller();
            return Instance;
        }
        private void MapDieu_Khoan_Thanh_Toan(DataRow p_row, CDieu_Khoan_Thanh_Toan p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("TenDieuKhoan"))
                p_objDes.TenDieuKhoan = CUtility.Convert_To_String(p_row["TenDieuKhoan"]);

            if (p_dt.Columns.Contains("Created"))
                p_objDes.Created = CUtility.Convert_To_DateTime(p_row["Created"]);

            if (p_dt.Columns.Contains("Created_By"))
                p_objDes.Created_By = CUtility.Convert_To_String(p_row["Created_By"]);

            if (p_dt.Columns.Contains("Last_Updated"))
                p_objDes.Last_Updated = CUtility.Convert_To_DateTime(p_row["Last_Updated"]);

            if (p_dt.Columns.Contains("Last_Updated_By"))
                p_objDes.Last_Updated_By = CUtility.Convert_To_String(p_row["Last_Updated_By"]);

            if (p_dt.Columns.Contains("Deleted"))
                p_objDes.Deleted = CUtility.Convert_To_Bool(p_row["Deleted"]);
        }

        public IList<CDieu_Khoan_Thanh_Toan> List_Dieu_Khoan_Thanh_Toan()
        {
            IList<CDieu_Khoan_Thanh_Toan> v_arrRes = new List<CDieu_Khoan_Thanh_Toan>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Dieu_Khoan_Thanh_Toan");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDieu_Khoan_Thanh_Toan v_objRes = new CDieu_Khoan_Thanh_Toan();
                    MapDieu_Khoan_Thanh_Toan(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CDieu_Khoan_Thanh_Toan Get_Dieu_Khoan_Thanh_Toan_By_ID(int p_iID)
        {
            CDieu_Khoan_Thanh_Toan v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Dieu_Khoan_Thanh_Toan_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDieu_Khoan_Thanh_Toan();
                    MapDieu_Khoan_Thanh_Toan(v_dt.Rows[0], v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

        public int Insert_Dieu_Khoan_Thanh_Toan(CDieu_Khoan_Thanh_Toan p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Dieu_Khoan_Thanh_Toan",
                    p_objData.TenDieuKhoan, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Dieu_Khoan_Thanh_Toan(CDieu_Khoan_Thanh_Toan p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Dieu_Khoan_Thanh_Toan", p_objData.Auto_ID,
                    p_objData.TenDieuKhoan, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Dieu_Khoan_Thanh_Toan(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Dieu_Khoan_Thanh_Toan", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
