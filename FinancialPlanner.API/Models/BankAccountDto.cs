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
        public int accountNumber;
        public int sortCode;    
        
        public BankAccountDto(string accountName, BankAccountType accountType)
        {
            this.id = id;
            this.accountName = accountName;
            this.accountType = accountType;
            this.transactions = transactions;
            this.accountHolderId = accountHolderId;
            this.accountNumber = accountNumber;
            this.sortCode = sortCode;
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
    }
}
