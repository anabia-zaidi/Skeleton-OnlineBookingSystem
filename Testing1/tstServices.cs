using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstServices
    {
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
    }
}