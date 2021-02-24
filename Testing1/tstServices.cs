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
    }
}