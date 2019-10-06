using FinancialPlanner.API.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPlanner.API.Service_Layer
{
    public class MainService : IMainService
    {
        public IMainRepository Repo { get; set; }

        public MainService(IMainRepository repo)
        {
            this.Repo = repo;
        }
    }
}
