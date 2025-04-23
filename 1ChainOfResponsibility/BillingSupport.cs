using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._1ChainOfResponsibility
{
    class BillingSupport : SupportHandler
    {
        protected override bool ProcessRequest()
        {
            Console.WriteLine("У вас питання щодо оплати або рахунків? (1 - Так, 2 - Ні)");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Вас з'єднано з відділом оплат.");
                return true;
            }
            return false;
        }
    }
}
