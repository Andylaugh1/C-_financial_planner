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
        AccountHolderDto accountHolder1;

        [TestInitialize]
        public void initialize()
        {
            AccountHolderDto accountHolder1 = new AccountHolderDto("Andy", "Laughlin");
            accountHolder1.id = 10;
        }

        [TestMethod]
        public void CanGetAccountHolderProperties()
        {
            Assert.AreEqual("Andy", accountHolder1.firstName);
            Assert.AreEqual("Laughlin", accountHolder1.surname);
            Assert.AreEqual(10, accountHolder1.id);
        }
    }
}
