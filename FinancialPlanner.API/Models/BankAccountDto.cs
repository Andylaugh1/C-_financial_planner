using FinancialPlanner.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPlanner.API.Models
{
    public class BankAccountDto
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public BankAccountType AccountType { get; set; }
        public List<TransactionDto> Transactions { get; set; } = new List<TransactionDto>();
        public int AccountHolderId { get; set; }
        public int AccountNumber;
        public int SortCode;    
        
        public BankAccountDto(string AccountName, BankAccountType AccountType)
        {
            this.Id = Id;
            this.AccountName = AccountName;
            this.AccountType = AccountType;
            this.Transactions = Transactions;
            this.AccountHolderId = AccountHolderId;
            this.AccountNumber = AccountNumber;
            this.SortCode = SortCode;
        }
    }
}
