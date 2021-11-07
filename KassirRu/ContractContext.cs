using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KassirRu
{
    class ContractContext : DbContext
    {
        public ContractContext() : base("KassirRuDB") { }
        public DbSet<Contract> Contracts { get; set; }
        public Contract FindContractWithID(int ID)
        {
            foreach (Contract contract in Contracts)
            {
                if (contract.Id == ID) return contract;
            }
            return null;
        }
    }
}
