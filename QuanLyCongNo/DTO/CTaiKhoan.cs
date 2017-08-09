using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO
{
    public class CTai_Khoan
    {
        private int m_intAuto_ID;
        private int m_intNhan_Vien_ID;
        private string m_strTai_Khoan;
        private string m_strMat_Khau;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;

        public CTai_Khoan()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_intNhan_Vien_ID = CConst.INT_VALUE_NULL;
            m_strTai_Khoan = CConst.STR_VALUE_NULL;
            m_strMat_Khau = CConst.STR_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
        }

        public int Auto_ID
        {
            get
            {
                return m_intAuto_ID;
            }
            set
            {
                m_intAuto_ID = value;
            }
        }

        public int Nhan_Vien_ID
        {
            get
            {
                return m_intNhan_Vien_ID;
            }
            set
            {
                m_intNhan_Vien_ID = value;
            }
        }

        public string Tai_Khoan
        {
            get
            {
                return m_strTai_Khoan;
            }
            set
            {
                m_strTai_Khoan = value.Trim();
            }
        }

        public string Mat_Khau
        {
            get
            {
                return m_strMat_Khau;
            }
            set
            {
                m_strMat_Khau = value.Trim();
            }
        }

        public DateTime Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }

        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }

        public DateTime Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }

        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }

        public bool Deleted
        {
            get
            {
                return m_blnDeleted;
            }
            set
            {
                m_blnDeleted = value;
            }
        }
    }
}
