using FinancialPlanner.API.Enums;
using FinancialPlanner.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialPlannerTests
{
    public class BankAccountTest
    {
        BankAccountDto Account1 = new BankAccountDto("Andy Current Account", BankAccountType.IND_CURRENT_ACCOUNT);
        TransactionDto transaction1 = new TransactionDto();

        [TestMethod]
        public void CanGetBankAccountProperties()
        {
            Account1.AccountNumber = 12345678;
            Account1.SortCode = 123456;
            Assert.AreEqual("Current Account", Account1.AccountName);
            Assert.AreEqual(12345678, Account1.AccountNumber);
            Assert.AreEqual(BankAccountType.IND_CURRENT_ACCOUNT, Account1.AccountType);
            Assert.AreEqual(123456, Account1.SortCode);
        }
    }
}
