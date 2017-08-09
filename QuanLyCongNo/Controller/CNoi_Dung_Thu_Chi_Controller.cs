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
    public class CNoi_Dung_Thu_Chi_Controller
    {
        private static CNoi_Dung_Thu_Chi_Controller Instance { get; set; }
        public static CNoi_Dung_Thu_Chi_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CNoi_Dung_Thu_Chi_Controller();
            return Instance;
        }
        private void MapNoi_Dung_Thu_Chi(DataRow p_row, CNoi_Dung_Thu_Chi p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Loai_Thu_Chi_ID"))
                p_objDes.Loai_Thu_Chi_ID = CUtility.Convert_To_Int32(p_row["Loai_Thu_Chi_ID"]);

            if (p_dt.Columns.Contains("Noi_Dung"))
                p_objDes.Noi_Dung = CUtility.Convert_To_String(p_row["Noi_Dung"]);

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

            if (p_dt.Columns.Contains("Ten_Loai"))
                p_objDes.Ten_Loai = CUtility.Convert_To_String(p_row["Ten_Loai"]);

        }

        public IList<CNoi_Dung_Thu_Chi> List_Noi_Dung_Thu_Chi()
        {
            IList<CNoi_Dung_Thu_Chi> v_arrRes = new List<CNoi_Dung_Thu_Chi>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Noi_Dung_Thu_Chi");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CNoi_Dung_Thu_Chi v_objRes = new CNoi_Dung_Thu_Chi();
                    MapNoi_Dung_Thu_Chi(v_row, v_objRes);
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

        public CNoi_Dung_Thu_Chi Get_Noi_Dung_Thu_Chi_By_ID(int p_iID)
        {
            CNoi_Dung_Thu_Chi v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Noi_Dung_Thu_Chi_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CNoi_Dung_Thu_Chi();
                    MapNoi_Dung_Thu_Chi(v_dt.Rows[0], v_objRes);
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

        public int Insert_Noi_Dung_Thu_Chi(CNoi_Dung_Thu_Chi p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Noi_Dung_Thu_Chi",
                    p_objData.Loai_Thu_Chi_ID, p_objData.Noi_Dung, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Noi_Dung_Thu_Chi(CNoi_Dung_Thu_Chi p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Noi_Dung_Thu_Chi", p_objData.Auto_ID,
                    p_objData.Loai_Thu_Chi_ID, p_objData.Noi_Dung, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Noi_Dung_Thu_Chi(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Noi_Dung_Thu_Chi", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
