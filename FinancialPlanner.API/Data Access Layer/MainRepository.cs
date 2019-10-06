using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialPlanner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancialPlanner.API.Data_Access_Layer
{
    public class MainRepository : IMainRepository
    {

        public MainRepository()
        {
        }

        public virtual List<Transaction> GetAllTransactions()
        {
            using (var cnt = new FinancialPlannerContext())
            {
                return cnt.Transactions.ToList();
            }
        }

        public virtual Transaction GetTransactionById(int transactionId)
        {
            using (var cnt = new FinancialPlannerContext())
            {
                Transaction transaction;
                transaction = cnt.Transactions.Where(t => t.Id == transactionId).FirstOrDefault();
                return transaction;
            }
        }

        public virtual List<Transaction> GetTransactionsForIdSet(IList<int> transactionIds)
        {
            using(var cnt = new FinancialPlannerContext())
            {
                var transactionsToReturn = new List<Transaction>();
                foreach(var transactionId in transactionIds)
                {
                    transactionsToReturn.Add(cnt.Transactions.Where(t => t.Id == transactionId).FirstOrDefault());
                }
                return transactionsToReturn;
            }
        }
    }
}
