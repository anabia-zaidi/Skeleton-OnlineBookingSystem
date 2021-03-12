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
            Int32 EmployeeId = 2501016;
            Found = AReport.Find(EmployeeId);
            Assert.IsTrue(Found);
        }
    }
}
