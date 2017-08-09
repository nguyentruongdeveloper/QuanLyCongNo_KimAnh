using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Utility;

namespace DTO
{
    public class CXe
    {
        private int m_intAuto_ID;
        private string m_strSo_Xe;
        private string m_strTen_Xe;
        private string m_strTrong_Tai;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;
        private string m_strGhi_Chu;

        public CXe()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_strSo_Xe = CConst.STR_VALUE_NULL;
            m_strTen_Xe = CConst.STR_VALUE_NULL;
            m_strTrong_Tai = CConst.STR_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
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

        public string So_Xe
        {
            get
            {
                return m_strSo_Xe;
            }
            set
            {
                m_strSo_Xe = value.Trim();
            }
        }

        public string Ten_Xe
        {
            get
            {
                return m_strTen_Xe;
            }
            set
            {
                m_strTen_Xe = value.Trim();
            }
        }

        public string Trong_Tai
        {
            get
            {
                return m_strTrong_Tai;
            }
            set
            {
                m_strTrong_Tai = value.Trim();
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

        public string Ghi_Chu
        {
            get
            {
                return m_strGhi_Chu;
            }
            set
            {
                m_strGhi_Chu = value.Trim();
            }
        }
    }
}