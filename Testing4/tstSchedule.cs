using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstSchedule
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSchedule ABooking = new clsSchedule();
            Assert.IsNotNull(ABooking);
        }
    }
}
