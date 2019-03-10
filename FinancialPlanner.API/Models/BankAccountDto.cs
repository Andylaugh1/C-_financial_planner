using FinancialPlanner.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPlanner.API.Models
{
    public class BankAccountDto
    {
        public int id { get; set; }
        public string accountName { get; set; }
        public BankAccountType accountType { get; set; }
        public List<TransactionDto> transactions { get; set; } = new List<TransactionDto>();
        public int accountHolderId { get; set; }
        public int accountNumber { get; set; }
        public int sortCode { get; set; }
        public double balance { get; set; }

        public BankAccountDto(string accountName, BankAccountType accountType)
        {
            this.id = id;
            this.accountName = accountName;
            this.accountType = accountType;
            this.transactions = transactions;
            this.accountHolderId = accountHolderId;
            this.accountNumber = accountNumber;
            this.sortCode = sortCode;
            this.balance = balance;
        }

        public List<int> GetAllTransactionIds()
        {
            var transactionIds = new List<int>();
            foreach (TransactionDto transaction in this.transactions)
            {
                if (transaction.id != null)
                {
                    transactionIds.Add(transaction.id);
                }
            }

            return transactionIds;
        }

        public bool CheckForTransactionInAccount(TransactionDto requestedTransaction)
        {
            var requestedId = requestedTransaction.id;
            foreach (TransactionDto transaction in this.transactions)
            {
                if (transaction.id == requestedId)
                {
                    return true;
                }
            }
            return false;
        }

        public TransactionDto GetTransactionById(int id)
        {
            foreach (TransactionDto transaction in this.transactions)
            {
                if (transaction.id == id)
                {
                    return transaction;
                }
            }
            return null;
        }

        public void AddNewTransactionToAccount(TransactionDto transaction)
        {
            this.transactions.Add(transaction);
        }

        public void UpdateBalance(double amount)
        {
            double newBalance = this.balance += amount;
            this.balance = newBalance;
        }

        //Checks if the transaction is positive or negative and then calls the updateBalance and AddToAccountMethods
        public void ProcessTransactionOnAccount(TransactionDto transaction)
        {
            var transactionAmount = transaction.value;
            var positiveOrNegativeAmount = 0.00;
            if (transaction.isPositive == true)
            {
                positiveOrNegativeAmount = transactionAmount;
            }
            else
            {
                positiveOrNegativeAmount = (-transactionAmount);
            }

            this.UpdateBalance(positiveOrNegativeAmount);
            this.AddNewTransactionToAccount(transaction);
        }
    }
}
