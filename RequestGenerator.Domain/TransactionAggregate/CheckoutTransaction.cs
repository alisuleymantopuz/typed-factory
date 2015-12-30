using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Domain.TransactionAggregate
{
    public class CheckoutTransaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TransactionId{ get; set; }
        public string OrderId { get; set; }
        public BankInfo BankInfo { get; set; }
        public PanInfo PanInfo { get; set; }
        public Amount Amount { get; set; }
        public CheckoutTransaction ReferenceTransaction { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
