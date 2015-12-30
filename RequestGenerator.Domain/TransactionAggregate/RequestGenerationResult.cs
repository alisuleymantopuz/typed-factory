using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.TransactionAggregate
{
    public class RequestGenerationResult
    {
      public  string GeneratedResult { get; set; }
      public  CheckoutTransaction CheckoutTransaction { get; set; }
    }
}
