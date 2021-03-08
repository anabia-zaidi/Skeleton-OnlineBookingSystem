using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstEmployeeId
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsEmployeeId AnEmployeeId = new clsEmployeeId();
            // test to see that it exists
            Assert.IsNotNull(AnEmployeeId);
        }
    }
}
