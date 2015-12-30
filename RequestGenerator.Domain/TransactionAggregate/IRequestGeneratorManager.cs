using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.TransactionAggregate
{
    public interface IRequestGeneratorManager
    { 
        RequestGenerationResult Process(CheckoutTransaction CheckoutTransaction);
    }
}
