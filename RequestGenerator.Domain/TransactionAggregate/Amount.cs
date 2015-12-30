using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.TransactionAggregate
{
    public class Amount
    {
        public decimal AmountTotal { get; set; }
        public string CurrencyCode { get; set; }
    }
}
