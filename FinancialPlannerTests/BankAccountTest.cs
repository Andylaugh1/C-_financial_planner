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
        BankAccountDto testAccount;
        TransactionDto testTransaction1;
        TransactionDto testTransaction2;
        AccountHolderDto testAccountHolder1;

        [TestInitialize]
        public void Initialize()
        {
            var testTransaction1 = new TransactionDto(24.99, false, "Amazon");
            var testTransaction2 = new TransactionDto(20.00, false, "Work");
            testTransaction1.id = 1;
            testTransaction2.id = 2;

            var testAccountHolder1 = new AccountHolderDto("Andy", "Laughlin");
            testAccountHolder1.id = 12;

            var testAccount = new BankAccountDto("Andy Current Account", BankAccountType.IND_CURRENT_ACCOUNT);
            testAccount.accountHolderId = testAccountHolder1.id;
            testAccount.accountNumber = 12345678;
            testAccount.sortCode = 123456;
            testAccount.transactions.Add(testTransaction1);
            testAccount.transactions.Add(testTransaction2);
        }
        

        [TestMethod]
        public void CanGetBankAccountProperties()
        { 
            Assert.AreEqual("Andy Current Account", testAccount.accountName);
            Assert.AreEqual(12345678, testAccount.accountNumber);
            Assert.AreEqual(BankAccountType.IND_CURRENT_ACCOUNT, testAccount.accountType);
            Assert.AreEqual(123456, testAccount.sortCode);
        }

        [TestMethod]
        public void CanGetBankAccountTransactionIds()
        {
            var transactionIds = new List<int>();
            transactionIds = testAccount.GetAllTransactionIds();
            var result = transactionIds.Count;
            Assert.AreEqual(2, result);
        }
    }
}
