using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPlanner.API.Models
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public bool IsPositive { get; set; }
        public string Name { get; set; }
        public string Party { get; set; }

        public TransactionDto()
        {
            this.Id = Id;
            this.Value = Value;
            this.IsPositive = IsPositive;
            this.Name = Name;
            this.Party = Party;
        }
    }
}
