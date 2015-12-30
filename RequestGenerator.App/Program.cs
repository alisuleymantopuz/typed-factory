using RequestGenerator.Container;
using RequestGenerator.Domain.TransactionAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Initialize();
            IRequestGeneratorFactory factory = Bootstrapper.Container.Resolve<IRequestGeneratorFactory>();
            BankInfo bankInfo = new BankInfo();
            bankInfo.Name = "AlternatifBank";
            bankInfo.RequestGeneratorName = "AlternatifBankRequestGeneratorManager";
            CheckoutTransaction transaction = new CheckoutTransaction()
            {
                Name = "John",
                Surname = "Smith",
                Amount = new Amount()
                {
                    AmountTotal = 12,
                    CurrencyCode = "EUR"
                },
                Id = 1,
                BankInfo = bankInfo,
                OrderId = Guid.NewGuid().ToString().Replace("-", "").ToUpper(),
                TransactionId = Guid.NewGuid().ToString().Replace("-", "").ToUpper(),
                PanInfo = new PanInfo()
                {
                    Pan = "4012001011110000",
                    Cvv = "999",
                    Expiry = "0518",
                    PanMasked = "401200******0000"
                },
                TransactionType = TransactionType.Sale
            };
            IRequestGeneratorManager alternatifBankManager = factory.GetRequestGenerator(bankInfo);
            RequestGenerationResult result = alternatifBankManager.Process(transaction);
            Console.WriteLine(result.GeneratedResult);
            Console.ReadKey();
        }
    }
}
