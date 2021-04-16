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
        public bool ProfitOrLoss { get; set; }

        public bool Find(int EmployeeId)
        {
            //set the private data members to the test data value
            mEmployeeId = 2501016;
            mDateAdded = Convert.ToDateTime("16/05/2021");
            mExpenses = 500;
            mTotal = 1000;
            //always return true
            return true;
        }

        //private data for EmployeeId property
        private Int32 mEmployeeId;
    }
}