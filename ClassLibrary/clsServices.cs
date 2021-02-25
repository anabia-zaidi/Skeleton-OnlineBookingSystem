using System;

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
            mPrice = 50;
            mDuration = 1;
            mDiscount = true;
            mServiceName = "Test Service Name";
            mStaff = "Test Staff";

            return true;
        }
    }
}