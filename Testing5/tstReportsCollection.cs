using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstReportsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReportsCollection AllReports = new clsReportsCollection();

            //test to see that it exists
            Assert.IsNotNull(AllReports);
        }


        [TestMethod]
        public void ReportListOK()
        {
            clsReportsCollection AllReports = new clsReportsCollection();

            //create some test data to assign to the property
            //in this case data neeeds list of objects
            List<clsReports> TestList = new List<clsReports>();
            clsReports TestItem = new clsReports();
            //set its properties
            TestItem.ProfitOrLoss = true;
            TestItem.EmployeeId = 2;
            TestItem.EmployeeName = "Akshay";
            TestItem.Expenses = 200;
            TestItem.Total = 1000;

            //add item to test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllReports.ReportList = TestList;

            //test to see the two values are the same
            Assert.AreEqual(AllReports.ReportList, TestList);
      
        }

      
        [TestMethod]
        public void ThisReportPropertyOK()
        {
            clsReportsCollection AllReports = new clsReportsCollection();

            //create some test data to assign to the property
            clsReports TestReports = new clsReports();

            //set the properties of the test object
            TestReports.ProfitOrLoss = true;
            TestReports.EmployeeId = 2;
            TestReports.DateAdded = DateTime.Now.Date;
            TestReports.EmployeeName = "Akshay";
            TestReports.Expenses = 200;
            TestReports.Total = 1000;

            //assign the data to the property
            AllReports.ThisReport = TestReports;

            //test to see the two values are the same
            Assert.AreEqual(AllReports.ThisReport, TestReports);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsReportsCollection AllReports = new clsReportsCollection();

            //create some data to assign to the property , in this case the data needs to be a list of objects
            List<clsReports> TestList = new List<clsReports>();

            //add an item to the list and create the item of test data
            clsReports TestItem = new clsReports();
            
            //set the properties of the test object
            TestItem.ProfitOrLoss = true;
            TestItem.EmployeeId = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.EmployeeName = "Akshay";
            TestItem.Expenses = 200;
            TestItem.Total = 1000;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllReports.ReportList = TestList;

            //test to see that two values are the same
            Assert.AreEqual(AllReports.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsReportsCollection AllReports = new clsReportsCollection();

            //create the item of test data
            clsReports TestItem = new clsReports();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.ProfitOrLoss = true;
            TestItem.EmployeeId = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.EmployeeName = "Akshay";
            TestItem.Expenses = 200;
            TestItem.Total = 1000;

            //set ThisReports to the test data 
            AllReports.ThisReport = TestItem;

            //add the record
            PrimaryKey = AllReports.Add();

            //set the primary key of the test data
            TestItem.EmployeeId = PrimaryKey;

            //find the record
            AllReports.ThisReport.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllReports.ThisReport, TestItem);
        }


    }
}
