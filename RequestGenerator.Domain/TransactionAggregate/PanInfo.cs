using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.TransactionAggregate
{
    public class PanInfo
    {
        public string Pan { get; set; }
        public string PanMasked { get; set; }
        public string Cvv { get; set; }
        public string Expiry { get; set; }
    }
}
