using FinancialPlanner.API.Enums;
using FinancialPlanner.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialPlannerTests
{
    [TestClass]
    public class BankAccountTest
    {
        BankAccount testAccount;
        Transaction testTransaction1;
        Transaction testTransaction2;
        AccountHolder testAccountHolder1;

        [TestInitialize]
        public void Initialize()
        {
            testTransaction1 = new Transaction(24.99, true, "Amazon");
            testTransaction2 = new Transaction(20.00, true, "Work");
            testTransaction1.id = 1;
            testTransaction2.id = 2;

            testAccountHolder1 = new AccountHolder("Andy", "Laughlin");
            testAccountHolder1.id = 12;

            testAccount = new BankAccount("Andy Current Account", BankAccountType.IND_CURRENT_ACCOUNT);
            testAccount.accountHolderId = testAccountHolder1.id;
            testAccount.accountNumber = 12345678;
            testAccount.sortCode = 123456;
            testAccount.transactions.Add(testTransaction1);
            testAccount.transactions.Add(testTransaction2);
            testAccount.balance = 100.00;
        }
        

        [TestMethod]
        public void CanGetBankAccountProperties()
        { 
            Assert.AreEqual("Andy Current Account", testAccount.accountName);
            Assert.AreEqual(12345678, testAccount.accountNumber);
            Assert.AreEqual(BankAccountType.IND_CURRENT_ACCOUNT, testAccount.accountType);
            Assert.AreEqual(123456, testAccount.sortCode);
            Assert.AreEqual(100.00, testAccount.balance);
        }

        [TestMethod]
        public void CanGetBankAccountTransactionIds()
        {
            var transactionIds = new List<int>();
            transactionIds = testAccount.GetAllTransactionIds();
            var result = transactionIds.Count;
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CanCheckIfTransactionIsInThisAccount_true()
        {
            var result = testAccount.CheckForTransactionInAccount(testTransaction1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CanGetTransactionById_transactionPresent()
        {
            var returnedTransaction = testAccount.GetTransactionById(testTransaction1.id);
            var result = returnedTransaction.id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CanUpdateBalanceFollowingTransaction()
        {
            var amount = testTransaction1.value;
            testAccount.UpdateBalance(amount);
            Assert.AreEqual(124.99, testAccount.balance);
        }

        [TestMethod]
        public void CanProcessTransactionWhen_TransactionPositive()
        {
            var testTransaction3 = new Transaction(20.00, true, "Work");
            testTransaction3.id = 3;
            testAccount.ProcessTransactionOnAccount(testTransaction3);

            var result1 = testAccount.GetTransactionById(testTransaction3.id);
            var result2 = testAccount.balance;

            Assert.AreEqual(3, result1.id);
            Assert.AreEqual(120.00, result2);
        }

        [TestMethod]
        public void CanProcessTransactionWhen_TransactionNegative()
        {
            var testTransaction3 = new Transaction(20.00, false, "Work");
            testTransaction3.id = 3;
            testAccount.ProcessTransactionOnAccount(testTransaction3);

            var result1 = testAccount.GetTransactionById(testTransaction3.id);
            var result2 = testAccount.balance;

            Assert.AreEqual(3, result1.id);
            Assert.AreEqual(80.00, result2);
        }
    }
}
