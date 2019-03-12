using FinancialPlanner.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinancialPlannerTests
{
    [TestClass]
    public class TransactionTest
    {
        private Transaction transaction1;

        [TestInitialize]
        public void Init()
        {
            transaction1 = new Transaction(24.99, true, "Amazon");
            transaction1.name = "Amazon Order";
        }

        [TestMethod]
        public void CanGetTransactionValueProperties()
        {
            Assert.AreEqual(24.99, transaction1.value);
            Assert.AreEqual(true, transaction1.isPositive);
            Assert.AreEqual("Amazon Order", transaction1.name);
            Assert.AreEqual("Amazon", transaction1.party);
        }
    }
}
