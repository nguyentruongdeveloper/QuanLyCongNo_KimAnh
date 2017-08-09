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
    public class CXe_Controller
    {
        private static CXe_Controller Instance { get; set; }
        public static CXe_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CXe_Controller();
            return Instance;
        }
        private void MapXe(DataRow p_row, CXe p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("So_Xe"))
                p_objDes.So_Xe = CUtility.Convert_To_String(p_row["So_Xe"]);

            if (p_dt.Columns.Contains("Ten_Xe"))
                p_objDes.Ten_Xe = CUtility.Convert_To_String(p_row["Ten_Xe"]);

            if (p_dt.Columns.Contains("Trong_Tai"))
                p_objDes.Trong_Tai = CUtility.Convert_To_String(p_row["Trong_Tai"]);

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

            if (p_dt.Columns.Contains("Ghi_Chu"))
                p_objDes.Ghi_Chu = CUtility.Convert_To_String(p_row["Ghi_Chu"]);
        }

        public IList<CXe> List_Xe()
        {
            IList<CXe> v_arrRes = new List<CXe>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Xe");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXe v_objRes = new CXe();
                    MapXe(v_row, v_objRes);
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

        public CXe Get_Xe_By_ID(int p_iID)
        {
            CXe v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Xe_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CXe();
                    MapXe(v_dt.Rows[0], v_objRes);
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

        public int Insert_Xe(CXe p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Xe",
                    p_objData.So_Xe, p_objData.Ten_Xe, p_objData.Trong_Tai, p_objData.Last_Updated_By, p_objData.Ghi_Chu));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Xe(CXe p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Xe", p_objData.Auto_ID,
                    p_objData.So_Xe, p_objData.Ten_Xe, p_objData.Trong_Tai, p_objData.Last_Updated_By, p_objData.Ghi_Chu);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Xe(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Xe", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
