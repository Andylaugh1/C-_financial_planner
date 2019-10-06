using FinancialPlanner.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPlanner.API.Data_Access_Layer
{
    public interface IMainRepository
    {

        List<Transaction> GetAllTransactions();
        List<Transaction> GetTransactionsForIdSet(IList<int> idSet);
        Transaction GetTransactionById(int id);
    }
}
