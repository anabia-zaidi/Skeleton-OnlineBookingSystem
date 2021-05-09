using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstServices
    {
        string ServiceName = "Cut and Blowdry";
        string Staff = "Amy";
        string Price = "£25";
        string Duration = "1 hour";
        string Discount = "Yes";

        [TestMethod]
        public void InstanceOK()

        {
            clsServices AService = new clsServices();
            Assert.IsNotNull(AService);
        }


        [TestMethod]
        public void DiscountPropertyOK()
        {
            clsServices AService = new clsServices();
            Boolean TestData = true;
            AService.Discount = TestData;
            Assert.AreEqual(AService.Discount, TestData);

        }

        [TestMethod]
        public void ServiceNamePropertyOK()
        {
            clsServices AService = new clsServices();
            string TestData = "Cut and Blowdry";
            AService.ServiceName = TestData;
            Assert.AreEqual(AService.ServiceName, TestData);
        }
        [TestMethod]
        public void StaffPropertyOK()
        {
            clsServices AService = new clsServices();
            string TestData = "Amy";
            AService.Staff = TestData;
            Assert.AreEqual(AService.Staff, TestData);

        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsServices AService = new clsServices();
            Int32 TestData = 1;
            AService.Price = TestData;
            Assert.AreEqual(AService.Price, TestData);
        }

        [TestMethod]
        public void DurationPropertyOK()
        {
            clsServices AService = new clsServices();
            Int32 TestData = 1;
            AService.Duration = TestData;
            Assert.AreEqual(AService.Duration, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsServices AService = new clsServices();
            Boolean Found = false;
            Int32 Price = 50;
            Found = AService.Find(Price);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPriceNoFound()
        {
            clsServices AService = new clsServices();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Price = 50;
            Found = AService.Find(Price);
            if (AService.Price != 50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDurationFound()
        {
            clsServices AService = new clsServices();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Price = 50;
            Found = AService.Find(Price);
            if (AService.Duration != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestServiceNameFound()
        {
            clsServices AService = new clsServices();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Price = 50;
            Found = AService.Find(Price);
            if (AService.ServiceName != "Test Service Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffFound()
        {
            clsServices AService = new clsServices();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Price = 50;
            Found = AService.Find(Price);
            if (AService.Staff != "Test Staff")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDiscountFound()
        {
            clsServices AService = new clsServices();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Price = 50;
            Found = AService.Find(Price);
            if (AService.Discount != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsServices AService = new clsServices();
            String Error = "";
            Error = AService.Valid(ServiceName, Price, Duration, Discount, Staff);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ServiceNameMinLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = ""; //this should trigger an error

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ServiceNameMin()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";
            string ServiceName = "a";

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ServiceNamePlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = "aa"; //this should be ok

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ServiceNameMaxLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ServiceNameMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ServiceNameMid()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ServiceNameMaxPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void ServiceNameExtremeMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string ServiceName = "";
            ServiceName = ServiceName.PadRight(500, 'a'); //this should fail

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffMinLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = ""; //this should trigger an error

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffMin()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";
            string Staff = "a";

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "aa"; //this should be ok

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMaxLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMid()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffMaxPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void StaffExtremeMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "";
            Staff = Staff.PadRight(500, 'a'); //this should fail

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Price = ""; //this should trigger an error

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";
            string Price = "a";

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PricePlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Price = "aa"; //this should be ok

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void PriceExtremeMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Staff = "";
            Price = Price.PadRight(500, 'a'); //this should fail

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DurationMinLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = ""; //this should trigger an error

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DurationMin()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";
            string Duration = "a";

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DurationPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = "aa"; //this should be ok

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DurationMaxLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DurationMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DurationMid()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DurationMaxPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void DurationExtremeMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Duration = "";
            Duration = Duration.PadRight(500, 'a'); //this should fail

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMinLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = ""; //this should trigger an error

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountMin()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";
            string Discount = "a";

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DiscountPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = "aa"; //this should be ok

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountMaxLessOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountMid()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMaxPlusOne()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void DiscountExtremeMax()
        {
            clsServices AService = new clsServices();

            //string variable to store the error message
            String Error = "";

            //create some test data to pass the method
            string Discount = "";
            Discount = Discount.PadRight(500, 'a'); //this should fail

            //invoking the method
            Error = AService.Valid(ServiceName, Staff, Price, Duration, Discount);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}