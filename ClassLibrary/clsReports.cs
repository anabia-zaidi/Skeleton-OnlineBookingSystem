using System;

namespace ClassLibrary
{
    public class clsReports
    {
        //dateAdded private member variable
        private DateTime mDateAdded;
        public DateTime DateAdded
        {

            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }



        private Int32 mEmployeeId;
        public Int32 EmployeeId
        {

            get
            {
                return mEmployeeId;
            }

            set
            {
                mEmployeeId = value;
            }
        }

        private Int32 mExpenses;
        public int Expenses
        {

            get
            {
                return mExpenses;
            }



            set
            {
                mExpenses = value;
            }
        }

        private Decimal mTotal;
        public decimal Total
        {

            get
            {
                return mTotal;
            }

            set
            {
                mTotal = value;
            }
        }


        private bool mProfitOrLoss;
        public bool ProfitOrLoss
        {

            get
            {
                return mProfitOrLoss;
            }

            set
            {
                mProfitOrLoss = value;
            }

        }


        private String mEmployeeName
        public string EmployeeName
        {

            get
            {
                return mEmployeeName;
            }


            set
            {
                mEmployeeName = value;
            }
        }

        public bool Find(int EmployeeId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add parameter to the employee id to search for
            DB.AddParameter("@EmployeeId", EmployeeId);

            //execute stored procedure
            DB.Execute("sproc_tblManagment_FilterByEmployeeId");


            //if the record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                //copy data from db to private data members
                mEmployeeId = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mExpenses = Convert.ToInt32(DB.DataTable.Rows[0]["Expenses"]);
                mTotal = Convert.ToInt32(DB.DataTable.Rows[0]["Total"]);
                mProfitOrLoss = Convert.ToBoolean(DB.DataTable.Rows[0]["ProfitOrLoss"]);
                mEmployeeName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeName"]);

                //if everything went ok return true
                return true;
            }

            //if no record found
            else
            {
                //return false indication a problem
                return false;
            }
        }
    }
}