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

        public string Valid(string serviceName, string staff, string price, string duration)
        {
            throw new NotImplementedException();
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
             public string Valid(string ServiceName, string Staff, string Price, string Duration, string Discount)
            {
            String Error = "";
            if (ServiceName.Length == 0)
            {
                Error = Error + "The Service Name may not be blank : ";
            }
            if (ServiceName.Length > 50)
            {
                Error = Error + "The Service Name must be less than 50 characters : ";
            }
            
            if (Staff.Length == 0)
            {
                //record the error
                Error = Error + "The Staff may not be blank : ";
            }
           
            if (Staff.Length > 50)
            {
                //record the error
                Error = Error + "The Staff must be less than 50 characters : ";
            }
            
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "The Price may not be blank : ";
            }
            
            if (Price.Length > 10)
            {
                //record the error
                Error = Error + "The Price must be less than 10 characters : ";
            }
            
            if (Duration.Length == 0)
            {
                //record the error
                Error = Error + "The duration may not be blank : ";
            }
            
            if (Duration.Length > 50)
            {
                //record the error
                Error = Error + "The duration must be less than 50 characters : ";
            }
            if (Discount.Length == 0)
            {
                //record the error
                Error = Error + "The discount may not be blank : ";
            }

            if (Discount.Length > 50)
            {
                //record the error
                Error = Error + "The discount must be less than 50 characters : ";
            }
                //return any error messages
                return Error;

            }
        } }
    
