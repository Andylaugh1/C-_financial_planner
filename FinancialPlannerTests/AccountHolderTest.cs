using FinancialPlanner.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialPlannerTests
{
    [TestClass]
    public class AccountHolderTest
    {
        AccountHolderDto AccountHolder1 = new AccountHolderDto("Andy", "Laughlin");

        [TestMethod]
        public void CanGetAccountHolderProperties()
        {
            Assert.AreEqual("Andy", AccountHolder1.FirstName);
            Assert.AreEqual("Laughlin", AccountHolder1.Surname);
        }
    }
}
