using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsServices
    {
        private Boolean mDiscount;

        public bool Discount
        {
            get
            {
                return mDiscount;
            }
            set
            {
                mDiscount = value;
            }
        }

        private Int32 mDuration;

        public int Duration
        {
            get
            {
                return mDuration;
            }
            set
            {
                mDuration = value;
            }
        }
        private Int32 mPrice;

  

        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(string serviceName)
        {
            throw new NotImplementedException();
        }

        private string mServiceName;

        public string ServiceName
        {
            get
            {
                return mServiceName;
            }
            set
            {
                mServiceName = value;
            }
        }
        private string mStaff;

        public string Staff
        {
            get
            {
                return mStaff;
            }
            set
            {
                mStaff = value;
            }
        }

        public bool Find(int Price)
        {
        

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ServiceName", ServiceName);
            DB.Execute("sproc_tblAddress_FilterbyServiceName");
            if (DB.Count == 1)
            {

              
                mServiceName = Convert.ToString(DB.DataTable.Rows[0]["ServiceName"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mDuration = Convert.ToInt32(DB.DataTable.Rows[0]["Duration"]);
                mDiscount = Convert.ToBoolean(DB.DataTable.Rows[0]["Eligibility of discount"]);

                mStaff = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                return true;
            }
            else
            {
                return false;
            }
            }
        }
    }
