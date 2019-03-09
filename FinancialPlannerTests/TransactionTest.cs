using FinancialPlanner.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinancialPlannerTests
{
    [TestClass]
    public class TransactionTest
    {
        TransactionDto Transaction1 = new TransactionDto();

        [TestMethod]
        public void CanGetTransactionValueProperties()
        {
            Transaction1.Value = 24.99;
            Transaction1.IsPositive = true;
            Transaction1.Name = "Amazon Order";
            Transaction1.Party = "Amazon";
            Assert.AreEqual(24.99, Transaction1.Value);
            Assert.AreEqual(true, Transaction1.IsPositive);
            Assert.AreEqual("Amazon Order", Transaction1.Name);
            Assert.AreEqual("Amazon", Transaction1.Party);
        }
    }
}
