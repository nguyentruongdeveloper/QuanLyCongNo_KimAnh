using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO
{
    public class CDich_Vu
    {
        private int m_intAuto_ID;
        private string m_strMa_Dich_Vu;
        private string m_strTen_Dich_Vu;
        private string m_strDien_Giai;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;

        public CDich_Vu()
        {
            ResetData();
        }
        public static CDich_Vu Instance { get; set; }
        public static CDich_Vu getInstace()
        {
            if (Instance == null)
                Instance = new CDich_Vu();
            return Instance;
        }

        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_strMa_Dich_Vu = CConst.STR_VALUE_NULL;
            m_strTen_Dich_Vu = CConst.STR_VALUE_NULL;
            m_strDien_Giai = CConst.STR_VALUE_NULL;
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

        public string Ma_Dich_Vu
        {
            get
            {
                return m_strMa_Dich_Vu;
            }
            set
            {
                m_strMa_Dich_Vu = value.Trim();
            }
        }

        public string Ten_Dich_Vu
        {
            get
            {
                return m_strTen_Dich_Vu;
            }
            set
            {
                m_strTen_Dich_Vu = value.Trim();
            }
        }

        public string Dien_Giai
        {
            get
            {
                return m_strDien_Giai;
            }
            set
            {
                m_strDien_Giai = value.Trim();
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
