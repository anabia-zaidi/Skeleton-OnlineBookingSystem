using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework
{
    [TestClass]
    public class tstServicesCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsServicesCollection AllServices = new clsServicesCollection();
            Assert.IsNotNll(AllServices);
        }
        [TestMethod]
        public void ServiceListOK()
        {
            clsServicesCollection AllServices = new clsServicesCollection();
            List<clsServices> TestList = new List<clsServices>();
            clsServices Testitem = new clsServices();
            Testitem.Discount = true;
            Testitem.Duration = 1;
            Testitem.Price = 1;
            Testitem.Staff = "Emily";
            Testitem.ServiceName = "Haircut";
            TestList.Add(Testitem);
            AllServices.ServiceList = TestList;
            Assert.AreEqual(AllServices.ServiceList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsServicesCollection AllServices = new clsServicesCollection();
            UIntPtr SomeCount = 0;
            AllServices.Count = SomeCount;
            Assert.AreEqual(AllServices.Count, SomeCount);

        }
        [TestMethod]
        public void ThisServicePropertyOK()
        {
            clsServicesCollection AllServices = new clsServicesCollection();
            clsServices TestServices = new clsServices();
            TestService.Discount = true;
            TestService.Duration = 1;
            TestService.Price = 1;
            TestService.Staff = "Emily";
            TestService.ServiceName = "Haircut";

            AllServices.ThisService = TestService;
            Assert.AreEqual(AllServices.ThisService, TestService);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            clsServicesCollection AllServices = new clsServicesCollection();
            List<clsServices> TestList = new List<clsServices>();
            clsServices Testitem = new clsServices();
            Testitem.Discount = true;
            Testitem.Duration = 1;
            Testitem.Price = 1;
            Testitem.Staff = "Emily";
            Testitem.ServiceName = "Haircut";
            TestList.Add(Testitem);
            AllServices.ServiceList = TestList;
            Assert.AreEqual(AllServices.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPressent()
        {
            clsServicesCollection AllServices = new clsServicesCollection();
                Assert.areEqual(AllServices.Count, 2);
        }
    }
}