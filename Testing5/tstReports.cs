using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstReports

    {

        [TestMethod]
        public void InstanceOK()
        {
            clsReports AReport = new clsReports();
            Assert.IsNotNull(AReport);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsReports AReport = new clsReports();

            //create some data to assign to the property

            DateTime TestData = DateTime.Now.Date;

            //assign data to property

            AReport.DateAdded = TestData;

            //testto see that two values are the same
            Assert.AreEqual(AReport.DateAdded, TestData);

        }

        [TestMethod]
        public void EmployeeIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsReports AReport = new clsReports();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AReport.EmployeeId = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AReport.EmployeeId, TestData);


        }


        [TestMethod]
        public void ExpensesPropertyOK()
        {
            //create an instance of the class we want to create
            clsReports AReport = new clsReports();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AReport.Expenses = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AReport.Expenses, TestData);
        }

        [TestMethod]
        public void EmployeeNameOK()
        {
            clsReports AReport = new clsReports();
            String TestData = "Akshay";
            AReport.EmployeeName = TestData;
            Assert.AreEqual(AReport.Total, TestData);
        }


        [TestMethod]
        public void TotalPropertyOK()
        {
            //create an instance of the class we want to create
            clsReports AReport = new clsReports();

            //create some test data to assign to the property
            decimal TestData = 1;

            //assign the data to the property
            AReport.Total = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AReport.Total, TestData);
        }


        [TestMethod]
        public void ProfitOrLossPropertyOK()
        {
            //create an instance of the class we want to create
            clsReports AReport = new clsReports();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AReport.ProfitOrLoss = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AReport.ProfitOrLoss, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            clsReports AReport = new clsReports();
            Boolean Found = false;
            Int32 EmployeeId = 2;
            Found = AReport.Find(EmployeeId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeIdNoFound()
        {
            clsReports AReport = new clsReports();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeId = 2;
            Found = AReport.Find(EmployeeId);
            //check the employee id
            if (AReport.EmployeeId != 2)
            {
                OK = false;
            }
            //test to see if that result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsReports AReport = new clsReports();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeId = 2;
            Found = AReport.Find(EmployeeId);
            //check the employee id
            if (AReport.DateAdded != Convert.ToDateTime("16/04/2021"))
            {
                OK = false;
            }
            //test to see if that result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestExpensesFound()
        {
            clsReports AReport = new clsReports();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeId = 2;
            Found = AReport.Find(EmployeeId);
            //check the employee id
            if (AReport.Expenses != 500)
            {
                OK = false;
            }
            //test to see if that result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalFound()
        {
            clsReports AReport = new clsReports();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeId = 2;
            Found = AReport.Find(EmployeeId);
            //check the employee id
            if (AReport.Total != 1000)
            {
                OK = false;
            }
            //test to see if that result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProfitOrLossFound()
        {
            clsReports AReport = new clsReports();
            Boolean Found = false;
            Boolean OK = true;
            Boolean ProfitOrLoss = true;
            Found = AReport.Find(ProfitOrLoss);
            if (AReport.ProfitOrLoss != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
