using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.TransactionAggregate
{
    public class BankInfo
    {
        public string Name { get; set; }
        public string ResourceName { get; set; }
        public string RequestGeneratorName { get; set; }
        public int UniqueId { get; set; }
    }
}
