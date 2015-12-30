using Castle.Facilities.TypedFactory;
using RequestGenerator.Domain.AlternatifBank;
using RequestGenerator.Domain.TransactionAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Container.TypedFactorySelectors
{
    public class RequestGeneratorTypedFactorySelector : DefaultTypedFactoryComponentSelector
    {
        protected override string GetComponentName(System.Reflection.MethodInfo method, object[] arguments)
        {
            if (method.Name == "GetRequestGenerator")
            {
                if (arguments != null && arguments.Count() > 0 && arguments[0] is BankInfo)
                {
                    BankInfo bankInfo = arguments[0] as BankInfo;
                    return bankInfo.RequestGeneratorName;
                }
                return string.Empty;
            }
            return base.GetComponentName(method, arguments);
        }
    }
}
