using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPlanner.API.Models
{
    public class AccountHolderDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public AccountHolderDto(string FirstName, string Surname)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.Surname = Surname;
        }
    }
}
