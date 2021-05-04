using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstReports

    {

        //good test data
        //create some test data to pass to the method
        string EmployeeName = "Akshay";
        string Total = "1000";
        string Expenses = "500";
        string DateAdded = DateTime.Now.Date.ToString();

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

       // [TestMethod]
       // public void TestProfitOrLossFound()
        //{
        //    clsReports AReport = new clsReports();
        //    Boolean Found = false;
        //    Boolean OK = true;
        //    Boolean ProfitOrLoss = true;
        //    Found = AReport.Find(ProfitOrLoss);
        //    if (AReport.ProfitOrLoss != false)
         //   {
         //       OK = false;
        //    }
         //   Assert.IsTrue(OK);
        //}


        [TestMethod]
        public void ValidMethodOK()
        {
            clsReports AReport = new clsReports();

            //String variable to store any error message
            String Error = "";

            //invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeeNamedMinLessOne()
        {
            clsReports AReport = new clsReports();
            
            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = ""; //this should trigger an error

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses,  DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMin()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "a"; //this should be ok

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeNamePlusOne()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "aa"; //this should be ok

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses,DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMaxLessOne()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMax()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeNameMid()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMaxPlusOne()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void EmployeeNameExtremeMax()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string EmployeeName = "";
            EmployeeName = EmployeeName.PadRight(500, 'a'); //this should fail

            //invoking the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to string variable
            String DateAdded = TestDate.ToString();

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-1);

            //convert the date variable to string variable
            String DateAdded = TestDate.ToString();

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to string variable
            String DateAdded = TestDate.ToString();

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 1
            TestDate = TestDate.AddYears(1);

            //convert the date variable to string variable
            String DateAdded = TestDate.ToString();

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to string variable
            String DateAdded = TestDate.ToString();

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsReports AReport = new clsReports();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to non date value
            string DateAdded = "This is not a date!";
            
            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);
           
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TotalMinLessOne()
        {
            clsReports AReport = new clsReports();

            //string to store the error message
            String Error = "";

            //set the Total to less 1
            string Total = "-1"; //This should pass

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);
           
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMin()
        {
            clsReports AReport = new clsReports();

            //string to store the error message
            String Error = "";

            //set the Total to 0
            string Total = "0"; //This should pass

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);
           
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TotalMinPlusOne()
        {
            clsReports AReport = new clsReports();

            //string to store the error message
            String Error = "";

            //set the Total to plus 1
            string Total = "1"; //This should pass

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);
           
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ExpensesLessOne()
        {
            clsReports AReport = new clsReports();

            //string to store the error message
            String Error = "";

            //set the Expenses to less 1
            string Expenses = "-1"; //This should fail

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMin()
        {
            clsReports AReport = new clsReports();

            //string to store the error message
            String Error = "";

            //set Expenses to 0
            string Total = "0"; //This should pass

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesPlusOne()
        {
            clsReports AReport = new clsReports();

            //string to store the error message
            String Error = "";

            //set the Expenses to plus 1
            string Total = "1"; //This should pass

            //Invoke the method
            Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
    }     
}
