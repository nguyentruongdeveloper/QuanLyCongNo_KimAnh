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
    public class CDich_Vu_Controller
    {
        private static CDich_Vu_Controller Instance { get; set; }
        public static CDich_Vu_Controller getInstance ()
        {
            if (Instance == null)
                Instance = new CDich_Vu_Controller();
            return Instance;
        }
        private void MapDich_Vu(DataRow p_row, CDich_Vu p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Dich_Vu"))
                p_objDes.Ma_Dich_Vu = CUtility.Convert_To_String(p_row["Ma_Dich_Vu"]);

            if (p_dt.Columns.Contains("Ten_Dich_Vu"))
                p_objDes.Ten_Dich_Vu = CUtility.Convert_To_String(p_row["Ten_Dich_Vu"]);

            if (p_dt.Columns.Contains("Dien_Giai"))
                p_objDes.Dien_Giai = CUtility.Convert_To_String(p_row["Dien_Giai"]);

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

        public IList<CDich_Vu> List_Dich_Vu()
        {
            IList<CDich_Vu> v_arrRes = new List<CDich_Vu>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Dich_Vu");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDich_Vu v_objRes = new CDich_Vu();
                    MapDich_Vu(v_row, v_objRes);
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

        public CDich_Vu Get_Dich_Vu_By_ID(int p_iID)
        {
            CDich_Vu v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Dich_Vu_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDich_Vu();
                    MapDich_Vu(v_dt.Rows[0], v_objRes);
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

        public int Insert_Dich_Vu(CDich_Vu p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Dich_Vu",
                    p_objData.Ma_Dich_Vu, p_objData.Ten_Dich_Vu, p_objData.Dien_Giai, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Dich_Vu(CDich_Vu p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Dich_Vu", p_objData.Auto_ID,
                    p_objData.Ma_Dich_Vu, p_objData.Ten_Dich_Vu, p_objData.Dien_Giai, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Dich_Vu(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Dich_Vu", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
