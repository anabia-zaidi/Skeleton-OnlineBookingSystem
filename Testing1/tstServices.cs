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
    }
}
