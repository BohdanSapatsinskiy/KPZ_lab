using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._1ChainOfResponsibility
{
    class SupportSystem
    {
        public static void StartSupport()
        {
            var basic = new BasicSupport();
            var billing = new BillingSupport();
            var technical = new TechnicalSupport();
            var advanced = new AdvancedSupport();

            basic.SetNext(billing);
            billing.SetNext(technical);
            technical.SetNext(advanced);

            basic.HandleRequest();
        }
    }
}
