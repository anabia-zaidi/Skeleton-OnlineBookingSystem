using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class profitOrLoss
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProfitOrLoss AProfitOrLoss = new clsProfitOrLoss();
            //test to see if it exists
            Assert.IsNotNull(AProfitOrLoss);
        }
    }
}
