using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._1ChainOfResponsibility
{
    class TechnicalSupport : SupportHandler
    {
        protected override bool ProcessRequest()
        {
            Console.WriteLine("У вас технічна проблема з продуктом? (1 - Так, 2 - Ні)");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Вас з'єднано з технічною підтримкою.");
                return true;
            }
            return false;
        }
    }
}
