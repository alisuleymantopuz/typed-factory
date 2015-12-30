using RequestGenerator.Domain.TransactionAggregate;
using RequestGenerator.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.AlternatifBank
{
    public class AlternatifBankRequestGeneratorManager : IRequestGeneratorManager
    {
        public RequestGenerationResult Process(CheckoutTransaction CheckoutTransaction)
        {

            string requestTemplate = BankResources.AlternatifBankRequestTemplate;

            requestTemplate = requestTemplate
                                .Replace("{Name}", CheckoutTransaction.Name)
                                .Replace("{Surname}", CheckoutTransaction.Surname)
                                .Replace("{CardNumber}", CheckoutTransaction.PanInfo.Pan)
                                .Replace("{Expiry}", CheckoutTransaction.PanInfo.Expiry)
                                .Replace("{Cvv}", CheckoutTransaction.PanInfo.Cvv)
                                .Replace("{OrderId}", CheckoutTransaction.OrderId)
                                .Replace("{Type}", CheckoutTransaction.TransactionType.ToString());


            RequestGenerationResult requestGenerationResult = new RequestGenerationResult();
            requestGenerationResult.CheckoutTransaction = CheckoutTransaction;
            requestGenerationResult.GeneratedResult = requestTemplate;

            return requestGenerationResult;
        }
    }
}
