﻿using System;
using System.Collections.Generic;

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


        private String mEmployeeName;
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

        public string Valid(string employeeId, string employeeName, string total, string expenses, string dateAdded)
        {
            return "";
        }

        public string Valid(string employeeName, string total, string expenses, string dateAdded)
        {
            //create  a string variable to store the error
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;

            //if EmployeeName is blank 
            if (employeeName.Length == 0)
            {
                //record the error
                Error = Error + "The Employee Name should not be blank : ";
            }

            //if the EmployeeName is greater than 50 characters
            if (employeeName.Length > 50)
            {
                Error = Error + "The EmployeeName should not be greater than 50 characters : ";
            }

            try
            {
                //copy the dateadded value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }

                // check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record an error message
                    Error = Error + "The date cannot be in future: ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }

            //if the expenses are less than 0
            if (Expenses > 0)
            {
                Error = Error + "Expenses should not be less than 0 ";
            }

                //return any error messages
                return Error;
            }
    }
           

    public class clsReportsCollection
    {

        //private data member for the list
        List<clsReports> mReportsList = new List<clsReports>();

        //private data member thisReport
        clsReports mThisReport = new clsReports();


        public clsReports ThisReport
        {
            get
            {
                //retunr the private data
                return mThisReport;
            }
            set
            {
                //set the private data
                mThisReport = value;
            }
        }

        List<clsReports> mReportList = new List<clsReports>();

        public void Update()
        {
            //update an existing record based on the values of thisReport
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("EmployeeId", mThisReport.EmployeeId);
            DB.AddParameter("EmployeeName", mThisReport.EmployeeName);
            DB.AddParameter("Total", mThisReport.Total);
            DB.AddParameter("Expenses", mThisReport.Expenses);
            DB.AddParameter("DateAdded", mThisReport.DateAdded);
            DB.AddParameter("ProfitOrLoss", mThisReport.ProfitOrLoss);

            //execute the stored procedure
            DB.Execute("sproc_tblManagmentTable_Update");
        }

        public List<clsReports> ReportList
        {

            get
            {
                //return the private data
                return mReportList;

            }


            set
            {
                mReportList = value;
            }
        }




        public int Count
        {


            get
            {
                //return the count of the list
                return mReportList.Count;
            }


            set
            {
               // do this later
            }
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisReport
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter ("@EmployeeId", mThisReport.EmployeeId);

            //execute the stored procedure
            DB.Execute("sproc_tblManagmentTable_Delete");
        }



        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the Index
            Int32 Index = 0;

            //var to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private array list
            mReportList = new List<clsReports>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsReports AReport = new clsReports();

                //read in the fields from the current record
                AReport.EmployeeId = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeId"]);
                AReport.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AReport.Total = Convert.ToInt32(DB.DataTable.Rows[Index]["Total"]);
                AReport.ProfitOrLoss = Convert.ToBoolean(DB.DataTable.Rows[Index]["ProfitOrLoss"]);
                AReport.EmployeeName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeName"]);

                //add the record to the private data member
                mReportList.Add(AReport);

                //point to the next record
                Index++;

            }
        }




        //constructor for the class
        public clsReportsCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblManagmentTable_SelectAll");

            //populate the arraylist with the data table
            PopulateArray(DB);

        }

        public void ReportByEmployeeName(string EmployeeName)
        {
            //filters the records based on full or partial employee name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //send the EmployeeName parameter to the database
            DB.AddParameter("@EmployeeName", EmployeeName);

            //execute the stored procedure
            DB.Execute("sproc_tblManagmentTable_FilterByEmployeeName");

            //populate array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisReport
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedures
            DB.AddParameter("EmployeeName", mThisReport.EmployeeName);
            DB.AddParameter("Total", mThisReport.Total);
            DB.AddParameter("Expenses", mThisReport.Expenses);
            DB.AddParameter("DateAdded", mThisReport.DateAdded);
            DB.AddParameter("ProfitOrLoss", mThisReport.ProfitOrLoss);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblManagmentTable_Insert");
        }
    }
}