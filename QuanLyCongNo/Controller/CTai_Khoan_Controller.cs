using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataPlayer;
using Utility;
using System.Data;
namespace Controller
{
    public class CTai_Khoan_Controller
    {
        private static CTai_Khoan_Controller Instance { get; set; }
        public static CTai_Khoan_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CTai_Khoan_Controller();
            return Instance;
        }
        private void MapTai_Khoan(DataRow p_row, CTai_Khoan p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Nhan_Vien_ID"))
                p_objDes.Nhan_Vien_ID = CUtility.Convert_To_Int32(p_row["Nhan_Vien_ID"]);

            if (p_dt.Columns.Contains("Tai_Khoan"))
                p_objDes.Tai_Khoan = CUtility.Convert_To_String(p_row["Tai_Khoan"]);

            if (p_dt.Columns.Contains("Mat_Khau"))
                p_objDes.Mat_Khau = CUtility.Convert_To_String(p_row["Mat_Khau"]);

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

        public IList<CTai_Khoan> List_Tai_Khoan()
        {
            IList<CTai_Khoan> v_arrRes = new List<CTai_Khoan>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Tai_Khoan");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CTai_Khoan v_objRes = new CTai_Khoan();
                    MapTai_Khoan(v_row, v_objRes);
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

        public CTai_Khoan Get_Tai_Khoan_By_ID(int p_iID)
        {
            CTai_Khoan v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Tai_Khoan_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CTai_Khoan();
                    MapTai_Khoan(v_dt.Rows[0], v_objRes);
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

        public int Insert_Tai_Khoan(CTai_Khoan p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Tai_Khoan",
                    p_objData.Nhan_Vien_ID, p_objData.Tai_Khoan, p_objData.Mat_Khau, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Tai_Khoan(CTai_Khoan p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Tai_Khoan", p_objData.Auto_ID,
                    p_objData.Nhan_Vien_ID, p_objData.Tai_Khoan, p_objData.Mat_Khau, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Tai_Khoan(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Tai_Khoan", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
